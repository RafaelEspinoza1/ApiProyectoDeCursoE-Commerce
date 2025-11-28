using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApiE_Commerce.Views
{
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            // 1. (Opcional) VALIDACIÓN PRIMERO
            // Verificamos que se haya ingresado un monto y que cubra el total
            if (!ValidarPago())
            {
                return; // Si la validación falla, no continuamos
            }

            // 2. PREGUNTA AL USUARIO (Lo que solicitaste)
            // MessageBoxButtons.OKCancel muestra los botones "Aceptar" y "Cancelar"
            DialogResult respuesta = MessageBox.Show(
                "¿Desea generar una factura para esta compra?",
                "Confirmación de Facturación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // 3. LÓGICA SEGÚN LA RESPUESTA
            if (respuesta == DialogResult.Yes)
            {
                // El usuario dijo "Aceptar" (Sí quiero factura)
                GenerarFactura();
                GuardarCompraEnBD(); // Guardamos la venta
                MessageBox.Show("Compra realizada y factura generada exitosamente.", "Éxito");
            }
            else
            {
                // El usuario dijo "Cancelar" (No quiero factura, solo comprar)
                GuardarCompraEnBD(); // Solo guardamos la venta
                MessageBox.Show("Compra realizada exitosamente (Sin factura).", "Éxito");
            }
        }

        // --- FUNCIONES AUXILIARES ---

        // Función simulada para imprimir o crear el PDF de la factura
        private void GenerarFactura()
        {
            // Aquí capturas los datos de tus TextBoxes
            string precioUnitario = txtPrecioUnitario.Text;
            string unidades = txtUnidades.Text;
            string envio = txtEnvio.Text;
            string descuento = txtDescuento.Text;
            string total = txtTotal.Text;

            // AQUÍ IRÍA TU LÓGICA DE REPORTE (Ej. Crystal Reports, PDFSharp, iText7)
            // Por ahora, solo lo imprimimos en consola para probar
            Console.WriteLine($"Generando factura por un total de: {total}");

            // Ejemplo: FormularioFactura factura = new FormularioFactura(total, ...);
            // factura.Show();
        }

        // Función simulada para guardar en base de datos
        private void GuardarCompraEnBD()
        {
            // Aquí iría tu código INSERT INTO Ventas ...
            Console.WriteLine("Guardando datos en la base de datos...");
        }

        // Validación simple para asegurar que los números sean correctos
        private bool ValidarPago()
        {
            try
            {
                decimal total = decimal.Parse(txtTotal.Text);
                decimal pago = decimal.Parse(txtMontoPagar.Text);

                if (pago < total)
                {
                    MessageBox.Show("El monto a pagar es menor que el precio total.", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Por favor verifique que los montos sean números válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
