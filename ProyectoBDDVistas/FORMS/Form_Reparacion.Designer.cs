namespace ProyectoBDDVistas.FORMS
{
    partial class Form_Reparacion
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
            label37 = new Label();
            DGWReparacion = new DataGridView();
            label9 = new Label();
            label20 = new Label();
            tabPage2 = new TabPage();
            label12 = new Label();
            panel7 = new Panel();
            dGWVehRepAct = new DataGridView();
            panel6 = new Panel();
            txtBNumMatVehiculoAct = new TextBox();
            label18 = new Label();
            label19 = new Label();
            txtBFecVehiculoReparacionAct = new TextBox();
            label4 = new Label();
            dGWClienteRepAct = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            bttEliminar = new Button();
            bttAct = new Button();
            dTPFecRepAct = new DateTimePicker();
            rTBObsRepAct = new RichTextBox();
            label7 = new Label();
            cBTipoRepaAct = new ComboBox();
            txtBidRepAct = new TextBox();
            label8 = new Label();
            label2 = new Label();
            txtBPreRepAct = new TextBox();
            label10 = new Label();
            label11 = new Label();
            panel5 = new Panel();
            txtBDirClienteReparacionAct = new TextBox();
            txtBCedClienteReparacionAct = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtBApeClienteReparacionAct = new TextBox();
            label15 = new Label();
            label16 = new Label();
            txtBNomClienteReparacionAct = new TextBox();
            label17 = new Label();
            tabPage1 = new TabPage();
            panel10 = new Panel();
            dGWVehiculoRegistrar = new DataGridView();
            label3 = new Label();
            panel2 = new Panel();
            txtBNumMatRepRegistro = new TextBox();
            label32 = new Label();
            label33 = new Label();
            txtBFecVehRepRegistrar = new TextBox();
            dGWClienteRegistro = new DataGridView();
            label34 = new Label();
            label30 = new Label();
            panel4 = new Panel();
            bttAgregarRegistrar = new Button();
            dTPFecRepRegistrar = new DateTimePicker();
            rTBObseRepRegistrar = new RichTextBox();
            label41 = new Label();
            cBTipoRepRegistrar = new ComboBox();
            txtidRepRegistrar = new TextBox();
            label1 = new Label();
            label38 = new Label();
            txtPreRepRegistrar = new TextBox();
            label39 = new Label();
            label40 = new Label();
            panel1 = new Panel();
            txtBDirClienteReparacionRegistro = new TextBox();
            txtBCedClienteReparacionRegistro = new TextBox();
            label28 = new Label();
            label23 = new Label();
            txtBApeClienteReparacionRegistro = new TextBox();
            label24 = new Label();
            label26 = new Label();
            txtBnomClienteReparacionRegistro = new TextBox();
            label29 = new Label();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)DGWReparacion).BeginInit();
            tabPage2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGWVehRepAct).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGWClienteRepAct).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tabPage1.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGWVehiculoRegistrar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGWClienteRegistro).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label37.Location = new Point(-269, -14);
            label37.Name = "label37";
            label37.Size = new Size(104, 20);
            label37.TabIndex = 73;
            label37.Text = "REPARACION";
            // 
            // DGWReparacion
            // 
            DGWReparacion.AllowUserToAddRows = false;
            DGWReparacion.AllowUserToDeleteRows = false;
            DGWReparacion.AllowUserToResizeColumns = false;
            DGWReparacion.AllowUserToResizeRows = false;
            DGWReparacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGWReparacion.BackgroundColor = Color.White;
            DGWReparacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWReparacion.Location = new Point(12, 591);
            DGWReparacion.Margin = new Padding(3, 4, 3, 4);
            DGWReparacion.MultiSelect = false;
            DGWReparacion.Name = "DGWReparacion";
            DGWReparacion.ReadOnly = true;
            DGWReparacion.RowHeadersVisible = false;
            DGWReparacion.RowHeadersWidth = 51;
            DGWReparacion.RowTemplate.Height = 24;
            DGWReparacion.Size = new Size(1641, 329);
            DGWReparacion.TabIndex = 72;
            DGWReparacion.CellClick += DGWReparacion_CellClick;
            DGWReparacion.DataBindingComplete += DGWReparacion_DataBindingComplete;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(1672, 40);
            label9.TabIndex = 75;
            label9.Text = "REPARACIÓN";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 567);
            label20.Name = "label20";
            label20.Size = new Size(374, 20);
            label20.TabIndex = 119;
            label20.Text = "Seleccione en la tabla para poder actualizar o eliminar:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(dGWClienteRepAct);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(label17);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1633, 478);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Actualizar reparación";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(690, 42);
            label12.Name = "label12";
            label12.Size = new Size(135, 20);
            label12.TabIndex = 122;
            label12.Text = "Datos del vehiculo:";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dGWVehRepAct);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(label4);
            panel7.Enabled = false;
            panel7.Location = new Point(690, 62);
            panel7.Name = "panel7";
            panel7.Size = new Size(470, 319);
            panel7.TabIndex = 132;
            // 
            // dGWVehRepAct
            // 
            dGWVehRepAct.AllowUserToAddRows = false;
            dGWVehRepAct.AllowUserToDeleteRows = false;
            dGWVehRepAct.AllowUserToResizeColumns = false;
            dGWVehRepAct.AllowUserToResizeRows = false;
            dGWVehRepAct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWVehRepAct.Location = new Point(4, 168);
            dGWVehRepAct.MultiSelect = false;
            dGWVehRepAct.Name = "dGWVehRepAct";
            dGWVehRepAct.ReadOnly = true;
            dGWVehRepAct.RowHeadersWidth = 51;
            dGWVehRepAct.Size = new Size(462, 122);
            dGWVehRepAct.TabIndex = 131;
            dGWVehRepAct.CellClick += dGWVehRepAct_CellClick;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtBNumMatVehiculoAct);
            panel6.Controls.Add(label18);
            panel6.Controls.Add(label19);
            panel6.Controls.Add(txtBFecVehiculoReparacionAct);
            panel6.Location = new Point(3, 22);
            panel6.Name = "panel6";
            panel6.Size = new Size(463, 103);
            panel6.TabIndex = 123;
            // 
            // txtBNumMatVehiculoAct
            // 
            txtBNumMatVehiculoAct.Location = new Point(156, 17);
            txtBNumMatVehiculoAct.Margin = new Padding(3, 4, 3, 4);
            txtBNumMatVehiculoAct.Name = "txtBNumMatVehiculoAct";
            txtBNumMatVehiculoAct.ReadOnly = true;
            txtBNumMatVehiculoAct.Size = new Size(190, 27);
            txtBNumMatVehiculoAct.TabIndex = 105;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 24);
            label18.Name = "label18";
            label18.Size = new Size(132, 20);
            label18.TabIndex = 101;
            label18.Text = "Numero Matricula:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(45, 59);
            label19.Name = "label19";
            label19.Size = new Size(105, 20);
            label19.TabIndex = 103;
            label19.Text = "Fecha compra:";
            // 
            // txtBFecVehiculoReparacionAct
            // 
            txtBFecVehiculoReparacionAct.Location = new Point(156, 56);
            txtBFecVehiculoReparacionAct.Margin = new Padding(3, 4, 3, 4);
            txtBFecVehiculoReparacionAct.Name = "txtBFecVehiculoReparacionAct";
            txtBFecVehiculoReparacionAct.ReadOnly = true;
            txtBFecVehiculoReparacionAct.Size = new Size(190, 27);
            txtBFecVehiculoReparacionAct.TabIndex = 104;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 143);
            label4.Name = "label4";
            label4.Size = new Size(298, 20);
            label4.TabIndex = 129;
            label4.Text = "Seleccione el vehiculo para esta reparación:";
            // 
            // dGWClienteRepAct
            // 
            dGWClienteRepAct.AllowUserToAddRows = false;
            dGWClienteRepAct.AllowUserToDeleteRows = false;
            dGWClienteRepAct.AllowUserToResizeColumns = false;
            dGWClienteRepAct.AllowUserToResizeRows = false;
            dGWClienteRepAct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWClienteRepAct.Location = new Point(17, 307);
            dGWClienteRepAct.MultiSelect = false;
            dGWClienteRepAct.Name = "dGWClienteRepAct";
            dGWClienteRepAct.ReadOnly = true;
            dGWClienteRepAct.RowHeadersVisible = false;
            dGWClienteRepAct.RowHeadersWidth = 51;
            dGWClienteRepAct.Size = new Size(660, 165);
            dGWClienteRepAct.TabIndex = 130;
            dGWClienteRepAct.CellClick += dGWClienteRepAct_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 269);
            label5.Name = "label5";
            label5.Size = new Size(287, 20);
            label5.TabIndex = 128;
            label5.Text = "Seleccione al cliente para esta reparacion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1175, 42);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 124;
            label6.Text = "Registrar reparaciones:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(bttEliminar);
            panel3.Controls.Add(bttAct);
            panel3.Controls.Add(dTPFecRepAct);
            panel3.Controls.Add(rTBObsRepAct);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cBTipoRepaAct);
            panel3.Controls.Add(txtBidRepAct);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtBPreRepAct);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(1172, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(455, 385);
            panel3.TabIndex = 125;
            // 
            // bttEliminar
            // 
            bttEliminar.Location = new Point(285, 341);
            bttEliminar.Name = "bttEliminar";
            bttEliminar.Size = new Size(94, 29);
            bttEliminar.TabIndex = 114;
            bttEliminar.Text = "Eliminar";
            bttEliminar.UseVisualStyleBackColor = true;
            bttEliminar.Click += bttEliminar_Click;
            // 
            // bttAct
            // 
            bttAct.Location = new Point(84, 341);
            bttAct.Name = "bttAct";
            bttAct.Size = new Size(94, 29);
            bttAct.TabIndex = 113;
            bttAct.Text = "Actualizar";
            bttAct.UseVisualStyleBackColor = true;
            bttAct.Click += bttAct_Click;
            // 
            // dTPFecRepAct
            // 
            dTPFecRepAct.Location = new Point(133, 98);
            dTPFecRepAct.Name = "dTPFecRepAct";
            dTPFecRepAct.Size = new Size(290, 27);
            dTPFecRepAct.TabIndex = 112;
            // 
            // rTBObsRepAct
            // 
            rTBObsRepAct.Location = new Point(138, 191);
            rTBObsRepAct.Name = "rTBObsRepAct";
            rTBObsRepAct.Size = new Size(285, 127);
            rTBObsRepAct.TabIndex = 111;
            rTBObsRepAct.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 146);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 110;
            label7.Text = "Precio:";
            // 
            // cBTipoRepaAct
            // 
            cBTipoRepaAct.FormattingEnabled = true;
            cBTipoRepaAct.Items.AddRange(new object[] { "Batería", "Llantas", "Balanceo", "Mantenim.", "CorreaDist", "Aceite", "Amortig.", "Radiador", "Frenos", "Suspensión", "Escape", "Detallado" });
            cBTipoRepaAct.Location = new Point(133, 59);
            cBTipoRepaAct.Name = "cBTipoRepaAct";
            cBTipoRepaAct.Size = new Size(213, 28);
            cBTipoRepaAct.TabIndex = 109;
            // 
            // txtBidRepAct
            // 
            txtBidRepAct.Location = new Point(133, 21);
            txtBidRepAct.Margin = new Padding(3, 4, 3, 4);
            txtBidRepAct.Name = "txtBidRepAct";
            txtBidRepAct.ReadOnly = true;
            txtBidRepAct.Size = new Size(213, 27);
            txtBidRepAct.TabIndex = 102;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 191);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 107;
            label8.Text = "Observaciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 24);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 101;
            label2.Text = "Id reparación:";
            // 
            // txtBPreRepAct
            // 
            txtBPreRepAct.Location = new Point(133, 143);
            txtBPreRepAct.Margin = new Padding(3, 4, 3, 4);
            txtBPreRepAct.Name = "txtBPreRepAct";
            txtBPreRepAct.Size = new Size(133, 27);
            txtBPreRepAct.TabIndex = 106;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(84, 63);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 103;
            label10.Text = "Tipo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 103);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 105;
            label11.Text = "Fecha reparación:";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBDirClienteReparacionAct);
            panel5.Controls.Add(txtBCedClienteReparacionAct);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(txtBApeClienteReparacionAct);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(txtBNomClienteReparacionAct);
            panel5.Location = new Point(17, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(660, 185);
            panel5.TabIndex = 120;
            // 
            // txtBDirClienteReparacionAct
            // 
            txtBDirClienteReparacionAct.Location = new Point(190, 130);
            txtBDirClienteReparacionAct.Margin = new Padding(3, 4, 3, 4);
            txtBDirClienteReparacionAct.Name = "txtBDirClienteReparacionAct";
            txtBDirClienteReparacionAct.ReadOnly = true;
            txtBDirClienteReparacionAct.Size = new Size(255, 27);
            txtBDirClienteReparacionAct.TabIndex = 108;
            // 
            // txtBCedClienteReparacionAct
            // 
            txtBCedClienteReparacionAct.Location = new Point(190, 25);
            txtBCedClienteReparacionAct.Margin = new Padding(3, 4, 3, 4);
            txtBCedClienteReparacionAct.Name = "txtBCedClienteReparacionAct";
            txtBCedClienteReparacionAct.ReadOnly = true;
            txtBCedClienteReparacionAct.Size = new Size(255, 27);
            txtBCedClienteReparacionAct.TabIndex = 102;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(109, 133);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 107;
            label13.Text = "Dirección:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(126, 28);
            label14.Name = "label14";
            label14.Size = new Size(58, 20);
            label14.TabIndex = 101;
            label14.Text = "Cedula:";
            // 
            // txtBApeClienteReparacionAct
            // 
            txtBApeClienteReparacionAct.Location = new Point(190, 95);
            txtBApeClienteReparacionAct.Margin = new Padding(3, 4, 3, 4);
            txtBApeClienteReparacionAct.Name = "txtBApeClienteReparacionAct";
            txtBApeClienteReparacionAct.ReadOnly = true;
            txtBApeClienteReparacionAct.Size = new Size(255, 27);
            txtBApeClienteReparacionAct.TabIndex = 106;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(117, 63);
            label15.Name = "label15";
            label15.Size = new Size(67, 20);
            label15.TabIndex = 103;
            label15.Text = "Nombre:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(117, 98);
            label16.Name = "label16";
            label16.Size = new Size(69, 20);
            label16.TabIndex = 105;
            label16.Text = "Apellido:";
            // 
            // txtBNomClienteReparacionAct
            // 
            txtBNomClienteReparacionAct.Location = new Point(190, 60);
            txtBNomClienteReparacionAct.Margin = new Padding(3, 4, 3, 4);
            txtBNomClienteReparacionAct.Name = "txtBNomClienteReparacionAct";
            txtBNomClienteReparacionAct.ReadOnly = true;
            txtBNomClienteReparacionAct.Size = new Size(255, 27);
            txtBNomClienteReparacionAct.TabIndex = 104;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 42);
            label17.Name = "label17";
            label17.Size = new Size(124, 20);
            label17.TabIndex = 121;
            label17.Text = "Datos del cliente:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel10);
            tabPage1.Controls.Add(dGWClienteRegistro);
            tabPage1.Controls.Add(label34);
            tabPage1.Controls.Add(label30);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label29);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1633, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar reparación";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(dGWVehiculoRegistrar);
            panel10.Controls.Add(label3);
            panel10.Controls.Add(panel2);
            panel10.Enabled = false;
            panel10.Location = new Point(672, 64);
            panel10.Name = "panel10";
            panel10.Size = new Size(483, 321);
            panel10.TabIndex = 113;
            // 
            // dGWVehiculoRegistrar
            // 
            dGWVehiculoRegistrar.AllowUserToAddRows = false;
            dGWVehiculoRegistrar.AllowUserToDeleteRows = false;
            dGWVehiculoRegistrar.AllowUserToResizeColumns = false;
            dGWVehiculoRegistrar.AllowUserToResizeRows = false;
            dGWVehiculoRegistrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWVehiculoRegistrar.Location = new Point(3, 185);
            dGWVehiculoRegistrar.MultiSelect = false;
            dGWVehiculoRegistrar.Name = "dGWVehiculoRegistrar";
            dGWVehiculoRegistrar.ReadOnly = true;
            dGWVehiculoRegistrar.RowHeadersVisible = false;
            dGWVehiculoRegistrar.RowHeadersWidth = 51;
            dGWVehiculoRegistrar.Size = new Size(475, 122);
            dGWVehiculoRegistrar.TabIndex = 117;
            dGWVehiculoRegistrar.CellClick += dGWVehiculoRegistrar_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 162);
            label3.Name = "label3";
            label3.Size = new Size(298, 20);
            label3.TabIndex = 119;
            label3.Text = "Seleccione el vehiculo para esta reparación:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBNumMatRepRegistro);
            panel2.Controls.Add(label32);
            panel2.Controls.Add(label33);
            panel2.Controls.Add(txtBFecVehRepRegistrar);
            panel2.Location = new Point(3, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 103);
            panel2.TabIndex = 111;
            // 
            // txtBNumMatRepRegistro
            // 
            txtBNumMatRepRegistro.Location = new Point(156, 21);
            txtBNumMatRepRegistro.Margin = new Padding(3, 4, 3, 4);
            txtBNumMatRepRegistro.Name = "txtBNumMatRepRegistro";
            txtBNumMatRepRegistro.ReadOnly = true;
            txtBNumMatRepRegistro.Size = new Size(190, 27);
            txtBNumMatRepRegistro.TabIndex = 105;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(18, 24);
            label32.Name = "label32";
            label32.Size = new Size(132, 20);
            label32.TabIndex = 101;
            label32.Text = "Numero Matricula:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(45, 59);
            label33.Name = "label33";
            label33.Size = new Size(105, 20);
            label33.TabIndex = 103;
            label33.Text = "Fecha compra:";
            // 
            // txtBFecVehRepRegistrar
            // 
            txtBFecVehRepRegistrar.Location = new Point(156, 56);
            txtBFecVehRepRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBFecVehRepRegistrar.Name = "txtBFecVehRepRegistrar";
            txtBFecVehRepRegistrar.ReadOnly = true;
            txtBFecVehRepRegistrar.Size = new Size(190, 27);
            txtBFecVehRepRegistrar.TabIndex = 104;
            // 
            // dGWClienteRegistro
            // 
            dGWClienteRegistro.AllowUserToAddRows = false;
            dGWClienteRegistro.AllowUserToDeleteRows = false;
            dGWClienteRegistro.AllowUserToResizeColumns = false;
            dGWClienteRegistro.AllowUserToResizeRows = false;
            dGWClienteRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWClienteRegistro.Location = new Point(6, 291);
            dGWClienteRegistro.MultiSelect = false;
            dGWClienteRegistro.Name = "dGWClienteRegistro";
            dGWClienteRegistro.ReadOnly = true;
            dGWClienteRegistro.RowHeadersVisible = false;
            dGWClienteRegistro.RowHeadersWidth = 51;
            dGWClienteRegistro.Size = new Size(660, 165);
            dGWClienteRegistro.TabIndex = 116;
            dGWClienteRegistro.CellClick += dGWClienteRegistro_CellClick;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(1175, 41);
            label34.Name = "label34";
            label34.Size = new Size(160, 20);
            label34.TabIndex = 114;
            label34.Text = "Registrar reparaciones:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(672, 41);
            label30.Name = "label30";
            label30.Size = new Size(135, 20);
            label30.TabIndex = 110;
            label30.Text = "Datos del vehiculo:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(bttAgregarRegistrar);
            panel4.Controls.Add(dTPFecRepRegistrar);
            panel4.Controls.Add(rTBObseRepRegistrar);
            panel4.Controls.Add(label41);
            panel4.Controls.Add(cBTipoRepRegistrar);
            panel4.Controls.Add(txtidRepRegistrar);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label38);
            panel4.Controls.Add(txtPreRepRegistrar);
            panel4.Controls.Add(label39);
            panel4.Controls.Add(label40);
            panel4.Location = new Point(1175, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(455, 385);
            panel4.TabIndex = 115;
            // 
            // bttAgregarRegistrar
            // 
            bttAgregarRegistrar.Location = new Point(189, 341);
            bttAgregarRegistrar.Name = "bttAgregarRegistrar";
            bttAgregarRegistrar.Size = new Size(94, 29);
            bttAgregarRegistrar.TabIndex = 113;
            bttAgregarRegistrar.Text = "Agregar";
            bttAgregarRegistrar.UseVisualStyleBackColor = true;
            bttAgregarRegistrar.Click += bttAgregarRegistrar_Click;
            // 
            // dTPFecRepRegistrar
            // 
            dTPFecRepRegistrar.Location = new Point(133, 98);
            dTPFecRepRegistrar.Name = "dTPFecRepRegistrar";
            dTPFecRepRegistrar.Size = new Size(290, 27);
            dTPFecRepRegistrar.TabIndex = 112;
            // 
            // rTBObseRepRegistrar
            // 
            rTBObseRepRegistrar.Location = new Point(132, 191);
            rTBObseRepRegistrar.Name = "rTBObseRepRegistrar";
            rTBObseRepRegistrar.Size = new Size(285, 127);
            rTBObseRepRegistrar.TabIndex = 111;
            rTBObseRepRegistrar.Text = "";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(75, 146);
            label41.Name = "label41";
            label41.Size = new Size(53, 20);
            label41.TabIndex = 110;
            label41.Text = "Precio:";
            // 
            // cBTipoRepRegistrar
            // 
            cBTipoRepRegistrar.FormattingEnabled = true;
            cBTipoRepRegistrar.Items.AddRange(new object[] { "Batería   ", "Llantas   ", "Balanceo  ", "Mantenim. ", "CorreaDist", "Aceite    ", "Amortig.  ", "Radiador  ", "Frenos    ", "Suspensión", "Escape    ", "Detallado" });
            cBTipoRepRegistrar.Location = new Point(133, 59);
            cBTipoRepRegistrar.Name = "cBTipoRepRegistrar";
            cBTipoRepRegistrar.Size = new Size(213, 28);
            cBTipoRepRegistrar.TabIndex = 109;
            // 
            // txtidRepRegistrar
            // 
            txtidRepRegistrar.Location = new Point(133, 21);
            txtidRepRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtidRepRegistrar.Name = "txtidRepRegistrar";
            txtidRepRegistrar.Size = new Size(213, 27);
            txtidRepRegistrar.TabIndex = 102;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 191);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 107;
            label1.Text = "Observaciones:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(27, 24);
            label38.Name = "label38";
            label38.Size = new Size(100, 20);
            label38.TabIndex = 101;
            label38.Text = "Id reparación:";
            // 
            // txtPreRepRegistrar
            // 
            txtPreRepRegistrar.Location = new Point(133, 143);
            txtPreRepRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtPreRepRegistrar.Name = "txtPreRepRegistrar";
            txtPreRepRegistrar.Size = new Size(133, 27);
            txtPreRepRegistrar.TabIndex = 106;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(84, 63);
            label39.Name = "label39";
            label39.Size = new Size(42, 20);
            label39.TabIndex = 103;
            label39.Text = "Tipo:";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(3, 103);
            label40.Name = "label40";
            label40.Size = new Size(125, 20);
            label40.TabIndex = 105;
            label40.Text = "Fecha reparación:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBDirClienteReparacionRegistro);
            panel1.Controls.Add(txtBCedClienteReparacionRegistro);
            panel1.Controls.Add(label28);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(txtBApeClienteReparacionRegistro);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(txtBnomClienteReparacionRegistro);
            panel1.Location = new Point(6, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 185);
            panel1.TabIndex = 109;
            // 
            // txtBDirClienteReparacionRegistro
            // 
            txtBDirClienteReparacionRegistro.Location = new Point(190, 130);
            txtBDirClienteReparacionRegistro.Margin = new Padding(3, 4, 3, 4);
            txtBDirClienteReparacionRegistro.Name = "txtBDirClienteReparacionRegistro";
            txtBDirClienteReparacionRegistro.ReadOnly = true;
            txtBDirClienteReparacionRegistro.Size = new Size(255, 27);
            txtBDirClienteReparacionRegistro.TabIndex = 108;
            // 
            // txtBCedClienteReparacionRegistro
            // 
            txtBCedClienteReparacionRegistro.Location = new Point(190, 25);
            txtBCedClienteReparacionRegistro.Margin = new Padding(3, 4, 3, 4);
            txtBCedClienteReparacionRegistro.Name = "txtBCedClienteReparacionRegistro";
            txtBCedClienteReparacionRegistro.ReadOnly = true;
            txtBCedClienteReparacionRegistro.Size = new Size(255, 27);
            txtBCedClienteReparacionRegistro.TabIndex = 102;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(109, 133);
            label28.Name = "label28";
            label28.Size = new Size(75, 20);
            label28.TabIndex = 107;
            label28.Text = "Dirección:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(126, 28);
            label23.Name = "label23";
            label23.Size = new Size(58, 20);
            label23.TabIndex = 101;
            label23.Text = "Cedula:";
            // 
            // txtBApeClienteReparacionRegistro
            // 
            txtBApeClienteReparacionRegistro.Location = new Point(190, 95);
            txtBApeClienteReparacionRegistro.Margin = new Padding(3, 4, 3, 4);
            txtBApeClienteReparacionRegistro.Name = "txtBApeClienteReparacionRegistro";
            txtBApeClienteReparacionRegistro.ReadOnly = true;
            txtBApeClienteReparacionRegistro.Size = new Size(255, 27);
            txtBApeClienteReparacionRegistro.TabIndex = 106;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(117, 63);
            label24.Name = "label24";
            label24.Size = new Size(67, 20);
            label24.TabIndex = 103;
            label24.Text = "Nombre:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(117, 98);
            label26.Name = "label26";
            label26.Size = new Size(69, 20);
            label26.TabIndex = 105;
            label26.Text = "Apellido:";
            // 
            // txtBnomClienteReparacionRegistro
            // 
            txtBnomClienteReparacionRegistro.Location = new Point(190, 60);
            txtBnomClienteReparacionRegistro.Margin = new Padding(3, 4, 3, 4);
            txtBnomClienteReparacionRegistro.Name = "txtBnomClienteReparacionRegistro";
            txtBnomClienteReparacionRegistro.ReadOnly = true;
            txtBnomClienteReparacionRegistro.Size = new Size(255, 27);
            txtBnomClienteReparacionRegistro.TabIndex = 104;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(6, 41);
            label29.Name = "label29";
            label29.Size = new Size(124, 20);
            label29.TabIndex = 109;
            label29.Text = "Datos del cliente:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1641, 511);
            tabControl1.TabIndex = 87;
            // 
            // Form_Reparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1672, 933);
            Controls.Add(label20);
            Controls.Add(tabControl1);
            Controls.Add(label9);
            Controls.Add(label37);
            Controls.Add(DGWReparacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Reparacion";
            Text = "Form_Reparacion";
            ((System.ComponentModel.ISupportInitialize)DGWReparacion).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGWVehRepAct).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGWClienteRepAct).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGWVehiculoRegistrar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGWClienteRegistro).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label37;
        private DataGridView DGWReparacion;
        private Label label9;
        private Label label20;
        private TabPage tabPage2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Button bttAct;
        private DateTimePicker dTPFecRepAct;
        private RichTextBox rTBObsRepAct;
        private Label label7;
        private ComboBox cBTipoRepaAct;
        private TextBox txtBidRepAct;
        private Label label8;
        private Label label2;
        private TextBox txtBPreRepAct;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel5;
        private TextBox txtBDirClienteReparacionAct;
        private TextBox txtBCedClienteReparacionAct;
        private Label label13;
        private Label label14;
        private TextBox txtBApeClienteReparacionAct;
        private Label label15;
        private Label label16;
        private TextBox txtBNomClienteReparacionAct;
        private Label label17;
        private Panel panel6;
        private Label label18;
        private Label label19;
        private TextBox txtBFecVehiculoReparacionAct;
        private TabPage tabPage1;
        private Label label3;
        private DataGridView dGWVehiculoRegistrar;
        private DataGridView dGWClienteRegistro;
        private Label label34;
        private Panel panel4;
        private Button bttAgregarRegistrar;
        private DateTimePicker dTPFecRepRegistrar;
        private RichTextBox rTBObseRepRegistrar;
        private Label label41;
        private ComboBox cBTipoRepRegistrar;
        private TextBox txtidRepRegistrar;
        private Label label1;
        private Label label38;
        private TextBox txtPreRepRegistrar;
        private Label label39;
        private Label label40;
        private Label label30;
        private Panel panel1;
        private TextBox txtBDirClienteReparacionRegistro;
        private TextBox txtBCedClienteReparacionRegistro;
        private Label label28;
        private Label label23;
        private TextBox txtBApeClienteReparacionRegistro;
        private Label label24;
        private Label label26;
        private TextBox txtBnomClienteReparacionRegistro;
        private Label label29;
        private Panel panel2;
        private Label label32;
        private Label label33;
        private TextBox txtBFecVehRepRegistrar;
        private TabControl tabControl1;
        private Panel panel10;
        private TextBox txtBNumMatRepRegistro;
        private Button bttEliminar;
        private TextBox txtBNumMatVehiculoAct;
        private DataGridView dGWVehRepAct;
        private DataGridView dGWClienteRepAct;
        private Panel panel7;
    }
}