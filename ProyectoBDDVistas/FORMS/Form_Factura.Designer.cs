﻿namespace ProyectoBDDVistas.FORMS
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
            txtBTotalFac = new TextBox();
            txtBIvaFac = new TextBox();
            txtBSubtotalFac = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            button3 = new Button();
            txtBnombApeClienteFacturaRegistrar = new TextBox();
            label8 = new Label();
            txtBmatVehFacReg = new TextBox();
            label7 = new Label();
            txtBidRepFacReg = new TextBox();
            label2 = new Label();
            bttAgregarRegistrar = new Button();
            dTPFecFacRegistrar = new DateTimePicker();
            label40 = new Label();
            txtidFacRegistrar = new TextBox();
            label38 = new Label();
            clientesTabControl = new TabControl();
            label6 = new Label();
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
            DGWFacturas.Location = new Point(114, 577);
            DGWFacturas.Margin = new Padding(3, 4, 3, 4);
            DGWFacturas.Name = "DGWFacturas";
            DGWFacturas.ReadOnly = true;
            DGWFacturas.RowHeadersVisible = false;
            DGWFacturas.RowHeadersWidth = 51;
            DGWFacturas.RowTemplate.Height = 24;
            DGWFacturas.Size = new Size(1454, 263);
            DGWFacturas.TabIndex = 44;
            DGWFacturas.DataBindingComplete += DGWFacturas_DataBindingComplete;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(708, 62);
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
            dGWReparacionFactura.Enabled = false;
            dGWReparacionFactura.Location = new Point(693, 86);
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
            actualizarTabPage.Size = new Size(645, 458);
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
            registrarTabPage.Size = new Size(645, 458);
            registrarTabPage.TabIndex = 0;
            registrarTabPage.Text = "Registrar";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBTotalFac);
            panel2.Controls.Add(txtBIvaFac);
            panel2.Controls.Add(txtBSubtotalFac);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(txtBnombApeClienteFacturaRegistrar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtBmatVehFacReg);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtBidRepFacReg);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(bttAgregarRegistrar);
            panel2.Controls.Add(dTPFecFacRegistrar);
            panel2.Controls.Add(label40);
            panel2.Controls.Add(txtidFacRegistrar);
            panel2.Controls.Add(label38);
            panel2.Location = new Point(6, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 438);
            panel2.TabIndex = 117;
            // 
            // txtBTotalFac
            // 
            txtBTotalFac.Location = new Point(231, 314);
            txtBTotalFac.Margin = new Padding(3, 4, 3, 4);
            txtBTotalFac.Name = "txtBTotalFac";
            txtBTotalFac.ReadOnly = true;
            txtBTotalFac.Size = new Size(77, 27);
            txtBTotalFac.TabIndex = 131;
            // 
            // txtBIvaFac
            // 
            txtBIvaFac.Location = new Point(231, 279);
            txtBIvaFac.Margin = new Padding(3, 4, 3, 4);
            txtBIvaFac.Name = "txtBIvaFac";
            txtBIvaFac.ReadOnly = true;
            txtBIvaFac.Size = new Size(77, 27);
            txtBIvaFac.TabIndex = 130;
            // 
            // txtBSubtotalFac
            // 
            txtBSubtotalFac.Location = new Point(231, 244);
            txtBSubtotalFac.Margin = new Padding(3, 4, 3, 4);
            txtBSubtotalFac.Name = "txtBSubtotalFac";
            txtBSubtotalFac.ReadOnly = true;
            txtBSubtotalFac.Size = new Size(77, 27);
            txtBSubtotalFac.TabIndex = 129;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(180, 317);
            label12.Name = "label12";
            label12.Size = new Size(45, 20);
            label12.TabIndex = 128;
            label12.Text = "Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(191, 282);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 127;
            label11.Text = "IVA:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(157, 247);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 126;
            label10.Text = "Subtotal:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 32);
            label9.Name = "label9";
            label9.Size = new Size(293, 20);
            label9.TabIndex = 125;
            label9.Text = "Para crear la factura debe buscar un cliente";
            // 
            // button3
            // 
            button3.Location = new Point(450, 67);
            button3.Name = "button3";
            button3.Size = new Size(106, 28);
            button3.TabIndex = 124;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtBnombApeClienteFacturaRegistrar
            // 
            txtBnombApeClienteFacturaRegistrar.Location = new Point(231, 67);
            txtBnombApeClienteFacturaRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBnombApeClienteFacturaRegistrar.Name = "txtBnombApeClienteFacturaRegistrar";
            txtBnombApeClienteFacturaRegistrar.Size = new Size(213, 27);
            txtBnombApeClienteFacturaRegistrar.TabIndex = 123;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 71);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 122;
            label8.Text = "Nombre del cliente:";
            // 
            // txtBmatVehFacReg
            // 
            txtBmatVehFacReg.Location = new Point(231, 174);
            txtBmatVehFacReg.Margin = new Padding(3, 4, 3, 4);
            txtBmatVehFacReg.Name = "txtBmatVehFacReg";
            txtBmatVehFacReg.ReadOnly = true;
            txtBmatVehFacReg.Size = new Size(213, 27);
            txtBmatVehFacReg.TabIndex = 121;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(111, 209);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 120;
            label7.Text = "Id reparaciones:";
            // 
            // txtBidRepFacReg
            // 
            txtBidRepFacReg.Location = new Point(231, 209);
            txtBidRepFacReg.Margin = new Padding(3, 4, 3, 4);
            txtBidRepFacReg.Name = "txtBidRepFacReg";
            txtBidRepFacReg.ReadOnly = true;
            txtBidRepFacReg.Size = new Size(213, 27);
            txtBidRepFacReg.TabIndex = 119;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 174);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 118;
            label2.Text = "Matricula vehiculo:";
            label2.Click += label2_Click;
            // 
            // bttAgregarRegistrar
            // 
            bttAgregarRegistrar.Location = new Point(409, 366);
            bttAgregarRegistrar.Name = "bttAgregarRegistrar";
            bttAgregarRegistrar.Size = new Size(147, 47);
            bttAgregarRegistrar.TabIndex = 117;
            bttAgregarRegistrar.Text = "Registrar";
            bttAgregarRegistrar.UseVisualStyleBackColor = true;
            bttAgregarRegistrar.Click += bttAgregarRegistrar_Click;
            // 
            // dTPFecFacRegistrar
            // 
            dTPFecFacRegistrar.Location = new Point(231, 136);
            dTPFecFacRegistrar.Name = "dTPFecFacRegistrar";
            dTPFecFacRegistrar.Size = new Size(290, 27);
            dTPFecFacRegistrar.TabIndex = 116;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(150, 109);
            label40.Name = "label40";
            label40.Size = new Size(75, 20);
            label40.TabIndex = 115;
            label40.Text = "Id factura:";
            // 
            // txtidFacRegistrar
            // 
            txtidFacRegistrar.Location = new Point(231, 102);
            txtidFacRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtidFacRegistrar.Name = "txtidFacRegistrar";
            txtidFacRegistrar.Size = new Size(213, 27);
            txtidFacRegistrar.TabIndex = 114;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(119, 141);
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
            clientesTabControl.Size = new Size(653, 491);
            clientesTabControl.TabIndex = 118;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 537);
            label6.Name = "label6";
            label6.Size = new Size(378, 20);
            label6.TabIndex = 119;
            label6.Text = "Selecciona una factura que deseas modificar o eliminar:";
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
        private Label label9;
        private Button button3;
        private TextBox txtBnombApeClienteFacturaRegistrar;
        private Label label8;
        private Label label10;
        private TextBox txtBTotalFac;
        private TextBox txtBIvaFac;
        private TextBox txtBSubtotalFac;
        private Label label12;
        private Label label11;
    }
}