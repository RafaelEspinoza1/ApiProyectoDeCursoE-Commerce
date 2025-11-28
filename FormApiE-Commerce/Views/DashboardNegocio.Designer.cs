namespace FormApiE_Commerce.Views
{
    partial class Analisis_Financieros
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            tabControlFinanzas = new TabControl();
            tabInfo = new TabPage();
            tabEF = new TabPage();
            tabAnalisis = new TabPage();
            cuiPanel1.SuspendLayout();
            tabControlFinanzas.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Orange;
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Dock = DockStyle.Top;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Margin = new Padding(4, 5, 4, 5);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 2F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(1486, 242);
            cuiPanel1.TabIndex = 0;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Funciones\\ Financieras";
            cuiLabel1.Font = new Font("Garamond", 28.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(16, 41);
            cuiLabel1.Margin = new Padding(5, 6, 5, 6);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(602, 68);
            cuiLabel1.TabIndex = 0;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // tabControlFinanzas
            // 
            tabControlFinanzas.Appearance = TabAppearance.Buttons;
            tabControlFinanzas.Controls.Add(tabInfo);
            tabControlFinanzas.Controls.Add(tabEF);
            tabControlFinanzas.Controls.Add(tabAnalisis);
            tabControlFinanzas.Font = new Font("Garamond", 12F, FontStyle.Bold);
            tabControlFinanzas.Location = new Point(0, 250);
            tabControlFinanzas.Name = "tabControlFinanzas";
            tabControlFinanzas.SelectedIndex = 0;
            tabControlFinanzas.Size = new Size(1486, 803);
            tabControlFinanzas.TabIndex = 3;
            // 
            // tabInfo
            // 
            tabInfo.BackColor = Color.LightSteelBlue;
            tabInfo.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabInfo.Location = new Point(4, 39);
            tabInfo.Name = "tabInfo";
            tabInfo.Size = new Size(1478, 760);
            tabInfo.TabIndex = 2;
            tabInfo.Text = "Información del Negocio";
            // 
            // tabEF
            // 
            tabEF.BackColor = Color.LightSteelBlue;
            tabEF.Font = new Font("Garamond", 12F, FontStyle.Bold);
            tabEF.Location = new Point(4, 39);
            tabEF.Name = "tabEF";
            tabEF.Padding = new Padding(3);
            tabEF.Size = new Size(1478, 760);
            tabEF.TabIndex = 0;
            tabEF.Text = "Estados Financieros";
            // 
            // tabAnalisis
            // 
            tabAnalisis.BackColor = Color.LightSteelBlue;
            tabAnalisis.Font = new Font("Garamond", 12F, FontStyle.Bold);
            tabAnalisis.Location = new Point(4, 39);
            tabAnalisis.Name = "tabAnalisis";
            tabAnalisis.Padding = new Padding(3);
            tabAnalisis.Size = new Size(1478, 760);
            tabAnalisis.TabIndex = 1;
            tabAnalisis.Text = "Análisis";
            // 
            // Analisis_Financieros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 1065);
            Controls.Add(tabControlFinanzas);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Analisis_Financieros";
            Text = "Analisis_Financieros";
            cuiPanel1.ResumeLayout(false);
            tabControlFinanzas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private TabControl tabControlFinanzas;
        private TabPage tabInfo;
        private TabPage tabEF;
        private TabPage tabAnalisis;
    }
}