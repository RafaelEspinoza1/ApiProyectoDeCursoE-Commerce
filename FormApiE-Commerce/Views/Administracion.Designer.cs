
namespace FormApiE_Commerce
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            lblTitulo = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            dgvEstadoResultadoPeriodoActual = new DataGridView();
            dgvEstadoResultadoPeriodoAnterior = new DataGridView();
            tabPage2 = new TabPage();
            txtCNT = new TextBox();
            label32 = new Label();
            txtCNO = new TextBox();
            label31 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvBalanceGeneralPeriodoActual = new DataGridView();
            dgvBalanceGeneralPeriodoAnterior = new DataGridView();
            tabPage3 = new TabPage();
            dgvEOA = new DataGridView();
            lblIngresosECommece = new Label();
            tabPage4 = new TabPage();
            txtROE = new TextBox();
            label15 = new Label();
            txtROA = new TextBox();
            label20 = new Label();
            txtMN = new TextBox();
            label21 = new Label();
            txtMO = new TextBox();
            label22 = new Label();
            txtMB = new TextBox();
            label23 = new Label();
            label13 = new Label();
            txtRotacionInteresesAUtilidades = new TextBox();
            label16 = new Label();
            txtDeudaCapital = new TextBox();
            label17 = new Label();
            txtDeudaTotalSobreActivos = new TextBox();
            label18 = new Label();
            label19 = new Label();
            txtActivosTotales = new TextBox();
            label14 = new Label();
            txtRotacionActivosFijos = new TextBox();
            label11 = new Label();
            txtPeriodoCobro = new TextBox();
            label12 = new Label();
            txtRotacionCxC = new TextBox();
            label9 = new Label();
            txtRotacionInventarios = new TextBox();
            label10 = new Label();
            label8 = new Label();
            txtPruebaAcida = new TextBox();
            label7 = new Label();
            txtRazonCorriente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tabPage5 = new TabPage();
            txtDupontROE = new TextBox();
            label24 = new Label();
            txtDupontApalFinan = new TextBox();
            label25 = new Label();
            txtDupontRotacionActivos = new TextBox();
            label26 = new Label();
            txtDupontMN = new TextBox();
            label27 = new Label();
            label28 = new Label();
            tabPage6 = new TabPage();
            label30 = new Label();
            label29 = new Label();
            dgvFlujoEMIndirecto = new DataGridView();
            dgvFlujoEMDirecto = new DataGridView();
            tabPage7 = new TabPage();
            progressBarCarga = new ProgressBar();
            btnImportar = new CuoreUI.Controls.cuiButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoResultadoPeriodoActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoResultadoPeriodoAnterior).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBalanceGeneralPeriodoActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalanceGeneralPeriodoAnterior).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEOA).BeginInit();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlujoEMIndirecto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlujoEMDirecto).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(101, 23);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "E-Commerce";
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Garamond", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 38);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1018, 568);
            tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvEstadoResultadoPeriodoActual);
            tabPage1.Controls.Add(dgvEstadoResultadoPeriodoAnterior);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1010, 538);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Estado de resultado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(683, 21);
            label2.Name = "label2";
            label2.Size = new Size(181, 14);
            label2.TabIndex = 3;
            label2.Text = "Estado resultado periodo actual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 21);
            label1.Name = "label1";
            label1.Size = new Size(192, 14);
            label1.TabIndex = 2;
            label1.Text = "Estado resultado periodo anterior";
            // 
            // dgvEstadoResultadoPeriodoActual
            // 
            dgvEstadoResultadoPeriodoActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadoResultadoPeriodoActual.Location = new Point(551, 42);
            dgvEstadoResultadoPeriodoActual.Name = "dgvEstadoResultadoPeriodoActual";
            dgvEstadoResultadoPeriodoActual.Size = new Size(436, 186);
            dgvEstadoResultadoPeriodoActual.TabIndex = 1;
            // 
            // dgvEstadoResultadoPeriodoAnterior
            // 
            dgvEstadoResultadoPeriodoAnterior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadoResultadoPeriodoAnterior.Location = new Point(30, 42);
            dgvEstadoResultadoPeriodoAnterior.Name = "dgvEstadoResultadoPeriodoAnterior";
            dgvEstadoResultadoPeriodoAnterior.Size = new Size(445, 186);
            dgvEstadoResultadoPeriodoAnterior.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtCNT);
            tabPage2.Controls.Add(label32);
            tabPage2.Controls.Add(txtCNO);
            tabPage2.Controls.Add(label31);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dgvBalanceGeneralPeriodoActual);
            tabPage2.Controls.Add(dgvBalanceGeneralPeriodoAnterior);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1010, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Balance General";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCNT
            // 
            txtCNT.Location = new Point(115, 420);
            txtCNT.Name = "txtCNT";
            txtCNT.ReadOnly = true;
            txtCNT.Size = new Size(100, 22);
            txtCNT.TabIndex = 9;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(32, 427);
            label32.Name = "label32";
            label32.Size = new Size(39, 14);
            label32.TabIndex = 8;
            label32.Text = "CNT:";
            // 
            // txtCNO
            // 
            txtCNO.Location = new Point(115, 378);
            txtCNO.Name = "txtCNO";
            txtCNO.ReadOnly = true;
            txtCNO.Size = new Size(100, 22);
            txtCNO.TabIndex = 7;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(32, 385);
            label31.Name = "label31";
            label31.Size = new Size(40, 14);
            label31.TabIndex = 6;
            label31.Text = "CNO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(649, 33);
            label4.Name = "label4";
            label4.Size = new Size(179, 14);
            label4.TabIndex = 5;
            label4.Text = "Balance General periodo actual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 33);
            label3.Name = "label3";
            label3.Size = new Size(190, 14);
            label3.TabIndex = 4;
            label3.Text = "Balance General periodo anterior";
            // 
            // dgvBalanceGeneralPeriodoActual
            // 
            dgvBalanceGeneralPeriodoActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalanceGeneralPeriodoActual.Location = new Point(532, 54);
            dgvBalanceGeneralPeriodoActual.Name = "dgvBalanceGeneralPeriodoActual";
            dgvBalanceGeneralPeriodoActual.Size = new Size(436, 293);
            dgvBalanceGeneralPeriodoActual.TabIndex = 3;
            // 
            // dgvBalanceGeneralPeriodoAnterior
            // 
            dgvBalanceGeneralPeriodoAnterior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalanceGeneralPeriodoAnterior.Location = new Point(32, 54);
            dgvBalanceGeneralPeriodoAnterior.Name = "dgvBalanceGeneralPeriodoAnterior";
            dgvBalanceGeneralPeriodoAnterior.Size = new Size(445, 293);
            dgvBalanceGeneralPeriodoAnterior.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvEOA);
            tabPage3.Controls.Add(lblIngresosECommece);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1010, 538);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Estado de origen y aplicacion";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvEOA
            // 
            dgvEOA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEOA.Location = new Point(254, 23);
            dgvEOA.Name = "dgvEOA";
            dgvEOA.Size = new Size(513, 261);
            dgvEOA.TabIndex = 34;
            // 
            // lblIngresosECommece
            // 
            lblIngresosECommece.AutoSize = true;
            lblIngresosECommece.Location = new Point(8, 415);
            lblIngresosECommece.Name = "lblIngresosECommece";
            lblIngresosECommece.Size = new Size(0, 14);
            lblIngresosECommece.TabIndex = 32;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtROE);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(txtROA);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(txtMN);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(txtMO);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(txtMB);
            tabPage4.Controls.Add(label23);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(txtRotacionInteresesAUtilidades);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(txtDeudaCapital);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(txtDeudaTotalSobreActivos);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(txtActivosTotales);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(txtRotacionActivosFijos);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(txtPeriodoCobro);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(txtRotacionCxC);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(txtRotacionInventarios);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(txtPruebaAcida);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(txtRazonCorriente);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1010, 538);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Razones financieras";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtROE
            // 
            txtROE.Location = new Point(249, 358);
            txtROE.Name = "txtROE";
            txtROE.ReadOnly = true;
            txtROE.Size = new Size(115, 22);
            txtROE.TabIndex = 34;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 365);
            label15.Name = "label15";
            label15.Size = new Size(38, 14);
            label15.TabIndex = 33;
            label15.Text = "ROE:";
            // 
            // txtROA
            // 
            txtROA.Location = new Point(249, 325);
            txtROA.Name = "txtROA";
            txtROA.ReadOnly = true;
            txtROA.Size = new Size(115, 22);
            txtROA.TabIndex = 32;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(29, 335);
            label20.Name = "label20";
            label20.Size = new Size(38, 14);
            label20.TabIndex = 31;
            label20.Text = "ROA:";
            // 
            // txtMN
            // 
            txtMN.Location = new Point(249, 294);
            txtMN.Name = "txtMN";
            txtMN.ReadOnly = true;
            txtMN.Size = new Size(115, 22);
            txtMN.TabIndex = 30;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(29, 301);
            label21.Name = "label21";
            label21.Size = new Size(81, 14);
            label21.TabIndex = 29;
            label21.Text = "MargenNeto:";
            // 
            // txtMO
            // 
            txtMO.Location = new Point(245, 262);
            txtMO.Name = "txtMO";
            txtMO.ReadOnly = true;
            txtMO.Size = new Size(115, 22);
            txtMO.TabIndex = 28;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(25, 272);
            label22.Name = "label22";
            label22.Size = new Size(108, 14);
            label22.TabIndex = 27;
            label22.Text = "MargenOperativo:";
            // 
            // txtMB
            // 
            txtMB.Location = new Point(245, 231);
            txtMB.Name = "txtMB";
            txtMB.ReadOnly = true;
            txtMB.Size = new Size(115, 22);
            txtMB.TabIndex = 26;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(25, 238);
            label23.Name = "label23";
            label23.Size = new Size(85, 14);
            label23.TabIndex = 25;
            label23.Text = "MargenBruto:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 210);
            label13.Name = "label13";
            label13.Size = new Size(139, 14);
            label13.TabIndex = 24;
            label13.Text = "Razones de rentabilidad";
            // 
            // txtRotacionInteresesAUtilidades
            // 
            txtRotacionInteresesAUtilidades.Location = new Point(888, 95);
            txtRotacionInteresesAUtilidades.Name = "txtRotacionInteresesAUtilidades";
            txtRotacionInteresesAUtilidades.ReadOnly = true;
            txtRotacionInteresesAUtilidades.Size = new Size(115, 22);
            txtRotacionInteresesAUtilidades.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(668, 102);
            label16.Name = "label16";
            label16.Size = new Size(175, 14);
            label16.TabIndex = 22;
            label16.Text = "RotacionInteresesAUtilidades:";
            // 
            // txtDeudaCapital
            // 
            txtDeudaCapital.Location = new Point(884, 63);
            txtDeudaCapital.Name = "txtDeudaCapital";
            txtDeudaCapital.ReadOnly = true;
            txtDeudaCapital.Size = new Size(115, 22);
            txtDeudaCapital.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(664, 73);
            label17.Name = "label17";
            label17.Size = new Size(86, 14);
            label17.TabIndex = 20;
            label17.Text = "DeudaCapital:";
            // 
            // txtDeudaTotalSobreActivos
            // 
            txtDeudaTotalSobreActivos.Location = new Point(884, 32);
            txtDeudaTotalSobreActivos.Name = "txtDeudaTotalSobreActivos";
            txtDeudaTotalSobreActivos.ReadOnly = true;
            txtDeudaTotalSobreActivos.Size = new Size(115, 22);
            txtDeudaTotalSobreActivos.TabIndex = 19;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(664, 39);
            label18.Name = "label18";
            label18.Size = new Size(149, 14);
            label18.TabIndex = 18;
            label18.Text = "DeudaTotalSobreActivos:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(664, 15);
            label19.Name = "label19";
            label19.Size = new Size(157, 14);
            label19.TabIndex = 17;
            label19.Text = "Razones de endeudamiento";
            // 
            // txtActivosTotales
            // 
            txtActivosTotales.Location = new Point(528, 159);
            txtActivosTotales.Name = "txtActivosTotales";
            txtActivosTotales.ReadOnly = true;
            txtActivosTotales.Size = new Size(115, 22);
            txtActivosTotales.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(308, 166);
            label14.Name = "label14";
            label14.Size = new Size(142, 14);
            label14.TabIndex = 15;
            label14.Text = "RotacionActivosTotales:";
            // 
            // txtRotacionActivosFijos
            // 
            txtRotacionActivosFijos.Location = new Point(528, 126);
            txtRotacionActivosFijos.Name = "txtRotacionActivosFijos";
            txtRotacionActivosFijos.ReadOnly = true;
            txtRotacionActivosFijos.Size = new Size(115, 22);
            txtRotacionActivosFijos.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(308, 136);
            label11.Name = "label11";
            label11.Size = new Size(129, 14);
            label11.TabIndex = 13;
            label11.Text = "RotacionActivosFijos:";
            // 
            // txtPeriodoCobro
            // 
            txtPeriodoCobro.Location = new Point(528, 95);
            txtPeriodoCobro.Name = "txtPeriodoCobro";
            txtPeriodoCobro.ReadOnly = true;
            txtPeriodoCobro.Size = new Size(115, 22);
            txtPeriodoCobro.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(308, 102);
            label12.Name = "label12";
            label12.Size = new Size(144, 14);
            label12.TabIndex = 11;
            label12.Text = "PeriodoPromedioCobro:";
            // 
            // txtRotacionCxC
            // 
            txtRotacionCxC.Location = new Point(524, 63);
            txtRotacionCxC.Name = "txtRotacionCxC";
            txtRotacionCxC.ReadOnly = true;
            txtRotacionCxC.Size = new Size(115, 22);
            txtRotacionCxC.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 73);
            label9.Name = "label9";
            label9.Size = new Size(163, 14);
            label9.TabIndex = 9;
            label9.Text = "RotacionCuentasPorCobrar:";
            // 
            // txtRotacionInventarios
            // 
            txtRotacionInventarios.Location = new Point(524, 32);
            txtRotacionInventarios.Name = "txtRotacionInventarios";
            txtRotacionInventarios.ReadOnly = true;
            txtRotacionInventarios.Size = new Size(115, 22);
            txtRotacionInventarios.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(304, 39);
            label10.Name = "label10";
            label10.Size = new Size(122, 14);
            label10.TabIndex = 7;
            label10.Text = "RotacionInventarios:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 15);
            label8.Name = "label8";
            label8.Size = new Size(122, 14);
            label8.TabIndex = 5;
            label8.Text = "Razones de actividad";
            // 
            // txtPruebaAcida
            // 
            txtPruebaAcida.Location = new Point(162, 73);
            txtPruebaAcida.Name = "txtPruebaAcida";
            txtPruebaAcida.ReadOnly = true;
            txtPruebaAcida.Size = new Size(115, 22);
            txtPruebaAcida.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 77);
            label7.Name = "label7";
            label7.Size = new Size(81, 14);
            label7.TabIndex = 3;
            label7.Text = "PruebaAcida:";
            // 
            // txtRazonCorriente
            // 
            txtRazonCorriente.Location = new Point(162, 39);
            txtRazonCorriente.Name = "txtRazonCorriente";
            txtRazonCorriente.ReadOnly = true;
            txtRazonCorriente.Size = new Size(115, 22);
            txtRazonCorriente.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 43);
            label6.Name = "label6";
            label6.Size = new Size(98, 14);
            label6.TabIndex = 1;
            label6.Text = "RazonCorriente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 15);
            label5.Name = "label5";
            label5.Size = new Size(117, 14);
            label5.TabIndex = 0;
            label5.Text = "Razones de liquidez";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(txtDupontROE);
            tabPage5.Controls.Add(label24);
            tabPage5.Controls.Add(txtDupontApalFinan);
            tabPage5.Controls.Add(label25);
            tabPage5.Controls.Add(txtDupontRotacionActivos);
            tabPage5.Controls.Add(label26);
            tabPage5.Controls.Add(txtDupontMN);
            tabPage5.Controls.Add(label27);
            tabPage5.Controls.Add(label28);
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1010, 538);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Sistema Dupont";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtDupontROE
            // 
            txtDupontROE.Location = new Point(320, 151);
            txtDupontROE.Name = "txtDupontROE";
            txtDupontROE.ReadOnly = true;
            txtDupontROE.Size = new Size(115, 22);
            txtDupontROE.TabIndex = 52;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(50, 161);
            label24.Name = "label24";
            label24.Size = new Size(88, 14);
            label24.TabIndex = 51;
            label24.Text = "DuPont_ROE:";
            // 
            // txtDupontApalFinan
            // 
            txtDupontApalFinan.Location = new Point(320, 119);
            txtDupontApalFinan.Name = "txtDupontApalFinan";
            txtDupontApalFinan.ReadOnly = true;
            txtDupontApalFinan.Size = new Size(115, 22);
            txtDupontApalFinan.TabIndex = 50;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(50, 127);
            label25.Name = "label25";
            label25.Size = new Size(210, 14);
            label25.TabIndex = 49;
            label25.Text = "DuPont_ApalancamientoFinanciero:";
            // 
            // txtDupontRotacionActivos
            // 
            txtDupontRotacionActivos.Location = new Point(316, 88);
            txtDupontRotacionActivos.Name = "txtDupontRotacionActivos";
            txtDupontRotacionActivos.ReadOnly = true;
            txtDupontRotacionActivos.Size = new Size(115, 22);
            txtDupontRotacionActivos.TabIndex = 48;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(46, 98);
            label26.Name = "label26";
            label26.Size = new Size(151, 14);
            label26.TabIndex = 47;
            label26.Text = "DuPont_RotacionActivos:";
            // 
            // txtDupontMN
            // 
            txtDupontMN.Location = new Point(316, 57);
            txtDupontMN.Name = "txtDupontMN";
            txtDupontMN.ReadOnly = true;
            txtDupontMN.Size = new Size(115, 22);
            txtDupontMN.TabIndex = 46;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(46, 64);
            label27.Name = "label27";
            label27.Size = new Size(131, 14);
            label27.TabIndex = 45;
            label27.Text = "DuPont_MargenNeto:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(46, 36);
            label28.Name = "label28";
            label28.Size = new Size(96, 14);
            label28.TabIndex = 44;
            label28.Text = "Sistema DuPont";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label30);
            tabPage6.Controls.Add(label29);
            tabPage6.Controls.Add(dgvFlujoEMIndirecto);
            tabPage6.Controls.Add(dgvFlujoEMDirecto);
            tabPage6.Location = new Point(4, 26);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1010, 538);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Estados de flujo de efectivo";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(650, 23);
            label30.Name = "label30";
            label30.Size = new Size(197, 14);
            label30.TabIndex = 5;
            label30.Text = "Flujo de efectivo metodo indirecto";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(142, 23);
            label29.Name = "label29";
            label29.Size = new Size(186, 14);
            label29.TabIndex = 4;
            label29.Text = "Flujo de efectivo metodo directo";
            // 
            // dgvFlujoEMIndirecto
            // 
            dgvFlujoEMIndirecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlujoEMIndirecto.Location = new Point(545, 44);
            dgvFlujoEMIndirecto.Name = "dgvFlujoEMIndirecto";
            dgvFlujoEMIndirecto.Size = new Size(436, 150);
            dgvFlujoEMIndirecto.TabIndex = 3;
            // 
            // dgvFlujoEMDirecto
            // 
            dgvFlujoEMDirecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlujoEMDirecto.Location = new Point(35, 44);
            dgvFlujoEMDirecto.Name = "dgvFlujoEMDirecto";
            dgvFlujoEMDirecto.Size = new Size(445, 150);
            dgvFlujoEMDirecto.TabIndex = 2;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 26);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1010, 538);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Estados proforma";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // progressBarCarga
            // 
            progressBarCarga.Location = new Point(119, 9);
            progressBarCarga.MarqueeAnimationSpeed = 30;
            progressBarCarga.Name = "progressBarCarga";
            progressBarCarga.Size = new Size(100, 23);
            progressBarCarga.Style = ProgressBarStyle.Marquee;
            progressBarCarga.TabIndex = 33;
            progressBarCarga.Visible = false;
            // 
            // btnImportar
            // 
            btnImportar.CheckButton = false;
            btnImportar.Checked = false;
            btnImportar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnImportar.CheckedForeColor = Color.White;
            btnImportar.CheckedImageTint = Color.White;
            btnImportar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnImportar.Content = "Importar";
            btnImportar.DialogResult = DialogResult.None;
            btnImportar.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportar.ForeColor = Color.Black;
            btnImportar.HoverBackground = Color.White;
            btnImportar.HoverForeColor = Color.Black;
            btnImportar.HoverImageTint = Color.White;
            btnImportar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnImportar.Image = null;
            btnImportar.ImageAutoCenter = true;
            btnImportar.ImageExpand = new Point(0, 0);
            btnImportar.ImageOffset = new Point(0, 0);
            btnImportar.Location = new Point(900, 1);
            btnImportar.Name = "btnImportar";
            btnImportar.NormalBackground = Color.White;
            btnImportar.NormalForeColor = Color.Black;
            btnImportar.NormalImageTint = Color.White;
            btnImportar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnImportar.OutlineThickness = 1F;
            btnImportar.PressedBackground = Color.WhiteSmoke;
            btnImportar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnImportar.PressedImageTint = Color.White;
            btnImportar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnImportar.Rounding = new Padding(8);
            btnImportar.Size = new Size(106, 31);
            btnImportar.TabIndex = 34;
            btnImportar.TextAlignment = StringAlignment.Center;
            btnImportar.TextOffset = new Point(0, 0);
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 606);
            Controls.Add(btnImportar);
            Controls.Add(progressBarCarga);
            Controls.Add(tabControl1);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Administracion";
            Text = "Administrador";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoResultadoPeriodoActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoResultadoPeriodoAnterior).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBalanceGeneralPeriodoActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalanceGeneralPeriodoAnterior).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEOA).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlujoEMIndirecto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlujoEMDirecto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblIngresosECommece;
        private ProgressBar progressBarCarga;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView dgvEstadoResultadoPeriodoActual;
        private DataGridView dgvEstadoResultadoPeriodoAnterior;
        private DataGridView dgvBalanceGeneralPeriodoActual;
        private DataGridView dgvBalanceGeneralPeriodoAnterior;
        private DataGridView dgvEOA;
        private DataGridView dgvFlujoEMIndirecto;
        private DataGridView dgvFlujoEMDirecto;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRotacionCxC;
        private Label label9;
        private TextBox txtRotacionInventarios;
        private Label label10;
        private Label label8;
        private TextBox txtPruebaAcida;
        private Label label7;
        private TextBox txtRazonCorriente;
        private Label label6;
        private TextBox txtRotacionActivosFijos;
        private Label label11;
        private TextBox txtPeriodoCobro;
        private Label label12;
        private TextBox txtROE;
        private Label label15;
        private TextBox txtROA;
        private Label label20;
        private TextBox txtMN;
        private Label label21;
        private TextBox txtMO;
        private Label label22;
        private TextBox txtMB;
        private Label label23;
        private Label label13;
        private TextBox txtRotacionInteresesAUtilidades;
        private Label label16;
        private TextBox txtDeudaCapital;
        private Label label17;
        private TextBox txtDeudaTotalSobreActivos;
        private Label label18;
        private Label label19;
        private TextBox txtActivosTotales;
        private Label label14;
        private TextBox txtDupontROE;
        private Label label24;
        private TextBox txtDupontApalFinan;
        private Label label25;
        private TextBox txtDupontRotacionActivos;
        private Label label26;
        private TextBox txtDupontMN;
        private Label label27;
        private Label label28;
        private Label label30;
        private Label label29;
        private TextBox txtCNT;
        private Label label32;
        private TextBox txtCNO;
        private Label label31;
        private TabPage tabPage7;
        private CuoreUI.Controls.cuiButton btnImportar;
    }
}