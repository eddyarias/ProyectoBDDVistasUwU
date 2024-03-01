namespace ProyectoBDDVistas.FORMS
{
    partial class Form_Factura
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
            DGWFacturas = new DataGridView();
            label29 = new Label();
            dGWReparacionFactura = new DataGridView();
            actualizarTabPage = new TabPage();
            panel1 = new Panel();
            button2 = new Button();
            txtBidRepFacActEli = new TextBox();
            label3 = new Label();
            button1 = new Button();
            dTPFecFacActEli = new DateTimePicker();
            label4 = new Label();
            txtBidFacActEli = new TextBox();
            label5 = new Label();
            registrarTabPage = new TabPage();
            panel2 = new Panel();
            txtBidRepFacReg = new TextBox();
            label2 = new Label();
            bttAgregarRegistrar = new Button();
            dTPFecFacRegistrar = new DateTimePicker();
            label40 = new Label();
            txtidFacRegistrar = new TextBox();
            label38 = new Label();
            clientesTabControl = new TabControl();
            label6 = new Label();
            txtBmatVehFacReg = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGWFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGWReparacionFactura).BeginInit();
            actualizarTabPage.SuspendLayout();
            panel1.SuspendLayout();
            registrarTabPage.SuspendLayout();
            panel2.SuspendLayout();
            clientesTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1634, 40);
            label1.TabIndex = 1;
            label1.Text = "FACTURA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // DGWFacturas
            // 
            DGWFacturas.AllowUserToAddRows = false;
            DGWFacturas.AllowUserToDeleteRows = false;
            DGWFacturas.AllowUserToResizeColumns = false;
            DGWFacturas.AllowUserToResizeRows = false;
            DGWFacturas.BackgroundColor = Color.White;
            DGWFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWFacturas.Location = new Point(127, 428);
            DGWFacturas.Margin = new Padding(3, 4, 3, 4);
            DGWFacturas.Name = "DGWFacturas";
            DGWFacturas.ReadOnly = true;
            DGWFacturas.RowHeadersVisible = false;
            DGWFacturas.RowHeadersWidth = 51;
            DGWFacturas.RowTemplate.Height = 24;
            DGWFacturas.Size = new Size(1454, 367);
            DGWFacturas.TabIndex = 44;
            DGWFacturas.DataBindingComplete += DGWFacturas_DataBindingComplete;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(708, 103);
            label29.Name = "label29";
            label29.Size = new Size(307, 20);
            label29.TabIndex = 110;
            label29.Text = "Selecciona la reparacion que deseas facturar:";
            // 
            // dGWReparacionFactura
            // 
            dGWReparacionFactura.AllowUserToAddRows = false;
            dGWReparacionFactura.AllowUserToDeleteRows = false;
            dGWReparacionFactura.AllowUserToResizeColumns = false;
            dGWReparacionFactura.AllowUserToResizeRows = false;
            dGWReparacionFactura.BackgroundColor = Color.White;
            dGWReparacionFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWReparacionFactura.Location = new Point(693, 127);
            dGWReparacionFactura.Margin = new Padding(3, 4, 3, 4);
            dGWReparacionFactura.Name = "dGWReparacionFactura";
            dGWReparacionFactura.ReadOnly = true;
            dGWReparacionFactura.RowHeadersVisible = false;
            dGWReparacionFactura.RowHeadersWidth = 51;
            dGWReparacionFactura.RowTemplate.Height = 24;
            dGWReparacionFactura.Size = new Size(929, 236);
            dGWReparacionFactura.TabIndex = 111;
            dGWReparacionFactura.CellClick += dGWReparacionFactura_CellClick;
            // 
            // actualizarTabPage
            // 
            actualizarTabPage.BackColor = Color.White;
            actualizarTabPage.Controls.Add(panel1);
            actualizarTabPage.Location = new Point(4, 29);
            actualizarTabPage.Name = "actualizarTabPage";
            actualizarTabPage.Padding = new Padding(3);
            actualizarTabPage.Size = new Size(645, 231);
            actualizarTabPage.TabIndex = 2;
            actualizarTabPage.Text = "Actualizar";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtBidRepFacActEli);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dTPFecFacActEli);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBidFacActEli);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(18, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 193);
            panel1.TabIndex = 118;
            // 
            // button2
            // 
            button2.Location = new Point(368, 138);
            button2.Name = "button2";
            button2.Size = new Size(147, 43);
            button2.TabIndex = 120;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtBidRepFacActEli
            // 
            txtBidRepFacActEli.Location = new Point(225, 84);
            txtBidRepFacActEli.Margin = new Padding(3, 4, 3, 4);
            txtBidRepFacActEli.Name = "txtBidRepFacActEli";
            txtBidRepFacActEli.ReadOnly = true;
            txtBidRepFacActEli.Size = new Size(213, 27);
            txtBidRepFacActEli.TabIndex = 119;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 91);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 118;
            label3.Text = "Id reparacion:";
            // 
            // button1
            // 
            button1.Location = new Point(182, 138);
            button1.Name = "button1";
            button1.Size = new Size(147, 43);
            button1.TabIndex = 117;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dTPFecFacActEli
            // 
            dTPFecFacActEli.Location = new Point(225, 50);
            dTPFecFacActEli.Name = "dTPFecFacActEli";
            dTPFecFacActEli.Size = new Size(290, 27);
            dTPFecFacActEli.TabIndex = 116;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 23);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 115;
            label4.Text = "Id factura:";
            // 
            // txtBidFacActEli
            // 
            txtBidFacActEli.Location = new Point(225, 16);
            txtBidFacActEli.Margin = new Padding(3, 4, 3, 4);
            txtBidFacActEli.Name = "txtBidFacActEli";
            txtBidFacActEli.ReadOnly = true;
            txtBidFacActEli.Size = new Size(213, 27);
            txtBidFacActEli.TabIndex = 114;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 55);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 113;
            label5.Text = "Fecha emisión:";
            // 
            // registrarTabPage
            // 
            registrarTabPage.BackColor = Color.White;
            registrarTabPage.Controls.Add(panel2);
            registrarTabPage.Location = new Point(4, 29);
            registrarTabPage.Name = "registrarTabPage";
            registrarTabPage.Padding = new Padding(3);
            registrarTabPage.Size = new Size(645, 291);
            registrarTabPage.TabIndex = 0;
            registrarTabPage.Text = "Registrar";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBmatVehFacReg);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtBidRepFacReg);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(bttAgregarRegistrar);
            panel2.Controls.Add(dTPFecFacRegistrar);
            panel2.Controls.Add(label40);
            panel2.Controls.Add(txtidFacRegistrar);
            panel2.Controls.Add(label38);
            panel2.Location = new Point(19, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 254);
            panel2.TabIndex = 117;
            // 
            // txtBidRepFacReg
            // 
            txtBidRepFacReg.Location = new Point(225, 123);
            txtBidRepFacReg.Margin = new Padding(3, 4, 3, 4);
            txtBidRepFacReg.Name = "txtBidRepFacReg";
            txtBidRepFacReg.ReadOnly = true;
            txtBidRepFacReg.Size = new Size(213, 27);
            txtBidRepFacReg.TabIndex = 119;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 88);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 118;
            label2.Text = "Matricula vehiculo:";
            label2.Click += label2_Click;
            // 
            // bttAgregarRegistrar
            // 
            bttAgregarRegistrar.Location = new Point(225, 173);
            bttAgregarRegistrar.Name = "bttAgregarRegistrar";
            bttAgregarRegistrar.Size = new Size(147, 47);
            bttAgregarRegistrar.TabIndex = 117;
            bttAgregarRegistrar.Text = "Registrar";
            bttAgregarRegistrar.UseVisualStyleBackColor = true;
            bttAgregarRegistrar.Click += bttAgregarRegistrar_Click;
            // 
            // dTPFecFacRegistrar
            // 
            dTPFecFacRegistrar.Location = new Point(225, 50);
            dTPFecFacRegistrar.Name = "dTPFecFacRegistrar";
            dTPFecFacRegistrar.Size = new Size(290, 27);
            dTPFecFacRegistrar.TabIndex = 116;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(144, 23);
            label40.Name = "label40";
            label40.Size = new Size(75, 20);
            label40.TabIndex = 115;
            label40.Text = "Id factura:";
            // 
            // txtidFacRegistrar
            // 
            txtidFacRegistrar.Location = new Point(225, 16);
            txtidFacRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtidFacRegistrar.Name = "txtidFacRegistrar";
            txtidFacRegistrar.Size = new Size(213, 27);
            txtidFacRegistrar.TabIndex = 114;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(113, 55);
            label38.Name = "label38";
            label38.Size = new Size(106, 20);
            label38.TabIndex = 113;
            label38.Text = "Fecha emisión:";
            // 
            // clientesTabControl
            // 
            clientesTabControl.Controls.Add(registrarTabPage);
            clientesTabControl.Controls.Add(actualizarTabPage);
            clientesTabControl.Location = new Point(30, 43);
            clientesTabControl.Name = "clientesTabControl";
            clientesTabControl.SelectedIndex = 0;
            clientesTabControl.Size = new Size(653, 324);
            clientesTabControl.TabIndex = 118;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 404);
            label6.Name = "label6";
            label6.Size = new Size(378, 20);
            label6.TabIndex = 119;
            label6.Text = "Selecciona una factura que deseas modificar o eliminar:";
            // 
            // txtBmatVehFacReg
            // 
            txtBmatVehFacReg.Location = new Point(225, 88);
            txtBmatVehFacReg.Margin = new Padding(3, 4, 3, 4);
            txtBmatVehFacReg.Name = "txtBmatVehFacReg";
            txtBmatVehFacReg.ReadOnly = true;
            txtBmatVehFacReg.Size = new Size(213, 27);
            txtBmatVehFacReg.TabIndex = 121;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 123);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 120;
            label7.Text = "Id reparaciones:";
            // 
            // Form_Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 853);
            Controls.Add(label6);
            Controls.Add(clientesTabControl);
            Controls.Add(dGWReparacionFactura);
            Controls.Add(label29);
            Controls.Add(DGWFacturas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Factura";
            Text = "Form_Factura";
            ((System.ComponentModel.ISupportInitialize)DGWFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGWReparacionFactura).EndInit();
            actualizarTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            registrarTabPage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            clientesTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGWFactura;
        private DataGridView DGWFacturas;
        private Label label29;
        private DataGridView dGWReparacionFactura;
        private TabPage actualizarTabPage;
        private Panel panel1;
        private Button button2;
        private TextBox txtBidRepFacActEli;
        private Label label3;
        private Button button1;
        private DateTimePicker dTPFecFacActEli;
        private Label label4;
        private TextBox txtBidFacActEli;
        private Label label5;
        private TabPage registrarTabPage;
        private Panel panel2;
        private TextBox txtBidRepFacReg;
        private Label label2;
        private Button bttAgregarRegistrar;
        private DateTimePicker dTPFecFacRegistrar;
        private Label label40;
        private TextBox txtidFacRegistrar;
        private Label label38;
        private TabControl clientesTabControl;
        private Label label6;
        private TextBox txtBmatVehFacReg;
        private Label label7;
    }
}