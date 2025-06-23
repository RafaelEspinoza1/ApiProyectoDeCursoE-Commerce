using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

using System.Net.Http.Json;
using FormApiE_Commerce.Models;
using FormApiE_Commerce.DTOs.VendedoresDTOs;
using System.Text.RegularExpressions;

namespace FormApiE_Commerce
{
    public partial class Vender : UserControl
    {
        private readonly GMapOverlay markersOverlay = new GMapOverlay("markers");
        GMarkerGoogle marcador;
        GMapOverlay capamarcador;
        DataTable data;

        bool trazarRuta = false;
        int contador = 0;
        PointLatLng inicio;
        PointLatLng final;

        int filaseleccionada = 0;
        double latDefault = 12.1368;
        double lngDefault = -86.230020000;

        private int _usuarioId;
        public Vender(int usuarioId)
        {
            InitializeComponent();
            gMapControl1.Visible = false;
            pictureBox1.Image = Properties.Resources.MascotaE_CommerceRegistroVendedor;
            _usuarioId = usuarioId;
        }

        private void Vender_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latDefault, lngDefault);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            capamarcador = new GMapOverlay("MARCADOR");
            marcador = new GMarkerGoogle(new PointLatLng(latDefault, lngDefault), GMarkerGoogleType.red);
            capamarcador.Markers.Add(marcador);

            marcador.ToolTipMode = MarkerTooltipMode.Always;
            marcador.ToolTipText = string.Format("ubicacion: \n latitud:{0} \n longitud:{1}", latDefault, lngDefault);

