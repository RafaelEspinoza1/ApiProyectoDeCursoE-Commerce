namespace FormApiE_Commerce
{
    partial class FormVendedorRegistrado
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
            tabControl1 = new TabControl();
            tabPageMisProductos = new TabPage();
            tabPageVender = new TabPage();
            flpProductos = new FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabPageMisProductos.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPageMisProductos);
            tabControl1.Controls.Add(tabPageVender);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1301, 338);
            tabControl1.TabIndex = 0;
            // 
            // tabPageMisProductos
            // 
            tabPageMisProductos.Controls.Add(flpProductos);
            tabPageMisProductos.Location = new Point(27, 4);
            tabPageMisProductos.Name = "tabPageMisProductos";
            tabPageMisProductos.Padding = new Padding(3);
            tabPageMisProductos.Size = new Size(1270, 330);
            tabPageMisProductos.TabIndex = 0;
            tabPageMisProductos.Text = "Mis productos";
            tabPageMisProductos.UseVisualStyleBackColor = true;
            // 
            // tabPageVender
            // 
            tabPageVender.Location = new Point(27, 4);
            tabPageVender.Name = "tabPageVender";
            tabPageVender.Padding = new Padding(3);
            tabPageVender.Size = new Size(1270, 330);
            tabPageVender.TabIndex = 1;
            tabPageVender.Text = "Vender";
            tabPageVender.UseVisualStyleBackColor = true;
            // 
            // flpProductos
            // 
            flpProductos.AutoScroll = true;
            flpProductos.Dock = DockStyle.Fill;
            flpProductos.Location = new Point(3, 3);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(1264, 324);
            flpProductos.TabIndex = 0;
            // 
            // FormVendedorRegistrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVendedorRegistrado";
            Size = new Size(1301, 338);
            tabControl1.ResumeLayout(false);
            tabPageMisProductos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageMisProductos;
        private TabPage tabPageVender;
        private FlowLayoutPanel flpProductos;
    }
}