namespace ProyectoBDDVistas.FORMS
{
    partial class Form_Vehiculo
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
            DGWVEHICULO = new DataGridView();
            label19 = new Label();
            DGWClientes = new DataGridView();
            label7 = new Label();
            label20 = new Label();
            eliminarTabPage = new TabPage();
            txtdTPFechaCompraVehiculoE = new TextBox();
            label10 = new Label();
            txtBNMatriculaVehiculoE = new TextBox();
            txtBNombreVehiculoE = new TextBox();
            txtBApellidoVehiculoE = new TextBox();
            label12 = new Label();
            label15 = new Label();
            label17 = new Label();
            BEliminarVehiculo = new Button();
            actualizarTabPage = new TabPage();
            dTPFechaCompraVehiculoA = new DateTimePicker();
            label4 = new Label();
            txtBNMatriculaVehiculoA = new TextBox();
            txtBApellidoVehiculoA = new TextBox();
            txtBNombreVehiculoA = new TextBox();
            label16 = new Label();
            label11 = new Label();
            BActualizarVehiculo = new Button();
            label5 = new Label();
            registrarTabPage = new TabPage();
            label21 = new Label();
            dTPFechaCompraVehiculoR = new DateTimePicker();
            label13 = new Label();
            txtBApellidoVehiculoR = new TextBox();
            txtBNombreVehiculoR = new TextBox();
            txtBNMatriculaVehiculoR = new TextBox();
            label8 = new Label();
            BRegistrarVehiculo = new Button();
            personNameLabel = new Label();
            comercialNameLabel = new Label();
            clientesTabControl = new TabControl();
            ((System.ComponentModel.ISupportInitialize)DGWVEHICULO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGWClientes).BeginInit();
            eliminarTabPage.SuspendLayout();
            actualizarTabPage.SuspendLayout();
            registrarTabPage.SuspendLayout();
            clientesTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // DGWVEHICULO
            // 
            DGWVEHICULO.BackgroundColor = Color.White;
            DGWVEHICULO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWVEHICULO.Location = new Point(130, 481);
            DGWVEHICULO.Margin = new Padding(3, 4, 3, 4);
            DGWVEHICULO.Name = "DGWVEHICULO";
            DGWVEHICULO.RowHeadersWidth = 51;
            DGWVEHICULO.RowTemplate.Height = 24;
            DGWVEHICULO.Size = new Size(1384, 341);
            DGWVEHICULO.TabIndex = 43;
            DGWVEHICULO.CellClick += DGWVEHICULO_CellClick;
            DGWVEHICULO.DataBindingComplete += DGWVEHICULO_DataBindingComplete;
            // 
            // label19
            // 
            label19.Dock = DockStyle.Top;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(0, 0);
            label19.Name = "label19";
            label19.Size = new Size(1612, 40);
            label19.TabIndex = 46;
            label19.Text = "VEHÍCULO";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // DGWClientes
            // 
            DGWClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWClientes.Location = new Point(672, 100);
            DGWClientes.Name = "DGWClientes";
            DGWClientes.RowHeadersWidth = 51;
            DGWClientes.Size = new Size(907, 293);
            DGWClientes.TabIndex = 47;
            DGWClientes.CellClick += dGWCliente_CellClick;
            DGWClientes.DataBindingComplete += DGWClientes_DataBindingComplete;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(672, 67);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 48;
            label7.Text = "Lista Clientes";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(130, 448);
            label20.Name = "label20";
            label20.Size = new Size(105, 20);
            label20.TabIndex = 49;
            label20.Text = "Lista Vehículos";
            // 
            // eliminarTabPage
            // 
            eliminarTabPage.BackColor = Color.White;
            eliminarTabPage.Controls.Add(txtdTPFechaCompraVehiculoE);
            eliminarTabPage.Controls.Add(label10);
            eliminarTabPage.Controls.Add(txtBNMatriculaVehiculoE);
            eliminarTabPage.Controls.Add(txtBNombreVehiculoE);
            eliminarTabPage.Controls.Add(txtBApellidoVehiculoE);
            eliminarTabPage.Controls.Add(label12);
            eliminarTabPage.Controls.Add(label15);
            eliminarTabPage.Controls.Add(label17);
            eliminarTabPage.Controls.Add(BEliminarVehiculo);
            eliminarTabPage.Location = new Point(4, 29);
            eliminarTabPage.Name = "eliminarTabPage";
            eliminarTabPage.Padding = new Padding(3);
            eliminarTabPage.Size = new Size(516, 293);
            eliminarTabPage.TabIndex = 3;
            eliminarTabPage.Text = "Eliminar";
            // 
            // txtdTPFechaCompraVehiculoE
            // 
            txtdTPFechaCompraVehiculoE.Location = new Point(187, 70);
            txtdTPFechaCompraVehiculoE.Name = "txtdTPFechaCompraVehiculoE";
            txtdTPFechaCompraVehiculoE.ReadOnly = true;
            txtdTPFechaCompraVehiculoE.Size = new Size(210, 27);
            txtdTPFechaCompraVehiculoE.TabIndex = 77;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(119, 147);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 75;
            label10.Text = "Apellido:";
            // 
            // txtBNMatriculaVehiculoE
            // 
            txtBNMatriculaVehiculoE.Location = new Point(185, 27);
            txtBNMatriculaVehiculoE.Margin = new Padding(3, 4, 3, 4);
            txtBNMatriculaVehiculoE.Multiline = true;
            txtBNMatriculaVehiculoE.Name = "txtBNMatriculaVehiculoE";
            txtBNMatriculaVehiculoE.ReadOnly = true;
            txtBNMatriculaVehiculoE.Size = new Size(212, 29);
            txtBNMatriculaVehiculoE.TabIndex = 69;
            // 
            // txtBNombreVehiculoE
            // 
            txtBNombreVehiculoE.Location = new Point(187, 104);
            txtBNombreVehiculoE.Margin = new Padding(3, 4, 3, 4);
            txtBNombreVehiculoE.Multiline = true;
            txtBNombreVehiculoE.Name = "txtBNombreVehiculoE";
            txtBNombreVehiculoE.ReadOnly = true;
            txtBNombreVehiculoE.Size = new Size(212, 29);
            txtBNombreVehiculoE.TabIndex = 74;
            // 
            // txtBApellidoVehiculoE
            // 
            txtBApellidoVehiculoE.Location = new Point(187, 134);
            txtBApellidoVehiculoE.Margin = new Padding(3, 4, 3, 4);
            txtBApellidoVehiculoE.Multiline = true;
            txtBApellidoVehiculoE.Name = "txtBApellidoVehiculoE";
            txtBApellidoVehiculoE.ReadOnly = true;
            txtBApellidoVehiculoE.Size = new Size(212, 29);
            txtBApellidoVehiculoE.TabIndex = 76;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(56, 30);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 66;
            label12.Text = "Número matricula:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(79, 71);
            label15.Name = "label15";
            label15.Size = new Size(107, 20);
            label15.TabIndex = 67;
            label15.Text = "Fecha Compra:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(114, 107);
            label17.Name = "label17";
            label17.Size = new Size(67, 20);
            label17.TabIndex = 73;
            label17.Text = "Nombre:";
            // 
            // BEliminarVehiculo
            // 
            BEliminarVehiculo.Location = new Point(185, 205);
            BEliminarVehiculo.Margin = new Padding(3, 4, 3, 4);
            BEliminarVehiculo.Name = "BEliminarVehiculo";
            BEliminarVehiculo.Size = new Size(114, 37);
            BEliminarVehiculo.TabIndex = 72;
            BEliminarVehiculo.Text = "Eliminar";
            BEliminarVehiculo.UseVisualStyleBackColor = true;
            BEliminarVehiculo.Click += BEliminarVehiculo_Click;
            // 
            // actualizarTabPage
            // 
            actualizarTabPage.BackColor = Color.White;
            actualizarTabPage.Controls.Add(dTPFechaCompraVehiculoA);
            actualizarTabPage.Controls.Add(label4);
            actualizarTabPage.Controls.Add(txtBNMatriculaVehiculoA);
            actualizarTabPage.Controls.Add(txtBApellidoVehiculoA);
            actualizarTabPage.Controls.Add(txtBNombreVehiculoA);
            actualizarTabPage.Controls.Add(label16);
            actualizarTabPage.Controls.Add(label11);
            actualizarTabPage.Controls.Add(BActualizarVehiculo);
            actualizarTabPage.Controls.Add(label5);
            actualizarTabPage.Location = new Point(4, 29);
            actualizarTabPage.Name = "actualizarTabPage";
            actualizarTabPage.Padding = new Padding(3);
            actualizarTabPage.Size = new Size(516, 293);
            actualizarTabPage.TabIndex = 2;
            actualizarTabPage.Text = "Actualizar";
            // 
            // dTPFechaCompraVehiculoA
            // 
            dTPFechaCompraVehiculoA.Location = new Point(154, 69);
            dTPFechaCompraVehiculoA.Name = "dTPFechaCompraVehiculoA";
            dTPFechaCompraVehiculoA.Size = new Size(250, 27);
            dTPFechaCompraVehiculoA.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 155);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 64;
            label4.Text = "Apellido:";
            // 
            // txtBNMatriculaVehiculoA
            // 
            txtBNMatriculaVehiculoA.Location = new Point(154, 18);
            txtBNMatriculaVehiculoA.Margin = new Padding(3, 4, 3, 4);
            txtBNMatriculaVehiculoA.Multiline = true;
            txtBNMatriculaVehiculoA.Name = "txtBNMatriculaVehiculoA";
            txtBNMatriculaVehiculoA.ReadOnly = true;
            txtBNMatriculaVehiculoA.Size = new Size(212, 29);
            txtBNMatriculaVehiculoA.TabIndex = 58;
            // 
            // txtBApellidoVehiculoA
            // 
            txtBApellidoVehiculoA.Location = new Point(154, 146);
            txtBApellidoVehiculoA.Margin = new Padding(3, 4, 3, 4);
            txtBApellidoVehiculoA.Multiline = true;
            txtBApellidoVehiculoA.Name = "txtBApellidoVehiculoA";
            txtBApellidoVehiculoA.ReadOnly = true;
            txtBApellidoVehiculoA.Size = new Size(212, 29);
            txtBApellidoVehiculoA.TabIndex = 65;
            // 
            // txtBNombreVehiculoA
            // 
            txtBNombreVehiculoA.Location = new Point(154, 107);
            txtBNombreVehiculoA.Margin = new Padding(3, 4, 3, 4);
            txtBNombreVehiculoA.Multiline = true;
            txtBNombreVehiculoA.Name = "txtBNombreVehiculoA";
            txtBNombreVehiculoA.ReadOnly = true;
            txtBNombreVehiculoA.Size = new Size(212, 29);
            txtBNombreVehiculoA.TabIndex = 63;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(28, 30);
            label16.Name = "label16";
            label16.Size = new Size(132, 20);
            label16.TabIndex = 55;
            label16.Text = "Número matricula:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 74);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 56;
            label11.Text = "Fecha Compra:";
            // 
            // BActualizarVehiculo
            // 
            BActualizarVehiculo.Location = new Point(180, 216);
            BActualizarVehiculo.Margin = new Padding(3, 4, 3, 4);
            BActualizarVehiculo.Name = "BActualizarVehiculo";
            BActualizarVehiculo.Size = new Size(114, 37);
            BActualizarVehiculo.TabIndex = 61;
            BActualizarVehiculo.Text = "Actualizar";
            BActualizarVehiculo.UseVisualStyleBackColor = true;
            BActualizarVehiculo.Click += BActualizarVehiculo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 116);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 62;
            label5.Text = "Nombre:";
            // 
            // registrarTabPage
            // 
            registrarTabPage.BackColor = Color.White;
            registrarTabPage.Controls.Add(label21);
            registrarTabPage.Controls.Add(dTPFechaCompraVehiculoR);
            registrarTabPage.Controls.Add(label13);
            registrarTabPage.Controls.Add(txtBApellidoVehiculoR);
            registrarTabPage.Controls.Add(txtBNombreVehiculoR);
            registrarTabPage.Controls.Add(txtBNMatriculaVehiculoR);
            registrarTabPage.Controls.Add(label8);
            registrarTabPage.Controls.Add(BRegistrarVehiculo);
            registrarTabPage.Controls.Add(personNameLabel);
            registrarTabPage.Controls.Add(comercialNameLabel);
            registrarTabPage.Location = new Point(4, 29);
            registrarTabPage.Name = "registrarTabPage";
            registrarTabPage.Padding = new Padding(3);
            registrarTabPage.Size = new Size(516, 293);
            registrarTabPage.TabIndex = 0;
            registrarTabPage.Text = "Registrar";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(51, 118);
            label21.Name = "label21";
            label21.Size = new Size(321, 20);
            label21.TabIndex = 45;
            label21.Text = "Seleccione al propietario de la lista de clientes.";
            // 
            // dTPFechaCompraVehiculoR
            // 
            dTPFechaCompraVehiculoR.Location = new Point(202, 69);
            dTPFechaCompraVehiculoR.Name = "dTPFechaCompraVehiculoR";
            dTPFechaCompraVehiculoR.Size = new Size(250, 27);
            dTPFechaCompraVehiculoR.TabIndex = 44;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(114, 190);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 42;
            label13.Text = "Apellido:";
            // 
            // txtBApellidoVehiculoR
            // 
            txtBApellidoVehiculoR.Location = new Point(204, 181);
            txtBApellidoVehiculoR.Margin = new Padding(3, 4, 3, 4);
            txtBApellidoVehiculoR.Multiline = true;
            txtBApellidoVehiculoR.Name = "txtBApellidoVehiculoR";
            txtBApellidoVehiculoR.ReadOnly = true;
            txtBApellidoVehiculoR.Size = new Size(212, 29);
            txtBApellidoVehiculoR.TabIndex = 43;
            // 
            // txtBNombreVehiculoR
            // 
            txtBNombreVehiculoR.Location = new Point(202, 142);
            txtBNombreVehiculoR.Margin = new Padding(3, 4, 3, 4);
            txtBNombreVehiculoR.Multiline = true;
            txtBNombreVehiculoR.Name = "txtBNombreVehiculoR";
            txtBNombreVehiculoR.ReadOnly = true;
            txtBNombreVehiculoR.Size = new Size(212, 29);
            txtBNombreVehiculoR.TabIndex = 41;
            // 
            // txtBNMatriculaVehiculoR
            // 
            txtBNMatriculaVehiculoR.Location = new Point(202, 26);
            txtBNMatriculaVehiculoR.Margin = new Padding(3, 4, 3, 4);
            txtBNMatriculaVehiculoR.Multiline = true;
            txtBNMatriculaVehiculoR.Name = "txtBNMatriculaVehiculoR";
            txtBNMatriculaVehiculoR.Size = new Size(212, 29);
            txtBNMatriculaVehiculoR.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(116, 151);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 40;
            label8.Text = "Nombre:";
            // 
            // BRegistrarVehiculo
            // 
            BRegistrarVehiculo.Location = new Point(218, 236);
            BRegistrarVehiculo.Margin = new Padding(3, 4, 3, 4);
            BRegistrarVehiculo.Name = "BRegistrarVehiculo";
            BRegistrarVehiculo.Size = new Size(114, 37);
            BRegistrarVehiculo.TabIndex = 39;
            BRegistrarVehiculo.Text = "Registrar";
            BRegistrarVehiculo.UseVisualStyleBackColor = true;
            BRegistrarVehiculo.Click += btnRegistrarVehiculo_Click;
            // 
            // personNameLabel
            // 
            personNameLabel.AutoSize = true;
            personNameLabel.Location = new Point(51, 35);
            personNameLabel.Name = "personNameLabel";
            personNameLabel.Size = new Size(132, 20);
            personNameLabel.TabIndex = 6;
            personNameLabel.Text = "Número matricula:";
            // 
            // comercialNameLabel
            // 
            comercialNameLabel.AutoSize = true;
            comercialNameLabel.Location = new Point(76, 78);
            comercialNameLabel.Name = "comercialNameLabel";
            comercialNameLabel.Size = new Size(107, 20);
            comercialNameLabel.TabIndex = 7;
            comercialNameLabel.Text = "Fecha Compra:";
            // 
            // clientesTabControl
            // 
            clientesTabControl.Controls.Add(registrarTabPage);
            clientesTabControl.Controls.Add(actualizarTabPage);
            clientesTabControl.Controls.Add(eliminarTabPage);
            clientesTabControl.Location = new Point(75, 67);
            clientesTabControl.Name = "clientesTabControl";
            clientesTabControl.SelectedIndex = 0;
            clientesTabControl.Size = new Size(524, 326);
            clientesTabControl.TabIndex = 45;
            // 
            // Form_Vehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 853);
            Controls.Add(label20);
            Controls.Add(label7);
            Controls.Add(DGWClientes);
            Controls.Add(label19);
            Controls.Add(clientesTabControl);
            Controls.Add(DGWVEHICULO);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Vehiculo";
            Text = "Form_Vehiculo";
            ((System.ComponentModel.ISupportInitialize)DGWVEHICULO).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGWClientes).EndInit();
            eliminarTabPage.ResumeLayout(false);
            eliminarTabPage.PerformLayout();
            actualizarTabPage.ResumeLayout(false);
            actualizarTabPage.PerformLayout();
            registrarTabPage.ResumeLayout(false);
            registrarTabPage.PerformLayout();
            clientesTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGWVEHICULO;
        private Label label19;
        private DataGridView DGWClientes;
        private Label label7;
        private Label label20;
        private TabPage eliminarTabPage;
        private TextBox txtdTPFechaCompraVehiculoE;
        private Label label10;
        private TextBox txtBNMatriculaVehiculoE;
        private TextBox txtBNombreVehiculoE;
        private TextBox txtBApellidoVehiculoE;
        private Label label12;
        private Label label15;
        private Label label17;
        private Button BEliminarVehiculo;
        private TabPage actualizarTabPage;
        private DateTimePicker dTPFechaCompraVehiculoA;
        private Label label4;
        private TextBox txtBNMatriculaVehiculoA;
        private TextBox txtBApellidoVehiculoA;
        private TextBox txtBNombreVehiculoA;
        private Label label16;
        private Label label11;
        private Button BActualizarVehiculo;
        private Label label5;
        private TabPage registrarTabPage;
        private Label label21;
        private DateTimePicker dTPFechaCompraVehiculoR;
        private Label label13;
        private TextBox txtBApellidoVehiculoR;
        private TextBox txtBNombreVehiculoR;
        private TextBox txtBNMatriculaVehiculoR;
        private Label label8;
        private Button BRegistrarVehiculo;
        private Label personNameLabel;
        private Label comercialNameLabel;
        private TabControl clientesTabControl;
    }
}