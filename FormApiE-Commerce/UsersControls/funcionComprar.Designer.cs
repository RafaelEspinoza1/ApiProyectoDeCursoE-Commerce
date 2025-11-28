namespace FormApiE_Commerce.UsersControls
{
    partial class funcionComprar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(funcionComprar));
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            CmbCategorias = new CuoreUI.Controls.cuiComboBox();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            tbxbuscarProducto = new CuoreUI.Controls.cuiTextBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            FlwProductos = new FlowLayoutPanel();
            pnlProducto1 = new CuoreUI.Controls.cuiPanel();
            pnlProducto2 = new CuoreUI.Controls.cuiPanel();
            pnlProducto3 = new CuoreUI.Controls.cuiPanel();
            pnlProducto4 = new CuoreUI.Controls.cuiPanel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            label3 = new Label();
            label4 = new Label();
            cuiButton3 = new CuoreUI.Controls.cuiButton();
            label5 = new Label();
            label6 = new Label();
            cuiButton4 = new CuoreUI.Controls.cuiButton();
            label7 = new Label();
            label8 = new Label();
            cuiPanel8.SuspendLayout();
            cuiPanel3.SuspendLayout();
            FlwProductos.SuspendLayout();
            pnlProducto1.SuspendLayout();
            pnlProducto2.SuspendLayout();
            pnlProducto3.SuspendLayout();
            pnlProducto4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel8
            // 
            cuiPanel8.Controls.Add(cuiLabel3);
            cuiPanel8.Controls.Add(CmbCategorias);
            cuiPanel8.Controls.Add(BtnBuscar);
            cuiPanel8.Controls.Add(tbxbuscarProducto);
            cuiPanel8.Controls.Add(cuiLabel1);
            cuiPanel8.Controls.Add(cuiPictureBox1);
            cuiPanel8.Dock = DockStyle.Top;
            cuiPanel8.Location = new Point(0, 0);
            cuiPanel8.Margin = new Padding(3, 2, 3, 2);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.White;
            cuiPanel8.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel8.Rounding = new Padding(8);
            cuiPanel8.Size = new Size(1034, 260);
            cuiPanel8.TabIndex = 6;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Categorias\\ ";
            cuiLabel3.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(573, 195);
            cuiLabel3.Margin = new Padding(4, 4, 4, 4);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(108, 21);
            cuiLabel3.TabIndex = 9;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // CmbCategorias
            // 
            CmbCategorias.BackColor = Color.Transparent;
            CmbCategorias.BackgroundColor = Color.FromArgb(255, 255, 255);
            CmbCategorias.DropDownBackgroundColor = Color.White;
            CmbCategorias.DropDownForeColor = Color.FromArgb(27, 27, 27);
            CmbCategorias.ExpandArrowColor = Color.Gray;
            CmbCategorias.Font = new Font("Garamond", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CmbCategorias.ForeColor = Color.Black;
            CmbCategorias.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            CmbCategorias.Location = new Point(690, 188);
            CmbCategorias.Margin = new Padding(5, 4, 5, 4);
            CmbCategorias.Name = "CmbCategorias";
            CmbCategorias.NoSelectionText = "None";
            CmbCategorias.OutlineColor = Color.Black;
            CmbCategorias.OutlineThickness = 1F;
            CmbCategorias.Rounding = 8;
            CmbCategorias.SelectedIndex = -1;
            CmbCategorias.SelectedItem = "";
            CmbCategorias.Size = new Size(271, 36);
            CmbCategorias.SortAlphabetically = true;
            CmbCategorias.TabIndex = 8;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.White;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.Location = new Point(523, 188);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(44, 38);
            BtnBuscar.TabIndex = 7;
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // tbxbuscarProducto
            // 
            tbxbuscarProducto.BackColor = Color.Transparent;
            tbxbuscarProducto.BackgroundColor = Color.LightGray;
            tbxbuscarProducto.Content = "";
            tbxbuscarProducto.FocusBackgroundColor = Color.White;
            tbxbuscarProducto.FocusImageTint = Color.White;
            tbxbuscarProducto.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbxbuscarProducto.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxbuscarProducto.ForeColor = Color.Gray;
            tbxbuscarProducto.Image = null;
            tbxbuscarProducto.ImageExpand = new Point(0, 0);
            tbxbuscarProducto.ImageOffset = new Point(0, 0);
            tbxbuscarProducto.Location = new Point(140, 188);
            tbxbuscarProducto.Margin = new Padding(4, 3, 4, 3);
            tbxbuscarProducto.Multiline = false;
            tbxbuscarProducto.Name = "tbxbuscarProducto";
            tbxbuscarProducto.NormalImageTint = Color.White;
            tbxbuscarProducto.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            tbxbuscarProducto.Padding = new Padding(15, 10, 15, 0);
            tbxbuscarProducto.PasswordChar = false;
            tbxbuscarProducto.PlaceholderColor = SystemColors.WindowText;
            tbxbuscarProducto.PlaceholderText = "";
            tbxbuscarProducto.Rounding = new Padding(8);
            tbxbuscarProducto.Size = new Size(376, 34);
            tbxbuscarProducto.TabIndex = 2;
            tbxbuscarProducto.TextOffset = new Size(0, 0);
            tbxbuscarProducto.UnderlinedStyle = true;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Seleccion\\ de\\ los\\ mejores\\ productos\\ premiun";
            cuiLabel1.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = SystemColors.ButtonShadow;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(334, 141);
            cuiLabel1.Margin = new Padding(4, 4, 4, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(377, 26);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.Transparent;
            cuiPictureBox1.Content = Properties.Resources.LRR_removebg_preview;
            cuiPictureBox1.ForeColor = Color.BurlyWood;
            cuiPictureBox1.ImageTint = Color.Black;
            cuiPictureBox1.Location = new Point(368, -8);
            cuiPictureBox1.Margin = new Padding(4, 4, 4, 4);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(276, 224);
            cuiPictureBox1.TabIndex = 0;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Controls.Add(FlwProductos);
            cuiPanel3.Controls.Add(cuiLabel2);
            cuiPanel3.Dock = DockStyle.Fill;
            cuiPanel3.Location = new Point(0, 274);
            cuiPanel3.Margin = new Padding(3, 2, 3, 2);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(1034, 363);
            cuiPanel3.TabIndex = 9;
            // 
            // FlwProductos
            // 
            FlwProductos.Controls.Add(pnlProducto1);
            FlwProductos.Controls.Add(pnlProducto2);
            FlwProductos.Controls.Add(pnlProducto3);
            FlwProductos.Controls.Add(pnlProducto4);
            FlwProductos.Location = new Point(31, 50);
            FlwProductos.Margin = new Padding(3, 2, 3, 2);
            FlwProductos.Name = "FlwProductos";
            FlwProductos.Size = new Size(985, 292);
            FlwProductos.TabIndex = 1;
            // 
            // pnlProducto1
            // 
            pnlProducto1.Controls.Add(cuiButton1);
            pnlProducto1.Controls.Add(label2);
            pnlProducto1.Controls.Add(label1);
            pnlProducto1.Controls.Add(pictureBox1);
            pnlProducto1.Location = new Point(3, 2);
            pnlProducto1.Margin = new Padding(3, 2, 3, 2);
            pnlProducto1.Name = "pnlProducto1";
            pnlProducto1.OutlineThickness = 1F;
            pnlProducto1.PanelColor = Color.White;
            pnlProducto1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlProducto1.Rounding = new Padding(8);
            pnlProducto1.Size = new Size(239, 290);
            pnlProducto1.TabIndex = 0;
            // 
            // pnlProducto2
            // 
            pnlProducto2.Controls.Add(cuiButton2);
            pnlProducto2.Controls.Add(label3);
            pnlProducto2.Controls.Add(label4);
            pnlProducto2.Controls.Add(pictureBox2);
            pnlProducto2.Location = new Point(248, 2);
            pnlProducto2.Margin = new Padding(3, 2, 3, 2);
            pnlProducto2.Name = "pnlProducto2";
            pnlProducto2.OutlineThickness = 1F;
            pnlProducto2.PanelColor = Color.White;
            pnlProducto2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlProducto2.Rounding = new Padding(8);
            pnlProducto2.Size = new Size(239, 290);
            pnlProducto2.TabIndex = 1;
            // 
            // pnlProducto3
            // 
            pnlProducto3.Controls.Add(cuiButton3);
            pnlProducto3.Controls.Add(label5);
            pnlProducto3.Controls.Add(label6);
            pnlProducto3.Controls.Add(pictureBox3);
            pnlProducto3.Location = new Point(493, 2);
            pnlProducto3.Margin = new Padding(3, 2, 3, 2);
            pnlProducto3.Name = "pnlProducto3";
            pnlProducto3.OutlineThickness = 1F;
            pnlProducto3.PanelColor = Color.White;
            pnlProducto3.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlProducto3.Rounding = new Padding(8);
            pnlProducto3.Size = new Size(239, 290);
            pnlProducto3.TabIndex = 2;
            // 
            // pnlProducto4
            // 
            pnlProducto4.Controls.Add(cuiButton4);
            pnlProducto4.Controls.Add(label7);
            pnlProducto4.Controls.Add(label8);
            pnlProducto4.Controls.Add(pictureBox4);
            pnlProducto4.Location = new Point(738, 2);
            pnlProducto4.Margin = new Padding(3, 2, 3, 2);
            pnlProducto4.Name = "pnlProducto4";
            pnlProducto4.OutlineThickness = 1F;
            pnlProducto4.PanelColor = Color.White;
            pnlProducto4.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlProducto4.Rounding = new Padding(8);
            pnlProducto4.Size = new Size(239, 290);
            pnlProducto4.TabIndex = 3;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Productos\\ destacados";
            cuiLabel2.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(11, 8);
            cuiLabel2.Margin = new Padding(4, 4, 4, 4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(263, 27);
            cuiLabel2.TabIndex = 0;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiSeparator1
            // 
            cuiSeparator1.BackColor = Color.White;
            cuiSeparator1.Dock = DockStyle.Top;
            cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiSeparator1.Location = new Point(0, 260);
            cuiSeparator1.Margin = new Padding(4, 4, 4, 4);
            cuiSeparator1.Name = "cuiSeparator1";
            cuiSeparator1.SeparatorMargin = 8;
            cuiSeparator1.Size = new Size(1034, 14);
            cuiSeparator1.TabIndex = 8;
            cuiSeparator1.Thickness = 0.5F;
            cuiSeparator1.Vertical = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 200);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 200);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 206);
            label1.Name = "label1";
            label1.Size = new Size(106, 14);
            label1.TabIndex = 2;
            label1.Text = "Escudo de Hyrule";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 220);
            label2.Name = "label2";
            label2.Size = new Size(91, 14);
            label2.TabIndex = 3;
            label2.Text = "Precio: 1500 CS";
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Ver mas...";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(62, 237);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(122, 41);
            cuiButton1.TabIndex = 2;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Ver mas...";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton2.ForeColor = Color.Black;
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverImageTint = Color.White;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(68, 237);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.White;
            cuiButton2.NormalForeColor = Color.Black;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(122, 41);
            cuiButton2.TabIndex = 4;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 220);
            label3.Name = "label3";
            label3.Size = new Size(92, 14);
            label3.TabIndex = 6;
            label3.Text = "Precio: 2000 CS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 206);
            label4.Name = "label4";
            label4.Size = new Size(51, 14);
            label4.TabIndex = 5;
            label4.Text = "Zapatos";
            // 
            // cuiButton3
            // 
            cuiButton3.CheckButton = false;
            cuiButton3.Checked = false;
            cuiButton3.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton3.CheckedForeColor = Color.White;
            cuiButton3.CheckedImageTint = Color.White;
            cuiButton3.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton3.Content = "Ver mas...";
            cuiButton3.DialogResult = DialogResult.None;
            cuiButton3.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton3.ForeColor = Color.Black;
            cuiButton3.HoverBackground = Color.White;
            cuiButton3.HoverForeColor = Color.Black;
            cuiButton3.HoverImageTint = Color.White;
            cuiButton3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton3.Image = null;
            cuiButton3.ImageAutoCenter = true;
            cuiButton3.ImageExpand = new Point(0, 0);
            cuiButton3.ImageOffset = new Point(0, 0);
            cuiButton3.Location = new Point(65, 237);
            cuiButton3.Name = "cuiButton3";
            cuiButton3.NormalBackground = Color.White;
            cuiButton3.NormalForeColor = Color.Black;
            cuiButton3.NormalImageTint = Color.White;
            cuiButton3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.OutlineThickness = 1F;
            cuiButton3.PressedBackground = Color.WhiteSmoke;
            cuiButton3.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton3.PressedImageTint = Color.White;
            cuiButton3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.Rounding = new Padding(8);
            cuiButton3.Size = new Size(122, 41);
            cuiButton3.TabIndex = 4;
            cuiButton3.TextAlignment = StringAlignment.Center;
            cuiButton3.TextOffset = new Point(0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 220);
            label5.Name = "label5";
            label5.Size = new Size(86, 14);
            label5.TabIndex = 6;
            label5.Text = "Precio: 500 CS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(97, 206);
            label6.Name = "label6";
            label6.Size = new Size(48, 14);
            label6.TabIndex = 5;
            label6.Text = "Camisa";
            // 
            // cuiButton4
            // 
            cuiButton4.CheckButton = false;
            cuiButton4.Checked = false;
            cuiButton4.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton4.CheckedForeColor = Color.White;
            cuiButton4.CheckedImageTint = Color.White;
            cuiButton4.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton4.Content = "Ver mas...";
            cuiButton4.DialogResult = DialogResult.None;
            cuiButton4.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton4.ForeColor = Color.Black;
            cuiButton4.HoverBackground = Color.White;
            cuiButton4.HoverForeColor = Color.Black;
            cuiButton4.HoverImageTint = Color.White;
            cuiButton4.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton4.Image = null;
            cuiButton4.ImageAutoCenter = true;
            cuiButton4.ImageExpand = new Point(0, 0);
            cuiButton4.ImageOffset = new Point(0, 0);
            cuiButton4.Location = new Point(70, 237);
            cuiButton4.Name = "cuiButton4";
            cuiButton4.NormalBackground = Color.White;
            cuiButton4.NormalForeColor = Color.Black;
            cuiButton4.NormalImageTint = Color.White;
            cuiButton4.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton4.OutlineThickness = 1F;
            cuiButton4.PressedBackground = Color.WhiteSmoke;
            cuiButton4.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton4.PressedImageTint = Color.White;
            cuiButton4.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton4.Rounding = new Padding(8);
            cuiButton4.Size = new Size(122, 41);
            cuiButton4.TabIndex = 4;
            cuiButton4.TextAlignment = StringAlignment.Center;
            cuiButton4.TextOffset = new Point(0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 220);
            label7.Name = "label7";
            label7.Size = new Size(92, 14);
            label7.TabIndex = 6;
            label7.Text = "Precio: 2500 CS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(92, 206);
            label8.Name = "label8";
            label8.Size = new Size(53, 14);
            label8.TabIndex = 5;
            label8.Text = "Mochila";
            // 
            // funcionComprar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cuiPanel3);
            Controls.Add(cuiSeparator1);
            Controls.Add(cuiPanel8);
            Margin = new Padding(3, 2, 3, 2);
            Name = "funcionComprar";
            Size = new Size(1034, 637);
            cuiPanel8.ResumeLayout(false);
            cuiPanel3.ResumeLayout(false);
            FlwProductos.ResumeLayout(false);
            pnlProducto1.ResumeLayout(false);
            pnlProducto1.PerformLayout();
            pnlProducto2.ResumeLayout(false);
            pnlProducto2.PerformLayout();
            pnlProducto3.ResumeLayout(false);
            pnlProducto3.PerformLayout();
            pnlProducto4.ResumeLayout(false);
            pnlProducto4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiComboBox CmbCategorias;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private CuoreUI.Controls.cuiTextBox tbxbuscarProducto;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private FlowLayoutPanel FlwProductos;
        private CuoreUI.Controls.cuiPanel pnlProducto1;
        private CuoreUI.Controls.cuiPanel pnlProducto2;
        private CuoreUI.Controls.cuiPanel pnlProducto3;
        private CuoreUI.Controls.cuiPanel pnlProducto4;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private Label label2;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private Label label3;
        private Label label4;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private Label label5;
        private Label label6;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private Label label7;
        private Label label8;
    }
}
