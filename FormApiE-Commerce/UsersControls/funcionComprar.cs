using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApiE_Commerce.UsersControls
{
    public partial class funcionComprar : UserControl
    {
        private Random rng = new Random();
        public funcionComprar()
        {
            InitializeComponent();
            ConfigurarDiseñoGrid();
        }


        public void CargarGridRandomizado(List<Producto> productosDeLaApi)
        {
            // 1. Limpieza inicial
            FlwProductos.Controls.Clear();

            // Si la lista es nula o vacía, salimos para evitar errores
            if (productosDeLaApi == null || productosDeLaApi.Count == 0) return;

            // 2. RANDOMIZACIÓN (Algoritmo Fisher-Yates)
            // Trabajamos sobre una copia para no alterar la lista original si la usas en otro lado
            var listaBarajada = new List<Producto>(productosDeLaApi);

            int n = listaBarajada.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Producto valor = listaBarajada[k];
                listaBarajada[k] = listaBarajada[n];
                listaBarajada[n] = valor;
            }

            // 3. GENERACIÓN DE TARJETAS
            // SuspendLayout evita el parpadeo visual mientras se agregan los controles
            FlwProductos.SuspendLayout();

            //foreach (var item in listaBarajada)
            //{
            //    // Instanciamos el control
            //    TargetaDeProducto tarjeta = new TargetaDeProducto();

            //    // Le inyectamos los datos
            //    tarjeta.CargarDatos(item);

            //    // Márgenes para separación visual
            //    tarjeta.Margin = new Padding(10);

            //    // Agregamos al contenedor
            //    FlwProductos.Controls.Add(tarjeta);
            //}

            // Reactivamos el dibujado
            FlwProductos.ResumeLayout();
        }

        private void ConfigurarDiseñoGrid()
        {
            FlwProductos.AutoScroll = true;
            FlwProductos.WrapContents = true;
            FlwProductos.FlowDirection = FlowDirection.LeftToRight;
        }
    }


}
