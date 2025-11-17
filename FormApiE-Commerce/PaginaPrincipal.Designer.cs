namespace FormApiE_Commerce
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnCerrar = new Button();
            btnCerrarSesion = new Button();
            btnMenu = new Button();
            tabControl1 = new TabControl();
            tabPageComprar = new TabPage();
            tabPageVender = new TabPage();
            btnRefrescar = new Button();
            panel1 = new Panel();
            btnChatBot = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(166, 29);
            label1.TabIndex = 1;
            label1.Text = "E-Commerce";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnCerrarSesion);
            flowLayoutPanel1.Location = new Point(776, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(138, 95);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCerrar);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(131, 47);
            panel2.TabIndex = 5;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point(96, 1);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(35, 41);
            btnCerrar.TabIndex = 14;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AutoSize = true;
            btnCerrarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Firebrick;
            btnCerrarSesion.Location = new Point(3, 59);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(141, 44);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImage = Properties.Resources.Menu;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.Location = new Point(857, 4);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(54, 44);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageComprar);
            tabControl1.Controls.Add(tabPageVender);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 57);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 544);
            tabControl1.TabIndex = 4;
            // 
            // tabPageComprar
            // 
            tabPageComprar.Location = new Point(4, 29);
            tabPageComprar.Margin = new Padding(3, 4, 3, 4);
            tabPageComprar.Name = "tabPageComprar";
            tabPageComprar.Padding = new Padding(3, 4, 3, 4);
            tabPageComprar.Size = new Size(922, 511);
            tabPageComprar.TabIndex = 0;
            tabPageComprar.Text = "Comprar";
            tabPageComprar.UseVisualStyleBackColor = true;
            // 
            // tabPageVender
            // 
            tabPageVender.Location = new Point(4, 29);
            tabPageVender.Margin = new Padding(3, 4, 3, 4);
            tabPageVender.Name = "tabPageVender";
            tabPageVender.Padding = new Padding(3, 4, 3, 4);
            tabPageVender.Size = new Size(922, 511);
            tabPageVender.TabIndex = 1;
            tabPageVender.Text = "Vender";
            tabPageVender.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackgroundImage = Properties.Resources.reinciar;
            btnRefrescar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefrescar.Location = new Point(166, 9);
            btnRefrescar.Margin = new Padding(3, 4, 3, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(35, 41);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChatBot);
            panel1.Controls.Add(btnRefrescar);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 601);
            panel1.TabIndex = 2;
            // 
            // btnChatBot
            // 
            btnChatBot.BackgroundImage = Properties.Resources.ImagenChatBot;
            btnChatBot.BackgroundImageLayout = ImageLayout.Stretch;
            btnChatBot.Location = new Point(688, 9);
            btnChatBot.Margin = new Padding(3, 4, 3, 4);
            btnChatBot.Name = "btnChatBot";
            btnChatBot.Size = new Size(67, 69);
            btnChatBot.TabIndex = 7;
            btnChatBot.UseVisualStyleBackColor = true;
            btnChatBot.Click += btnChatBot_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 601);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaginaPrincipal";
            Text = "PaginaPrincipal";
            Load += PaginaPrincipal_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCerrarSesion;
        private Button btnMenu;
        private TabControl tabControl1;
        private TabPage tabPageComprar;
        private TabPage tabPageVender;
        private Panel panel1;
        private Button btnCerrar;
        private Panel panel2;
        private Button btnRefrescar;
        private Button btnChatBot;
    }
}