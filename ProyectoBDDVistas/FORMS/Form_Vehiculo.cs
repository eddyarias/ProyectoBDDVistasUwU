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
    public partial class Form_Vehiculo : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Vehiculo msv;
        public Vehiculo vehiculo;

        //variables para el evento seleccionar tabla clientes
        public string nombreClienteVehiculoR;
        public string apellidoClienteVehiculoR;
        public metodos_Sql_Cliente msc;

        public Form_Vehiculo(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msv = new metodos_Sql_Vehiculo();
            msc = new metodos_Sql_Cliente();

            msc.DesplegarDatosClientes(Conexion, DGWClientes);
            msv.DesplegarDatosVehiculos(conexion, DGWVEHICULO);
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            vehiculo = new Vehiculo(txtBNMatriculaVehiculoR.Text, msv.idTaller, txtBNombreVehiculoR.Text, txtBApellidoVehiculoR.Text, DateTime.Parse(dTPFechaCompraVehiculoR.Text));
            msv.InsertarDatosVehiculo(Conexion, vehiculo);
            //volver a desplegar para actualizar la tabla
            msv.DesplegarDatosVehiculos(Conexion, DGWVEHICULO);
            limpiarCajasTextoRegistrarVehiculo();
        }


        private void limpiarCajasTextoRegistrarVehiculo()
        {
            txtBApellidoVehiculoR.Text = "";
            txtBNombreVehiculoR.Text = "";
            txtBNMatriculaVehiculoR.Text = "";
            dTPFechaCompraVehiculoR.Text = "";
        }

        private void dGWCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                nombreClienteVehiculoR = DGWClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                apellidoClienteVehiculoR = DGWClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            txtBNombreVehiculoR.Text = nombreClienteVehiculoR;
            txtBApellidoVehiculoR.Text = apellidoClienteVehiculoR;

            //clienteSeleccionadoActual = msc.ObtenerClientePorNombreApellido(Conexion, nombreClienteVehiculoR, apellidoClienteVehiculoR);
            //desplegarClienteActualizarEliminar(); 
        }

        private void DGWVEHICULO_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Define el ancho deseado para cada columna
            int[] columnWidths = { 250, 200, 300, 250, 300 }; // Ejemplo: 4 columnas con diferentes anchos

            // Asegúrate de que el número de elementos en columnWidths coincida con el número de columnas en el DataGridView
            if (columnWidths.Length != DGWVEHICULO.Columns.Count)
            {
                MessageBox.Show("El número de anchos de columna no coincide con el número de columnas en el DataGridView.");
                return;
            }

            // Establece el ancho deseado para cada columna
            for (int i = 0; i < DGWVEHICULO.Columns.Count; i++)
            {
                DGWVEHICULO.Columns[i].Width = columnWidths[i];
            }
        }

        private void DGWClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Define el ancho deseado para cada columna
            int[] columnWidths = { 200, 200, 100, 150, 220 }; // Ejemplo: 4 columnas con diferentes anchos

            // Asegúrate de que el número de elementos en columnWidths coincida con el número de columnas en el DataGridView
            if (columnWidths.Length != DGWClientes.Columns.Count)
            {
                MessageBox.Show("El número de anchos de columna no coincide con el número de columnas en el DataGridView.");
                return;
            }

            // Establece el ancho deseado para cada columna
            for (int i = 0; i < DGWClientes.Columns.Count; i++)
            {
                DGWClientes.Columns[i].Width = columnWidths[i];
            }
        }

        ////desplegar el cliente seleccionado actual en captos de actualizar y eliminar
        //private void desplegarClienteActualizarEliminar()
        //{

        //    //actulizar
        //    txtcedAct.Text = clienteSeleccionadoActual.NumCedulaCliente.Trim();
        //    txtnomAct.Text = clienteSeleccionadoActual.NombreCliente.Trim();
        //    txtapeAct.Text = clienteSeleccionadoActual.ApellidoCliente.Trim();
        //    txtdirAct.Text = clienteSeleccionadoActual.DireccionCliente.Trim();

        //    //eliminar
        //    txtcedEli.Text = clienteSeleccionadoActual.NumCedulaCliente.Trim();
        //    txtnomEli.Text = clienteSeleccionadoActual.NombreCliente.Trim();
        //    txtapeEli.Text = clienteSeleccionadoActual.ApellidoCliente.Trim();
        //    txtdirEli.Text = clienteSeleccionadoActual.DireccionCliente.Trim();
        //}
    }
}
