namespace ProyectoBDDVistas.FORMS
{
    partial class Form_ClienteInformacion
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
            dtgvInfoCliente = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvInfoCliente).BeginInit();
            SuspendLayout();
            // 
            // dtgvInfoCliente
            // 
            dtgvInfoCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvInfoCliente.Location = new Point(223, 64);
            dtgvInfoCliente.Name = "dtgvInfoCliente";
            dtgvInfoCliente.Size = new Size(497, 273);
            dtgvInfoCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(368, 22);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 1;
            label1.Text = "Información del Cliente";
            // 
            // Form_ClienteInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dtgvInfoCliente);
            Name = "Form_ClienteInformacion";
            Text = "Form_ClienteInformacion";
            ((System.ComponentModel.ISupportInitialize)dtgvInfoCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvInfoCliente;
        private Label label1;
    }
}