            gMapControl1.Overlays.Add(capamarcador);
            btnBuscar.Click += async (s, e) => await BuscarLugar(txtBuscar.Text);
            gMapControl1.Overlays.Add(markersOverlay);

        }



        private async Task BuscarLugar(string lugar)
        {
            gMapControl1.Visible = true;
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Por favor ingresa un nombre de lugar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lugar)) return;

            string url = $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(lugar)}&format=json&limit=1";
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("MiAppGMap/1.0 (tucorreo@ejemplo.com)");

            try
            {
                string response = await client.GetStringAsync(url);
                var resultados = JsonSerializer.Deserialize<List<NominatimResultado>>(response, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (resultados != null && resultados.Count > 0)
                {
                    double lat = double.Parse(resultados[0].lat, CultureInfo.InvariantCulture);
                    double lon = double.Parse(resultados[0].lon, CultureInfo.InvariantCulture);

                    gMapControl1.Position = new PointLatLng(lat, lon);
                    gMapControl1.Zoom = 15;

                    textBox1.Text = resultados[0].display_name;


                    AgregarMarcador(new PointLatLng(lat, lon), resultados[0].display_name);
                }
                else
                {
                    MessageBox.Show("No se encontró el lugar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }


        private void AgregarMarcador(PointLatLng punto, string tooltip)
        {
            markersOverlay.Markers.Clear(); // Limpia anteriores para tener solo uno a la vez

            var marcador = new GMarkerGoogle(punto, GMarkerGoogleType.red_dot)
            {
                ToolTipText = tooltip,
                ToolTipMode = MarkerTooltipMode.OnMouseOver
            };

            markersOverlay.Markers.Add(marcador);
            gMapControl1.Position = punto;
            gMapControl1.Zoom = 15;



        }


        public async Task<string> ObtenerDireccionOpenStreetMap(double lat, double lng)
        {
            string url = $"https://nominatim.openstreetmap.org/reverse?lat={lat.ToString(CultureInfo.InvariantCulture)}&lon={lng.ToString(CultureInfo.InvariantCulture)}&format=json";

            using (HttpClient cliente = new HttpClient())
            {
                cliente.DefaultRequestHeaders.Add("User-Agent", "UbicacionEcommerce/1.0 (laapaos886@gmail.com)");

                var respuesta = await cliente.GetAsync(url);
                if (respuesta.IsSuccessStatusCode)
                {
                    string contenido = await respuesta.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(contenido);
                    return json.display_name;
                }
                else
                {
                    return $"Error: {respuesta.StatusCode} - {await respuesta.Content.ReadAsStringAsync()}";
                }
            }
        }



        private async void Mostrarubicacion(object sender, MouseEventArgs e)
        {

            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;


            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            // Obtener dirección
            string direccion = await ObtenerDireccionOpenStreetMap(lat, lng);

            // Mostrar solo la dirección en el TextBox1
            textBox1.Text = direccion;

            // Mover el marcador
            marcador.Position = new PointLatLng(lat, lng);
            marcador.ToolTipText = $"Ubicación:\n{direccion}";

            // Lógica de trazado de rutas si corresponde
            creacionDeDireccion(lat, lng);


        }

        public void creacionDeDireccion(double lat, double lng)
        {
            if (trazarRuta)
            {

                switch (contador)
                {
                    case 0:
                        contador++;
                        inicio = new PointLatLng(lat, lng);
                        break;

                    case 1:
                        contador++;
                        final = new PointLatLng(lat, lng);
                        GDirections direccion;

                        var rutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion, inicio, final, false, false, false, false, false);

                        if (direccion != null && direccion.Route != null)
                        {
                            // la ruta existe, agregarla al mapa
                            GMapRoute rutaobtenida = new GMapRoute(direccion.Route, "ruta de ubicacion");
                            GMapOverlay caparuta = new GMapOverlay("capa de la ruta");
                            caparuta.Routes.Add(rutaobtenida);
                            gMapControl1.Overlays.Add(caparuta);
                            gMapControl1.Zoom = gMapControl1.Zoom + 1;
                            gMapControl1.Zoom = gMapControl1.Zoom - 1;
                        }
                        else
                        {
                            // No se obtuvo la ruta: informa al usuario
                            MessageBox.Show("No se pudo obtener la ruta. Verifica conexión a internet o claves API.");
                        }

                        contador = 0;
                        break;

                }
            }
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            gMapControl1.Visible = true;

        }

        private async void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroDeCuenta.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string cuenta = Regex.Replace(txtNumeroDeCuenta.Text ?? "", @"[^\d]", "").Trim();

                if (!Regex.IsMatch(cuenta, @"^\d{16}$"))
                {
                    MessageBox.Show("El número de cuenta debe tener exactamente 16 dígitos numéricos, sin letras ni símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroDeCuenta.Focus();
                    return;
                }

                
               
                int usuarioId = FormInicio.UsuarioId;
                MessageBox.Show($"Usuario ID: {FormInicio.UsuarioId}");
//>>>>>>> master
                var nuevoVendedor = new
                {
                    NumeroDeCuenta = cuenta,
                    DireccionOrigen = txtDireccion.Text,
                    LatitudOrigen = double.TryParse(txtLatitud.Text, out double lat) ? lat : 0,
                    LongitudOrigen = double.TryParse(txtLongitud.Text, out double lng) ? lng : 0,
                    UsuarioId = usuarioId
                };
               
                using (HttpClient client = new HttpClient())
                {
                    
                    var response = await client.PostAsJsonAsync("https://localhost:7221/api/Vendedores", nuevoVendedor);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("¡Registro exitoso como vendedor!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var vendedorCreado = await response.Content.ReadFromJsonAsync<VendedoresReadDTO>();
                        int vendedorId = vendedorCreado.VendedorId;
                        // Buscar el TabPage donde estás
                        TabPage parentTab = this.Parent as TabPage;
                        if (parentTab != null)
                        {
                            parentTab.Controls.Clear();

                            // Puedes llamar al nuevo UserControl pasando el usuarioId
                            var nuevoForm = new FormVendedorRegistrado(usuarioId, vendedorId); // asegúrate que tenga ese constructor
                            nuevoForm.Dock = DockStyle.Fill;
                            parentTab.Controls.Add(nuevoForm);
                        }
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error al registrar: " + error, "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}

