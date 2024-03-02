namespace ProyectoBDDVistas.FORMS
{
    partial class Form_NumeroTelefono
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
            dGWEmpleado = new DataGridView();
            dGWNumeroTelefono = new DataGridView();
            facturaTabControl = new TabControl();
            registrarTabPage = new TabPage();
            panel2 = new Panel();
            label5 = new Label();
            txtBnumTelEmpleadoRegistrar = new TextBox();
            label9 = new Label();
            txtBidEmpleadoRegistrar = new TextBox();
            label8 = new Label();
            bttAgregarRegistrar = new Button();
            label40 = new Label();
            txtBnombEmpleadoRegistrar = new TextBox();
            actualizarTabPage = new TabPage();
            panel1 = new Panel();
            button2 = new Button();
            label7 = new Label();
            txtBnumTelEmpleadoActEli = new TextBox();
            label2 = new Label();
            txtBidEmpleadoActEli = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBnomEmpleadoActEli = new TextBox();
            label6 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGWEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWNumeroTelefono).BeginInit();
            facturaTabControl.SuspendLayout();
            registrarTabPage.SuspendLayout();
            panel2.SuspendLayout();
            actualizarTabPage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1614, 40);
            label1.TabIndex = 1;
            label1.Text = "NUMERO TELEFONO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dGWEmpleado
            // 
            dGWEmpleado.AllowUserToAddRows = false;
            dGWEmpleado.AllowUserToDeleteRows = false;
            dGWEmpleado.AllowUserToResizeColumns = false;
            dGWEmpleado.AllowUserToResizeRows = false;
            dGWEmpleado.BackgroundColor = Color.White;
            dGWEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWEmpleado.Location = new Point(22, 465);
            dGWEmpleado.Margin = new Padding(3, 4, 3, 4);
            dGWEmpleado.Name = "dGWEmpleado";
            dGWEmpleado.ReadOnly = true;
            dGWEmpleado.RowHeadersVisible = false;
            dGWEmpleado.RowHeadersWidth = 51;
            dGWEmpleado.RowTemplate.Height = 24;
            dGWEmpleado.Size = new Size(1029, 310);
            dGWEmpleado.TabIndex = 86;
            // 
            // dGWNumeroTelefono
            // 
            dGWNumeroTelefono.AllowUserToAddRows = false;
            dGWNumeroTelefono.AllowUserToDeleteRows = false;
            dGWNumeroTelefono.AllowUserToResizeColumns = false;
            dGWNumeroTelefono.AllowUserToResizeRows = false;
            dGWNumeroTelefono.BackgroundColor = Color.White;
            dGWNumeroTelefono.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWNumeroTelefono.Location = new Point(1078, 130);
            dGWNumeroTelefono.Margin = new Padding(3, 4, 3, 4);
            dGWNumeroTelefono.Name = "dGWNumeroTelefono";
            dGWNumeroTelefono.ReadOnly = true;
            dGWNumeroTelefono.RowHeadersVisible = false;
            dGWNumeroTelefono.RowHeadersWidth = 51;
            dGWNumeroTelefono.RowTemplate.Height = 24;
            dGWNumeroTelefono.Size = new Size(514, 634);
            dGWNumeroTelefono.TabIndex = 87;
            // 
            // facturaTabControl
            // 
            facturaTabControl.Controls.Add(registrarTabPage);
            facturaTabControl.Controls.Add(actualizarTabPage);
            facturaTabControl.Location = new Point(22, 88);
            facturaTabControl.Name = "facturaTabControl";
            facturaTabControl.SelectedIndex = 0;
            facturaTabControl.Size = new Size(657, 349);
            facturaTabControl.TabIndex = 119;
            // 
            // registrarTabPage
            // 
            registrarTabPage.BackColor = Color.White;
            registrarTabPage.Controls.Add(panel2);
            registrarTabPage.Location = new Point(4, 29);
            registrarTabPage.Name = "registrarTabPage";
            registrarTabPage.Padding = new Padding(3);
            registrarTabPage.Size = new Size(649, 316);
            registrarTabPage.TabIndex = 0;
            registrarTabPage.Text = "Registrar";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtBnumTelEmpleadoRegistrar);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtBidEmpleadoRegistrar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(bttAgregarRegistrar);
            panel2.Controls.Add(label40);
            panel2.Controls.Add(txtBnombEmpleadoRegistrar);
            panel2.Location = new Point(6, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 296);
            panel2.TabIndex = 117;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 140);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 127;
            label5.Text = "NumeroTelefonico:";
            // 
            // txtBnumTelEmpleadoRegistrar
            // 
            txtBnumTelEmpleadoRegistrar.Location = new Point(231, 137);
            txtBnumTelEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBnumTelEmpleadoRegistrar.Name = "txtBnumTelEmpleadoRegistrar";
            txtBnumTelEmpleadoRegistrar.Size = new Size(213, 27);
            txtBnumTelEmpleadoRegistrar.TabIndex = 126;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 27);
            label9.Name = "label9";
            label9.Size = new Size(572, 20);
            label9.TabIndex = 125;
            label9.Text = "Nota: Para agregar un numero de telefono a un empleado primero debe serccionarlo";
            // 
            // txtBidEmpleadoRegistrar
            // 
            txtBidEmpleadoRegistrar.Location = new Point(231, 67);
            txtBidEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBidEmpleadoRegistrar.Name = "txtBidEmpleadoRegistrar";
            txtBidEmpleadoRegistrar.ReadOnly = true;
            txtBidEmpleadoRegistrar.Size = new Size(213, 27);
            txtBidEmpleadoRegistrar.TabIndex = 123;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 105);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 122;
            label8.Text = "Nombre empleado:";
            // 
            // bttAgregarRegistrar
            // 
            bttAgregarRegistrar.Location = new Point(253, 218);
            bttAgregarRegistrar.Name = "bttAgregarRegistrar";
            bttAgregarRegistrar.Size = new Size(147, 47);
            bttAgregarRegistrar.TabIndex = 117;
            bttAgregarRegistrar.Text = "Registrar";
            bttAgregarRegistrar.UseVisualStyleBackColor = true;
            bttAgregarRegistrar.Click += bttAgregarRegistrar_Click;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(128, 74);
            label40.Name = "label40";
            label40.Size = new Size(97, 20);
            label40.TabIndex = 115;
            label40.Text = "Id empleado:";
            // 
            // txtBnombEmpleadoRegistrar
            // 
            txtBnombEmpleadoRegistrar.Location = new Point(231, 102);
            txtBnombEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBnombEmpleadoRegistrar.Name = "txtBnombEmpleadoRegistrar";
            txtBnombEmpleadoRegistrar.ReadOnly = true;
            txtBnombEmpleadoRegistrar.Size = new Size(213, 27);
            txtBnombEmpleadoRegistrar.TabIndex = 114;
            // 
            // actualizarTabPage
            // 
            actualizarTabPage.BackColor = Color.White;
            actualizarTabPage.Controls.Add(panel1);
            actualizarTabPage.Location = new Point(4, 29);
            actualizarTabPage.Name = "actualizarTabPage";
            actualizarTabPage.Padding = new Padding(3);
            actualizarTabPage.Size = new Size(649, 316);
            actualizarTabPage.TabIndex = 2;
            actualizarTabPage.Text = "Actualizar / Eliminar";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtBnumTelEmpleadoActEli);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBidEmpleadoActEli);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBnomEmpleadoActEli);
            panel1.Location = new Point(8, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 297);
            panel1.TabIndex = 118;
            // 
            // button2
            // 
            button2.Location = new Point(231, 215);
            button2.Name = "button2";
            button2.Size = new Size(147, 47);
            button2.TabIndex = 130;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 140);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 129;
            label7.Text = "NumeroTelefonico:";
            // 
            // txtBnumTelEmpleadoActEli
            // 
            txtBnumTelEmpleadoActEli.Location = new Point(231, 137);
            txtBnumTelEmpleadoActEli.Margin = new Padding(3, 4, 3, 4);
            txtBnumTelEmpleadoActEli.Name = "txtBnumTelEmpleadoActEli";
            txtBnumTelEmpleadoActEli.ReadOnly = true;
            txtBnumTelEmpleadoActEli.Size = new Size(213, 27);
            txtBnumTelEmpleadoActEli.TabIndex = 128;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 27);
            label2.Name = "label2";
            label2.Size = new Size(584, 20);
            label2.TabIndex = 125;
            label2.Text = "Nota: Para actualizar un numero de telefono a un empleado primero debe serccionarlo";
            // 
            // txtBidEmpleadoActEli
            // 
            txtBidEmpleadoActEli.Location = new Point(231, 67);
            txtBidEmpleadoActEli.Margin = new Padding(3, 4, 3, 4);
            txtBidEmpleadoActEli.Name = "txtBidEmpleadoActEli";
            txtBidEmpleadoActEli.ReadOnly = true;
            txtBidEmpleadoActEli.Size = new Size(213, 27);
            txtBidEmpleadoActEli.TabIndex = 123;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 109);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 122;
            label3.Text = "Nombre empleado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 74);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 115;
            label4.Text = "Id empleado:";
            // 
            // txtBnomEmpleadoActEli
            // 
            txtBnomEmpleadoActEli.Location = new Point(231, 102);
            txtBnomEmpleadoActEli.Margin = new Padding(3, 4, 3, 4);
            txtBnomEmpleadoActEli.Name = "txtBnomEmpleadoActEli";
            txtBnomEmpleadoActEli.ReadOnly = true;
            txtBnomEmpleadoActEli.Size = new Size(213, 27);
            txtBnomEmpleadoActEli.TabIndex = 114;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1078, 106);
            label6.Name = "label6";
            label6.Size = new Size(198, 20);
            label6.TabIndex = 132;
            label6.Text = "Lista de numeros telefonicos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(862, 64);
            label10.Name = "label10";
            label10.Size = new Size(730, 20);
            label10.TabIndex = 131;
            label10.Text = "Nota: Para actualizar un numero de telefono de un empleado primero debe seccionarlo cual desea actualizar";
            // 
            // Form_NumeroTelefono
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 788);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(facturaTabControl);
            Controls.Add(dGWNumeroTelefono);
            Controls.Add(dGWEmpleado);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_NumeroTelefono";
            Text = "Form_NumeroTelefono";
            ((System.ComponentModel.ISupportInitialize)dGWEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWNumeroTelefono).EndInit();
            facturaTabControl.ResumeLayout(false);
            registrarTabPage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            actualizarTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dGWEmpleado;
        private DataGridView dGWNumeroTelefono;
        private TabControl facturaTabControl;
        private TabPage registrarTabPage;
        private Panel panel2;
        private Label label9;
        private TextBox txtBidEmpleadoRegistrar;
        private Label label8;
        private Button bttAgregarRegistrar;
        private Label label40;
        private TextBox txtBnombEmpleadoRegistrar;
        private TabPage actualizarTabPage;
        private Label label6;
        private Label label5;
        private TextBox txtBnumTelEmpleadoRegistrar;
        private Panel panel1;
        private Button button2;
        private Label label7;
        private TextBox txtBnumTelEmpleadoActEli;
        private Label label2;
        private TextBox txtBidEmpleadoActEli;
        private Label label3;
        private Label label4;
        private TextBox txtBnomEmpleadoActEli;
        private Label label10;
    }
}