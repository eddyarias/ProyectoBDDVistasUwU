using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.METODOS_SQL_CONEXION;
using ProyectoBDDVistas.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace ProyectoBDDVistas.FORMS
{
    public partial class Form_Factura : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Factura msf;
        public metodos_Sql_Reparacion msr;
        public Form_Factura(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msf = new metodos_Sql_Factura();
            msr = new metodos_Sql_Reparacion();
            msf.DesplegarDatosFacturas(conexion, DGWFacturas);
            //msr.DesplegarDatosReparacion(Conexion, dGWReparacionFactura);
        }

        private void DGWFacturas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWFacturas.AutoResizeColumns();
            DGWFacturas.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWFacturas.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWFacturas.RowHeadersWidth + 3 - 950;
            int height = DGWFacturas.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWFacturas.ColumnHeadersHeight + 3;

            DGWFacturas.ClientSize = new Size(width, height);
            DGWFacturas.Columns[0].Width = 100;
        }

        public string idReparacion;
        private void dGWReparacionFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                idReparacion = dGWReparacionFactura.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            Reparacion reparacion = msr.ObtenerReparacionPorId(Conexion, idReparacion);
            txtBidRepFacReg.Text = reparacion.IdReparacion;
            txtBmatVehFacReg.Text = reparacion.NumMatriculaVehiculo;
            //si son mas de 1 factura tocaria cambiar la logica de aqui hacia abajo
            txtBSubtotalFac.Text = reparacion.PrecioReparacion+"";
            Decimal iva = reparacion.PrecioReparacion * 0.12m;
            txtBIvaFac.Text = iva+"";
            Decimal total = reparacion.PrecioReparacion + iva;
            txtBTotalFac.Text = total+ "";
        }

        private void bttAgregarRegistrar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura(txtidFacRegistrar.Text, 
            txtBmatVehFacReg.Text,txtBidRepFacReg.Text,msr.idTaller,
            dTPFecFacRegistrar.Value,Decimal.Parse(txtBSubtotalFac.Text),
            Decimal.Parse(txtBIvaFac.Text), 
            Decimal.Parse(txtBTotalFac.Text));

            if (string.IsNullOrEmpty(txtidFacRegistrar.Text) ||
                string.IsNullOrEmpty(txtBmatVehFacReg.Text) ||
                string.IsNullOrEmpty(txtBidRepFacReg.Text) ||
                string.IsNullOrEmpty(txtBSubtotalFac.Text) ||
                string.IsNullOrEmpty(txtBIvaFac.Text) ||
                string.IsNullOrEmpty(txtBTotalFac.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                msf.InsertarFactura(Conexion, factura);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string nombreCompleto;
        public string nombreRegistrar;
        public string apellidoRegistrar;

        private void button3_Click(object sender, EventArgs e)
        {
            nombreCompleto = txtBnombApeClienteFacturaRegistrar.Text;
            string[] nombreYApellido = nombreCompleto.Split(' ');
            if (nombreYApellido.Length >= 2)
            {
                nombreRegistrar = nombreYApellido[0].PadRight(30);
                apellidoRegistrar = nombreYApellido[1].PadRight(30);
            }
                msr.ObtenerReparacionesPorClienteYMostrarEnGridView(Conexion, nombreRegistrar, apellidoRegistrar, dGWReparacionFactura);
                dGWReparacionFactura.Enabled = true;
        }
    }
}
