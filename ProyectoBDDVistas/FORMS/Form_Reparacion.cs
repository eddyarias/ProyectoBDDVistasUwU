using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.CLASES;
using ProyectoBDDVistas.METODOS_SQL_CONEXION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDDVistas.FORMS
{
    public partial class Form_Reparacion : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Reparacion msr;
        public metodos_Sql_Cliente msc;
        public metodos_Sql_Vehiculo msv;

        public string nombreCli;
        public string apellidoCli;
        Cliente clienteSeleccionadoRegistro;

        public string numMatricula;
        Vehiculo vehiculo;
        Vehiculo vehiculoAct;
        public List<TextBox> camposRellenarActualizarEliminar;

        Reparacion reparacionInsertar;
        public string idReparacionActEli;

        public Form_Reparacion(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msr = new metodos_Sql_Reparacion();
            msr.DesplegarDatosReparacion(Conexion, DGWReparacion);

            msc = new metodos_Sql_Cliente();
            msc.DesplegarDatosClientes(Conexion, dGWClienteRegistro);
            msc.DesplegarDatosClientes(Conexion, dGWClienteRepAct);

            msv = new metodos_Sql_Vehiculo();
            //msv.DesplegarDatosVehiculos(Conexion, dGWVehiculoRegistrar);
            //msv.DesplegarDatosVehiculos(Conexion, dGWVehiculoAct);
            camposRellenarActualizarEliminar = new List<TextBox>();

            camposRellenarActualizarEliminar.Add(txtBCedClienteReparacionAct);
            camposRellenarActualizarEliminar.Add(txtBNomClienteReparacionAct);
            camposRellenarActualizarEliminar.Add(txtBApeClienteReparacionAct);
            camposRellenarActualizarEliminar.Add(txtBDirClienteReparacionAct);
            camposRellenarActualizarEliminar.Add(txtBNumMatVehiculoAct);
            camposRellenarActualizarEliminar.Add(txtBFecVehiculoReparacionAct);
            camposRellenarActualizarEliminar.Add(txtBidRepAct);
            //camposRellenarActualizarEliminar.Add(cBTipoRepaAct);
            //camposRellenarActualizarEliminar.Add(dTPFecRepAct);
            camposRellenarActualizarEliminar.Add(txtBPreRepAct);
            //camposRellenarActualizarEliminar.Add(rTBObsRepAct);
        }

        private void DGWReparacion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWReparacion.AutoResizeColumns();
            DGWReparacion.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWReparacion.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWReparacion.RowHeadersWidth + 3;
            int height = DGWReparacion.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWReparacion.ColumnHeadersHeight + 3;

            DGWReparacion.ClientSize = new Size(width, height);
        }

        private void bttAgregarRegistrar_Click(object sender, EventArgs e)
        {
            reparacionInsertar = new Reparacion(txtBNumMatRepRegistro.Text, txtidRepRegistrar.Text,
                msr.idTaller, cBTipoRepRegistrar.Text, dTPFecRepRegistrar.Value, rTBObseRepRegistrar.Text,
                Decimal.Parse(txtPreRepRegistrar.Text));
            msr.InsertarReparacion(Conexion, reparacionInsertar);
            //actualizar tabla con nueva insercion 
            msr.DesplegarDatosReparacion(Conexion, DGWReparacion);

        }

        private void dGWClienteRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                nombreCli = dGWClienteRegistro.Rows[e.RowIndex].Cells[0].Value.ToString();
                apellidoCli = dGWClienteRegistro.Rows[e.RowIndex].Cells[1].Value.ToString();
                msv.desplegarVehiculoPorNombreApellidoCliente(Conexion, dGWVehiculoRegistrar,
                dGWClienteRegistro.Rows[e.RowIndex].Cells[0].Value.ToString(),
                dGWClienteRegistro.Rows[e.RowIndex].Cells[1].Value.ToString());
                limipiarCamposVehiculo();
            }
            clienteSeleccionadoRegistro = msc.ObtenerClientePorNombreApellido(Conexion, nombreCli, apellidoCli);
            desplegarClienteSeleccionadoRegistro();

            panel10.Enabled = true;

        }
        public void limipiarCamposVehiculo()
        {
            txtBNumMatRepRegistro.Text = "";
            txtBFecVehRepRegistrar.Text = "";
        }

        public void desplegarClienteSeleccionadoRegistro()
        {
            txtBCedClienteReparacionRegistro.Text = clienteSeleccionadoRegistro.NumCedulaCliente.Trim();
            txtBnomClienteReparacionRegistro.Text = clienteSeleccionadoRegistro.NombreCliente.Trim();
            txtBApeClienteReparacionRegistro.Text = clienteSeleccionadoRegistro.ApellidoCliente.Trim();
            txtBDirClienteReparacionRegistro.Text = clienteSeleccionadoRegistro.DireccionCliente.Trim();

        }

        private void dGWVehiculoRegistrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                numMatricula = dGWVehiculoRegistrar.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            vehiculo = msv.ObtenerVehiculoPorMatricula(Conexion, numMatricula);
            if (vehiculo == null)
            {
                MessageBox.Show("El cliente no tiene vehiculos guardados en el sistema");

            }
            else
            {
                txtBNumMatRepRegistro.Text = vehiculo.NumMatriculaVehiculo.Trim();
                txtBFecVehRepRegistrar.Text = vehiculo.FechaCompraVehiculo + "".Trim();
            }

        }

        private void DGWReparacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                idReparacionActEli = DGWReparacion.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            msr.ObtenerInformacionReparacion(Conexion, idReparacionActEli, camposRellenarActualizarEliminar, cBTipoRepaAct, dTPFecRepAct, rTBObsRepAct);
        }

        private void bttAct_Click(object sender, EventArgs e)
        {
            Reparacion reparacionActualizacion = new Reparacion(txtBNumMatVehiculoAct.Text, txtBidRepAct.Text,
                msr.idTaller, cBTipoRepaAct.Text, dTPFecRepAct.Value, rTBObsRepAct.Text, Decimal.Parse(txtBPreRepAct.Text));

            msr.ActualizarReparacion(Conexion, reparacionActualizacion);

            //actualizar tabla
            msr.DesplegarDatosReparacion(Conexion, DGWReparacion);
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            Reparacion reparacionEliminar = new Reparacion(txtBNumMatVehiculoAct.Text, txtBidRepAct.Text,
            msr.idTaller, cBTipoRepaAct.Text, dTPFecRepAct.Value, rTBObsRepAct.Text, Decimal.Parse(txtBPreRepAct.Text));

            msr.EliminarReparacion(Conexion, reparacionEliminar.IdReparacion.Trim());

            //actualizar tabla
            msr.DesplegarDatosReparacion(Conexion, DGWReparacion);
        }

        private void dGWClienteRepAct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                nombreCli = dGWClienteRepAct.Rows[e.RowIndex].Cells[0].Value.ToString();
                apellidoCli = dGWClienteRepAct.Rows[e.RowIndex].Cells[1].Value.ToString();
                msv.desplegarVehiculoPorNombreApellidoCliente(Conexion, dGWVehRepAct,
                dGWClienteRepAct.Rows[e.RowIndex].Cells[0].Value.ToString(),
                dGWClienteRepAct.Rows[e.RowIndex].Cells[1].Value.ToString());
                limipiarCamposVehiculoAct();
            }
            clienteSeleccionadoRegistro = msc.ObtenerClientePorNombreApellido(Conexion, nombreCli, apellidoCli);
            desplegarClienteSeleccionadoRegistroAct();

            panel7.Enabled = true;
        }

        public void desplegarClienteSeleccionadoRegistroAct()
        {
            txtBCedClienteReparacionAct.Text = clienteSeleccionadoRegistro.NumCedulaCliente.Trim();
            txtBCedClienteReparacionAct.Text = clienteSeleccionadoRegistro.NombreCliente.Trim();
            txtBApeClienteReparacionAct.Text = clienteSeleccionadoRegistro.ApellidoCliente.Trim();
            txtBDirClienteReparacionAct.Text = clienteSeleccionadoRegistro.DireccionCliente.Trim();

        }

        public void limipiarCamposVehiculoAct()
        {
            txtBNumMatVehiculoAct.Text = "";
            txtBFecVehiculoReparacionAct.Text = "";
        }

        private void dGWVehRepAct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                numMatricula = dGWVehRepAct.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            vehiculoAct = msv.ObtenerVehiculoPorMatricula(Conexion, dGWVehRepAct.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (vehiculo == null)
            {
                MessageBox.Show("El cliente no tiene vehiculos guardados en el sistema");

            }
            else
            {
                txtBNumMatVehiculoAct.Text = vehiculoAct.NumMatriculaVehiculo.Trim();
                txtBFecVehiculoReparacionAct.Text = vehiculoAct.FechaCompraVehiculo + "".Trim();
            }
        }
    }
}
