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
        public List<TextBox> camposRellenarActualizarEliminar;
        public Form_Factura(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msf = new metodos_Sql_Factura();
            msr = new metodos_Sql_Reparacion();
            msf.DesplegarDatosFacturas(conexion, DGWFacturas);
            //msr.DesplegarDatosReparacion(Conexion, dGWReparacionFactura);
            camposRellenarActualizarEliminar = new List<TextBox>();

            camposRellenarActualizarEliminar.Add(txtBnomClienteFacActEli);
            camposRellenarActualizarEliminar.Add(txtBidFacActEli);
            camposRellenarActualizarEliminar.Add(txtBmatVehFacActEli);
            camposRellenarActualizarEliminar.Add(txtBidRepFacActEli);
            camposRellenarActualizarEliminar.Add(txtBSubFacActEli);

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
            txtBSubtotalFac.Text = reparacion.PrecioReparacion + "";
            Decimal iva = reparacion.PrecioReparacion * 0.12m;
            txtBIvaFac.Text = iva + "";
            Decimal total = reparacion.PrecioReparacion + iva;
            txtBTotalFac.Text = total + "";
        }

        private void bttAgregarRegistrar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura(txtidFacRegistrar.Text,
            txtBmatVehFacReg.Text, txtBidRepFacReg.Text, msr.idTaller,
            dTPFecFacRegistrar.Value, Decimal.Parse(txtBSubtotalFac.Text),
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

            msf.DesplegarDatosFacturas(Conexion, DGWFacturas);

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
        public string idFacturaSeleccionada;
        private void DGWFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                idFacturaSeleccionada = DGWFacturas.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            msf.ObtenerInformacionFactura(Conexion, idFacturaSeleccionada,
                camposRellenarActualizarEliminar, dTPFecEmFechaFacActEli,
                dGWReparacionFactura);

            Decimal iva = decimal.Parse(txtBSubFacActEli.Text)*0.12m;
            Decimal total = iva + Decimal.Parse(txtBSubFacActEli.Text);
            txtBivaActEli.Text = iva + "";
            txtBtotalActEli.Text = total + "";
            facturaTabControl.SelectedIndex = 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura facturaAct = new Factura(txtBnomClienteFacActEli.Text,
            txtBmatVehFacActEli.Text, txtBidRepFacActEli.Text, msr.idTaller,
            dTPFecEmFechaFacActEli.Value, Decimal.Parse(txtBSubFacActEli.Text),
            Decimal.Parse(txtBivaActEli.Text),
            Decimal.Parse(txtBtotalActEli.Text));

            if (string.IsNullOrEmpty(txtBnomClienteFacActEli.Text) ||
                string.IsNullOrEmpty(txtBmatVehFacActEli.Text) ||
                string.IsNullOrEmpty(txtBidRepFacActEli.Text) ||
                string.IsNullOrEmpty(txtBSubFacActEli.Text) ||
                string.IsNullOrEmpty(txtBivaActEli.Text) ||
                string.IsNullOrEmpty(txtBtotalActEli.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                msf.ActualizarFactura(Conexion, facturaAct);
            }

            msf.DesplegarDatosFacturas(Conexion, DGWFacturas);

        }
        public string idFacturaEliminar;
        private void button2_Click(object sender, EventArgs e)
        {
            idFacturaEliminar = txtBidFacActEli.Text;
            msf.EliminarFactura(Conexion, idFacturaEliminar);
            msf.DesplegarDatosFacturas(Conexion, DGWFacturas);
        }
    }
}
