using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FormApiE_Commerce
{
    public partial class Administracion : Form
    {

        public Administracion()
        {
            InitializeComponent();
            this.Load += Administracion_Load;
        }
        private async void Administracion_Load(object sender, EventArgs e)
        {
            // 1. Cargar Balance General del período anterior (local)
            CargarBalanceGeneralPeriodoAnterior();

            // 2. Cargar Estado de Resultado del primer período (local)
            CargarEstadoResultadoPrimerPeriodo();

            // 3. Cargar Estado de Resultado actual desde API
            await CargarEstadoResultadoActual();

            // 4. Calcular análisis vertical del período anterior
            AnalisisVerticalAnterior();

            // 5. Obtener la utilidad del período actual desde el DataGridView ya cargado
            decimal utilidadDelPeriodo = 0;
            foreach (DataGridViewRow row in dgvEstadoResultadoPeriodoActual.Rows)
            {
                if (row.Cells["NombreCuenta"].Value?.ToString() == "Utilidad del período")
                {
                    if (row.Cells["Saldo"].Value != null)
                        decimal.TryParse(row.Cells["Saldo"].Value.ToString(), out utilidadDelPeriodo);
                    break;
                }
            }

            // 6. Cargar Balance General del período actual usando la utilidad obtenida
            await CargarBalanceGeneralPeriodoActual(utilidadDelPeriodo);

            // 7. Análisis vertical y horizonta

            // 8. Calcular CNO y CNT
            await CalcularCNOyCNT();
        }
        private void CargarEstadoResultadoPrimerPeriodo()
        {
            // Limpiar el DataGridView primero
            dgvEstadoResultadoPeriodoAnterior.Rows.Clear();
            dgvEstadoResultadoPeriodoAnterior.Columns.Clear();

            // Crear columnas
            dgvEstadoResultadoPeriodoAnterior.Columns.Add("NombreCuenta", "Nombre de la Cuenta");
            dgvEstadoResultadoPeriodoAnterior.Columns.Add("Saldo", "Saldo (C$)");

            // Datos del primer período
            dgvEstadoResultadoPeriodoAnterior.Rows.Add("Ingresos", 12800);
            dgvEstadoResultadoPeriodoAnterior.Rows.Add("Gasto de envío", 2800);
            dgvEstadoResultadoPeriodoAnterior.Rows.Add("Renta", 10000);
            dgvEstadoResultadoPeriodoAnterior.Rows.Add("Utilidad Antes de IR", 3000);
            dgvEstadoResultadoPeriodoAnterior.Rows.Add("IR", 0);
            dgvEstadoResultadoPeriodoAnterior.Rows.Add("Utilidad del período", 0);

            // Ajustar tamaño automático de columnas
            dgvEstadoResultadoPeriodoAnterior.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async Task CargarEstadoResultadoActual()
        {
            try
            {
                using var httpClient = new HttpClient();
                var url = "https://localhost:7221/api/Finanzas/get/cuentas";

                var response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("No se pudieron obtener las cuentas del período actual.");
                    return;
                }

                var json = await response.Content.ReadAsStringAsync();

                var cuentas = JsonSerializer.Deserialize<List<CuentaDTO>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (cuentas == null)
                {
                    MessageBox.Show("No se pudo deserializar la respuesta del servidor.");
                    return;
                }

                var cuentasEstado = cuentas
                    .Where(c => c.NombreCuenta.Trim().ToLower() == "ingresos" ||
                                c.NombreCuenta.Trim().ToLower() == "gasto de envio" ||
                                c.NombreCuenta.Trim().ToLower() == "renta")
                    .ToList();

                dgvEstadoResultadoPeriodoActual.Rows.Clear();
                dgvEstadoResultadoPeriodoActual.Columns.Clear();

                dgvEstadoResultadoPeriodoActual.Columns.Add("NombreCuenta", "Nombre de la Cuenta");
                dgvEstadoResultadoPeriodoActual.Columns.Add("Saldo", "Saldo (C$)");

                decimal ingresos = 0, gastosEnvio = 0, renta = 0;

                foreach (var cuenta in cuentasEstado)
                {
                    dgvEstadoResultadoPeriodoActual.Rows.Add(cuenta.NombreCuenta, cuenta.SaldoActual);

                    switch (cuenta.NombreCuenta.Trim().ToLower())
                    {
                        case "ingresos":
                            ingresos = cuenta.SaldoActual;
                            break;
                        case "gasto de envio":
                            gastosEnvio = cuenta.SaldoActual;
                            break;
                        case "renta":
                            renta = cuenta.SaldoActual;
                            break;
                    }
                }

                decimal utilidadAntesIR = ingresos - (gastosEnvio + renta);
                dgvEstadoResultadoPeriodoActual.Rows.Add("Utilidad Antes de IR", utilidadAntesIR);
                dgvEstadoResultadoPeriodoActual.Rows.Add("IR", 0);
                dgvEstadoResultadoPeriodoActual.Rows.Add("Utilidad del período", utilidadAntesIR);

                dgvEstadoResultadoPeriodoActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Calcular análisis vertical y horizontal después de tener todas las filas
                AnalisisVerticalActual();
                AnalisisHorizontal();

                // Resaltar la última fila
                var lastRow = dgvEstadoResultadoPeriodoActual.Rows[dgvEstadoResultadoPeriodoActual.Rows.Count - 1];
                lastRow.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lastRow.DefaultCellStyle.ForeColor = utilidadAntesIR < 0 ? Color.Red : Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando datos: " + ex.Message);
            }
        }

        private void AnalisisVerticalActual()
        {
            if (dgvEstadoResultadoPeriodoActual.Rows.Count == 0) return;

            // Agregar columna de porcentaje vertical si no existe
            if (!dgvEstadoResultadoPeriodoActual.Columns.Contains("Porcentaje"))
                dgvEstadoResultadoPeriodoActual.Columns.Add("Porcentaje", "% Vertical");

            // Obtener ingresos
            decimal ingresos = 0;
            foreach (DataGridViewRow row in dgvEstadoResultadoPeriodoActual.Rows)
            {
                if (row.Cells["NombreCuenta"].Value?.ToString().Trim().ToLower() == "ingresos")
                {
                    ingresos = Convert.ToDecimal(row.Cells["Saldo"].Value);
                    break;
                }
            }

            // Si ingresos es 0, no hacemos división por cero, usamos 1 para cálculo temporal
            bool ingresosCero = false;
            if (ingresos == 0)
            {
                ingresos = 1;
                ingresosCero = true;
            }

            // Calcular porcentaje para cada fila
            foreach (DataGridViewRow row in dgvEstadoResultadoPeriodoActual.Rows)
            {
                if (row.Cells["Saldo"].Value != null)
                {
                    decimal saldo = Convert.ToDecimal(row.Cells["Saldo"].Value);
                    if (ingresosCero)
                    {
                        row.Cells["Porcentaje"].Value = "0 %";
                    }
                    else
                    {
                        row.Cells["Porcentaje"].Value = Math.Round((saldo / ingresos) * 100, 2) + " %";
                    }
                }
            }
        }

        private void AnalisisHorizontal()
        {
            if (dgvEstadoResultadoPeriodoActual.Rows.Count == 0 ||
                dgvEstadoResultadoPeriodoAnterior.Rows.Count == 0) return;

            // Agregar columnas de cambio si no existen
            if (!dgvEstadoResultadoPeriodoActual.Columns.Contains("Cambio"))
                dgvEstadoResultadoPeriodoActual.Columns.Add("Cambio", "Cambio Absoluto");
            if (!dgvEstadoResultadoPeriodoActual.Columns.Contains("CambioPorc"))
                dgvEstadoResultadoPeriodoActual.Columns.Add("CambioPorc", "Cambio %");

            foreach (DataGridViewRow rowActual in dgvEstadoResultadoPeriodoActual.Rows)
            {
                string nombre = rowActual.Cells["NombreCuenta"].Value?.ToString() ?? "";
                decimal saldoActual = Convert.ToDecimal(rowActual.Cells["Saldo"].Value);

                // Buscar el saldo del período anterior
                decimal saldoAnterior = 0;
                foreach (DataGridViewRow rowAnterior in dgvEstadoResultadoPeriodoAnterior.Rows)
                {
                    if (rowAnterior.Cells["NombreCuenta"].Value?.ToString() == nombre)
                    {
                        saldoAnterior = Convert.ToDecimal(rowAnterior.Cells["Saldo"].Value);
                        break;
                    }
                }

                // Calcular cambios
                decimal cambio = saldoActual - saldoAnterior;
                decimal cambioPorc = saldoAnterior != 0 ? (cambio / saldoAnterior) * 100 : 0;

                rowActual.Cells["Cambio"].Value = cambio;
                rowActual.Cells["CambioPorc"].Value = Math.Round(cambioPorc, 2) + " %";
            }
        }
        private void AnalisisVerticalAnterior()
        {
            if (dgvEstadoResultadoPeriodoAnterior.Rows.Count == 0) return;

            // Agregar columna de porcentaje vertical si no existe
            if (!dgvEstadoResultadoPeriodoAnterior.Columns.Contains("Porcentaje"))
                dgvEstadoResultadoPeriodoAnterior.Columns.Add("Porcentaje", "% Vertical");

            // Obtener ingresos
            decimal ingresos = 0;
            foreach (DataGridViewRow row in dgvEstadoResultadoPeriodoAnterior.Rows)
            {
                if (row.Cells["NombreCuenta"].Value?.ToString().ToLower() == "ingresos")
                {
                    ingresos = Convert.ToDecimal(row.Cells["Saldo"].Value);
                    break;
                }
            }

            if (ingresos == 0) return; // evitar división por cero

            // Calcular porcentaje para cada fila
            foreach (DataGridViewRow row in dgvEstadoResultadoPeriodoAnterior.Rows)
            {
                if (row.Cells["Saldo"].Value != null)
                {
                    decimal saldo = Convert.ToDecimal(row.Cells["Saldo"].Value);
                    row.Cells["Porcentaje"].Value = Math.Round((saldo / ingresos) * 100, 2) + " %";
                }
            }
        }
        private void CargarBalanceGeneralPeriodoAnterior()
        {
            // Limpiar el DataGridView primero
            dgvBalanceGeneralPeriodoAnterior.Rows.Clear();
            dgvBalanceGeneralPeriodoAnterior.Columns.Clear();

            // Crear columnas
            dgvBalanceGeneralPeriodoAnterior.Columns.Add("Cuenta", "Cuenta");
            dgvBalanceGeneralPeriodoAnterior.Columns.Add("Saldo", "Saldo (C$)");

            decimal totalActivos = 0, totalPasivos = 0, totalCapital = 0;

            // =======================
            // ACTIVOS
            // =======================
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("ACTIVOS", "");

            // Activos
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Efectivo", 0);
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Mobiliario y accesorios", 36000);
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Vehículos", 50000);

            // Depreciaciones (como ajustes negativos)
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Depreciación de mobiliario y accesorios", 0);
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Depreciación de vehículos", 0);

            // Sumar activos reales
            totalActivos = 0 + 36000 + 50000 - 0 - 0; // Ajusta si hay depreciaciones diferentes
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Total Activos", totalActivos);

            // =======================
            // PASIVOS
            // =======================
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("PASIVOS", "");

            // No hay pasivos en el periodo anterior (puedes agregar si los necesitas)
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Total Pasivos", totalPasivos);

            // =======================
            // CAPITAL
            // =======================
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("CAPITAL", "");

            decimal capitalSocial = 86000;
            decimal utilidadesRetenidas = 0;

            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Capital Social", capitalSocial);
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Utilidades Retenidas", utilidadesRetenidas);

            totalCapital = capitalSocial + utilidadesRetenidas;
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Total Capital", totalCapital);
            decimal PasivoMasCapital = totalPasivos + totalCapital;
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Total Pasivo Capital", PasivoMasCapital);

            // Diferencia para verificar que cuadre Activos = Pasivos + Capital
            decimal diferencia = totalActivos - (totalPasivos + totalCapital);
            dgvBalanceGeneralPeriodoAnterior.Rows.Add("Diferencia", diferencia);

            dgvBalanceGeneralPeriodoAnterior.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Resaltar totales
            var lastRow = dgvBalanceGeneralPeriodoAnterior.Rows[dgvBalanceGeneralPeriodoAnterior.Rows.Count - 1];
            lastRow.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private async Task CargarBalanceGeneralPeriodoActual(decimal utilidadPeriodo)
        {
            try
            {
                using var httpClient = new HttpClient();
                var url = "https://localhost:7221/api/Finanzas/get/cuentas";

                var response = await httpClient.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("No se pudieron obtener las cuentas del balance general.");
                    return;
                }

                var json = await response.Content.ReadAsStringAsync();
                var cuentas = JsonSerializer.Deserialize<List<CuentaDTO>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (cuentas == null)
                {
                    MessageBox.Show("No se pudo deserializar la respuesta del servidor.");
                    return;
                }

                dgvBalanceGeneralPeriodoActual.Rows.Clear();
                dgvBalanceGeneralPeriodoActual.Columns.Clear();
                dgvBalanceGeneralPeriodoActual.Columns.Add("Cuenta", "Cuenta");
                dgvBalanceGeneralPeriodoActual.Columns.Add("Saldo", "Saldo (C$)");

                decimal totalActivos = 0, totalPasivos = 0, totalCapital = 0;

                // =======================
                // ACTIVOS
                // =======================
                dgvBalanceGeneralPeriodoActual.Rows.Add("ACTIVOS", "");

                var activos = cuentas.Where(c =>
                    c.NombreCuenta.ToLower() == "efectivo" ||
                    c.NombreCuenta.ToLower() == "mobiliario y accesorios" ||
                    c.NombreCuenta.ToLower() == "vehiculos"
                );

                foreach (var cuenta in activos)
                {
                    dgvBalanceGeneralPeriodoActual.Rows.Add(cuenta.NombreCuenta, cuenta.SaldoActual);
                    totalActivos += cuenta.SaldoActual;
                }

                // Depreciaciones como ajuste negativo de activos
                var depreciaciones = cuentas.Where(c => c.NombreCuenta.ToLower().Contains("depreciacion"));
                foreach (var cuenta in depreciaciones)
                {
                    dgvBalanceGeneralPeriodoActual.Rows.Add(cuenta.NombreCuenta, -cuenta.SaldoActual);
                    totalActivos -= cuenta.SaldoActual;
                }

                dgvBalanceGeneralPeriodoActual.Rows.Add("Total Activos", totalActivos);

                // =======================
                // PASIVOS
                // =======================
                dgvBalanceGeneralPeriodoActual.Rows.Add("PASIVOS", "");

                // Renta por pagar (agregada desde código)
                decimal rentaPorPagar = 10000; // ejemplo
                dgvBalanceGeneralPeriodoActual.Rows.Add("Renta por pagar", rentaPorPagar);
                totalPasivos += rentaPorPagar;

                dgvBalanceGeneralPeriodoActual.Rows.Add("Total Pasivos", totalPasivos);

                // =======================
                // CAPITAL
                // =======================
                dgvBalanceGeneralPeriodoActual.Rows.Add("CAPITAL", "");

                decimal capitalSocial = cuentas.FirstOrDefault(c => c.NombreCuenta.ToLower() == "capital social")?.SaldoActual ?? 0;
                decimal utilidadesRetenidas = (cuentas.FirstOrDefault(c => c.NombreCuenta.ToLower() == "utilidades retenidas")?.SaldoActual ?? 0) + utilidadPeriodo;

                dgvBalanceGeneralPeriodoActual.Rows.Add("Capital Social", capitalSocial);
                dgvBalanceGeneralPeriodoActual.Rows.Add("Utilidades Retenidas", utilidadesRetenidas);

                totalCapital = capitalSocial + utilidadesRetenidas;
                dgvBalanceGeneralPeriodoActual.Rows.Add("Total Capital", totalCapital);
                decimal PasivoMasCapital = totalPasivos + totalCapital;
                dgvBalanceGeneralPeriodoActual.Rows.Add("Total Pasivo Capital", PasivoMasCapital);

                // Comprobar que Activos = Pasivos + Capital
                decimal diferencia = totalActivos - (totalPasivos + totalCapital);
                dgvBalanceGeneralPeriodoActual.Rows.Add("Diferencia", diferencia);

                dgvBalanceGeneralPeriodoActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando Balance General: " + ex.Message);
            }
        }
        private async         Task
CalcularCNOyCNT()
        {
            try
            {
                using var httpClient = new HttpClient();
                var url = "https://localhost:7221/api/Finanzas/get/cuentas";

                var response = await httpClient.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("No se pudieron obtener las cuentas para calcular CNO y CNT.");
                    return;
                }

                var json = await response.Content.ReadAsStringAsync();
                var cuentas = JsonSerializer.Deserialize<List<CuentaDTO>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (cuentas == null)
                {
                    MessageBox.Show("No se pudo deserializar la respuesta del servidor.");
                    return;
                }

                decimal activosCorrientes = 0;
                decimal pasivosCorrientes = 0;
                decimal totalActivos = 0;
                decimal totalPasivos = 0;
                decimal totalCapital = 0;

                foreach (var cuenta in cuentas)
                {
                    string nombre = cuenta.NombreCuenta.Trim().ToLower();
                    decimal saldo = cuenta.SaldoActual;

                    // ACTIVO
                    if (nombre == "efectivo")
                        activosCorrientes += saldo;

                    if (nombre == "efectivo" || nombre == "mobiliario y accesorios" || nombre == "vehiculos")
                        totalActivos += saldo;

                    if (nombre.StartsWith("depreciacion"))
                        totalActivos -= saldo;

                    // PASIVO
                    if (nombre == "renta")
                    {
                        pasivosCorrientes += saldo;
                        totalPasivos += saldo;
                    }

                    // CAPITAL
                    if (nombre == "capital social" || nombre == "utilidades retenidas")
                        totalCapital += saldo;
                }

                // Cálculos
                decimal cno = activosCorrientes - pasivosCorrientes;
                decimal cnt = totalActivos - (totalPasivos + totalCapital);

                // Mostrar
                txtCNO.Text = cno.ToString("N2");
                txtCNT.Text = cnt.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculando CNO y CNT: " + ex.Message);
            }
        }
       
    }
}
