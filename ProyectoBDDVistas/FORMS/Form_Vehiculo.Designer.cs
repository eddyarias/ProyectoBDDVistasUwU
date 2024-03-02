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
            clientesTabControl = new TabControl();
            registrarTabPage = new TabPage();
            label21 = new Label();
            dTPFechaCompraVehiculoR = new DateTimePicker();
            label13 = new Label();
            txtBApellidoVehiculoR = new TextBox();
            label8 = new Label();
            txtBNombreVehiculoR = new TextBox();
            BRegistrarVehiculo = new Button();
            personNameLabel = new Label();
            comercialNameLabel = new Label();
            txtBNMatriculaVehiculoR = new TextBox();
            consultarTabPage = new TabPage();
            label1 = new Label();
            textBox7 = new TextBox();
            textBox1 = new TextBox();
            textBox17 = new TextBox();
            label2 = new Label();
            label14 = new Label();
            textBox5 = new TextBox();
            textBox9 = new TextBox();
            button6 = new Button();
            label6 = new Label();
            label3 = new Label();
            actualizarTabPage = new TabPage();
            label4 = new Label();
            textBox8 = new TextBox();
            label16 = new Label();
            textBox11 = new TextBox();
            label11 = new Label();
            textBox12 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox18 = new TextBox();
            label9 = new Label();
            textBox14 = new TextBox();
            eliminarTabPage = new TabPage();
            label10 = new Label();
            textBox10 = new TextBox();
            textBox20 = new TextBox();
            label12 = new Label();
            label18 = new Label();
            textBox13 = new TextBox();
            textBox19 = new TextBox();
            label15 = new Label();
            label17 = new Label();
            textBox15 = new TextBox();
            button2 = new Button();
            DGWVEHICULO = new DataGridView();
            label19 = new Label();
            DGWClientes = new DataGridView();
            label7 = new Label();
            label20 = new Label();
            clientesTabControl.SuspendLayout();
            registrarTabPage.SuspendLayout();
            consultarTabPage.SuspendLayout();
            actualizarTabPage.SuspendLayout();
            eliminarTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGWVEHICULO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGWClientes).BeginInit();
            SuspendLayout();
            // 
            // clientesTabControl
            // 
            clientesTabControl.Controls.Add(registrarTabPage);
            clientesTabControl.Controls.Add(consultarTabPage);
            clientesTabControl.Controls.Add(actualizarTabPage);
            clientesTabControl.Controls.Add(eliminarTabPage);
            clientesTabControl.Location = new Point(75, 67);
            clientesTabControl.Name = "clientesTabControl";
            clientesTabControl.SelectedIndex = 0;
            clientesTabControl.Size = new Size(524, 326);
            clientesTabControl.TabIndex = 45;
            // 
            // registrarTabPage
            // 
            registrarTabPage.BackColor = Color.White;
            registrarTabPage.Controls.Add(label21);
            registrarTabPage.Controls.Add(dTPFechaCompraVehiculoR);
            registrarTabPage.Controls.Add(label13);
            registrarTabPage.Controls.Add(txtBApellidoVehiculoR);
            registrarTabPage.Controls.Add(label8);
            registrarTabPage.Controls.Add(txtBNombreVehiculoR);
            registrarTabPage.Controls.Add(BRegistrarVehiculo);
            registrarTabPage.Controls.Add(personNameLabel);
            registrarTabPage.Controls.Add(comercialNameLabel);
            registrarTabPage.Controls.Add(txtBNMatriculaVehiculoR);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(116, 151);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 40;
            label8.Text = "Nombre:";
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
            // txtBNMatriculaVehiculoR
            // 
            txtBNMatriculaVehiculoR.Location = new Point(202, 26);
            txtBNMatriculaVehiculoR.Margin = new Padding(3, 4, 3, 4);
            txtBNMatriculaVehiculoR.Multiline = true;
            txtBNMatriculaVehiculoR.Name = "txtBNMatriculaVehiculoR";
            txtBNMatriculaVehiculoR.Size = new Size(212, 29);
            txtBNMatriculaVehiculoR.TabIndex = 15;
            // 
            // consultarTabPage
            // 
            consultarTabPage.Controls.Add(label1);
            consultarTabPage.Controls.Add(textBox7);
            consultarTabPage.Controls.Add(textBox1);
            consultarTabPage.Controls.Add(textBox17);
            consultarTabPage.Controls.Add(label2);
            consultarTabPage.Controls.Add(label14);
            consultarTabPage.Controls.Add(textBox5);
            consultarTabPage.Controls.Add(textBox9);
            consultarTabPage.Controls.Add(button6);
            consultarTabPage.Controls.Add(label6);
            consultarTabPage.Controls.Add(label3);
            consultarTabPage.Location = new Point(4, 29);
            consultarTabPage.Name = "consultarTabPage";
            consultarTabPage.Padding = new Padding(3);
            consultarTabPage.Size = new Size(516, 293);
            consultarTabPage.TabIndex = 1;
            consultarTabPage.Text = "Consultar";
            consultarTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 218);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 53;
            label1.Text = "Apellido:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(186, 88);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(212, 29);
            textBox7.TabIndex = 47;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 204);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 29);
            textBox1.TabIndex = 54;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(186, 243);
            textBox17.Margin = new Padding(3, 4, 3, 4);
            textBox17.Multiline = true;
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(102, 29);
            textBox17.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 179);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 51;
            label2.Text = "Nombre:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(113, 254);
            label14.Name = "label14";
            label14.Size = new Size(83, 20);
            label14.TabIndex = 46;
            label14.Text = "ID taller ??:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(186, 165);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(212, 29);
            textBox5.TabIndex = 52;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(186, 127);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(212, 29);
            textBox9.TabIndex = 48;
            // 
            // button6
            // 
            button6.Location = new Point(432, 80);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(114, 37);
            button6.TabIndex = 50;
            button6.Text = "Consultar";
            button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 140);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 45;
            label6.Text = "Fecha Compra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 100);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 44;
            label3.Text = "Número matricula:";
            // 
            // actualizarTabPage
            // 
            actualizarTabPage.BackColor = Color.White;
            actualizarTabPage.Controls.Add(label4);
            actualizarTabPage.Controls.Add(textBox8);
            actualizarTabPage.Controls.Add(label16);
            actualizarTabPage.Controls.Add(textBox11);
            actualizarTabPage.Controls.Add(label11);
            actualizarTabPage.Controls.Add(textBox12);
            actualizarTabPage.Controls.Add(button1);
            actualizarTabPage.Controls.Add(label5);
            actualizarTabPage.Controls.Add(textBox18);
            actualizarTabPage.Controls.Add(label9);
            actualizarTabPage.Controls.Add(textBox14);
            actualizarTabPage.Location = new Point(4, 29);
            actualizarTabPage.Name = "actualizarTabPage";
            actualizarTabPage.Padding = new Padding(3);
            actualizarTabPage.Size = new Size(516, 293);
            actualizarTabPage.TabIndex = 2;
            actualizarTabPage.Text = "Actualizar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 148);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 64;
            label4.Text = "Apellido:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(154, 18);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(212, 29);
            textBox8.TabIndex = 58;
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
            // textBox11
            // 
            textBox11.Location = new Point(156, 134);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(212, 29);
            textBox11.TabIndex = 65;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 70);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 56;
            label11.Text = "Fecha Compra:";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(154, 173);
            textBox12.Margin = new Padding(3, 4, 3, 4);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(102, 29);
            textBox12.TabIndex = 60;
            // 
            // button1
            // 
            button1.Location = new Point(125, 238);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 61;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 109);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 62;
            label5.Text = "Nombre:";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(154, 57);
            textBox18.Margin = new Padding(3, 4, 3, 4);
            textBox18.Multiline = true;
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(212, 29);
            textBox18.TabIndex = 59;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 184);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 57;
            label9.Text = "ID taller ??:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(154, 95);
            textBox14.Margin = new Padding(3, 4, 3, 4);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(212, 29);
            textBox14.TabIndex = 63;
            // 
            // eliminarTabPage
            // 
            eliminarTabPage.BackColor = Color.White;
            eliminarTabPage.Controls.Add(label10);
            eliminarTabPage.Controls.Add(textBox10);
            eliminarTabPage.Controls.Add(textBox20);
            eliminarTabPage.Controls.Add(label12);
            eliminarTabPage.Controls.Add(label18);
            eliminarTabPage.Controls.Add(textBox13);
            eliminarTabPage.Controls.Add(textBox19);
            eliminarTabPage.Controls.Add(label15);
            eliminarTabPage.Controls.Add(label17);
            eliminarTabPage.Controls.Add(textBox15);
            eliminarTabPage.Controls.Add(button2);
            eliminarTabPage.Location = new Point(4, 29);
            eliminarTabPage.Name = "eliminarTabPage";
            eliminarTabPage.Padding = new Padding(3);
            eliminarTabPage.Size = new Size(516, 293);
            eliminarTabPage.TabIndex = 3;
            eliminarTabPage.Text = "Eliminar";
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
            // textBox10
            // 
            textBox10.Location = new Point(185, 18);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(212, 29);
            textBox10.TabIndex = 69;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(185, 95);
            textBox20.Margin = new Padding(3, 4, 3, 4);
            textBox20.Multiline = true;
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(212, 29);
            textBox20.TabIndex = 74;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(59, 30);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 66;
            label12.Text = "Número matricula:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(111, 183);
            label18.Name = "label18";
            label18.Size = new Size(83, 20);
            label18.TabIndex = 68;
            label18.Text = "ID taller ??:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(187, 134);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(212, 29);
            textBox13.TabIndex = 76;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(185, 56);
            textBox19.Margin = new Padding(3, 4, 3, 4);
            textBox19.Multiline = true;
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(212, 29);
            textBox19.TabIndex = 70;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(84, 70);
            label15.Name = "label15";
            label15.Size = new Size(107, 20);
            label15.TabIndex = 67;
            label15.Text = "Fecha Compra:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(119, 109);
            label17.Name = "label17";
            label17.Size = new Size(67, 20);
            label17.TabIndex = 73;
            label17.Text = "Nombre:";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(185, 172);
            textBox15.Margin = new Padding(3, 4, 3, 4);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(102, 29);
            textBox15.TabIndex = 71;
            // 
            // button2
            // 
            button2.Location = new Point(163, 236);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 37);
            button2.TabIndex = 72;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
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
            clientesTabControl.ResumeLayout(false);
            registrarTabPage.ResumeLayout(false);
            registrarTabPage.PerformLayout();
            consultarTabPage.ResumeLayout(false);
            consultarTabPage.PerformLayout();
            actualizarTabPage.ResumeLayout(false);
            actualizarTabPage.PerformLayout();
            eliminarTabPage.ResumeLayout(false);
            eliminarTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGWVEHICULO).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGWClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl clientesTabControl;
        private TabPage registrarTabPage;
        private Label label13;
        private TextBox txtBApellidoVehiculoR;
        private Label label8;
        private TextBox txtBNombreVehiculoR;
        private Button BRegistrarVehiculo;
        private Label personNameLabel;
        private Label comercialNameLabel;
        private TextBox txtBNMatriculaVehiculoR;
        private TabPage consultarTabPage;
        private Label label1;
        private TextBox textBox7;
        private TextBox textBox1;
        private TextBox textBox17;
        private Label label2;
        private Label label14;
        private TextBox textBox5;
        private TextBox textBox9;
        private Button button6;
        private Label label6;
        private Label label3;
        private TabPage actualizarTabPage;
        private Label label4;
        private TextBox textBox8;
        private Label label16;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Button button1;
        private Label label5;
        private TextBox textBox18;
        private Label label9;
        private TextBox textBox14;
        private TabPage eliminarTabPage;
        private Label label10;
        private TextBox textBox10;
        private TextBox textBox20;
        private Label label12;
        private Label label18;
        private TextBox textBox13;
        private TextBox textBox19;
        private Label label15;
        private Label label17;
        private TextBox textBox15;
        private Button button2;
        private DataGridView DGWVEHICULO;
        private Label label19;
        private DateTimePicker dTPFechaCompraVehiculoR;
        private DataGridView DGWClientes;
        private Label label21;
        private Label label7;
        private Label label20;
    }
}