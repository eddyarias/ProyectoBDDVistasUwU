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

/*Firts commit*/ 

namespace ProyectoBDDVistas.FORMS
{

    public partial class Form_Cliente : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Cliente msc;
        public Cliente cliente;
        

        public string nombreActEli;
        public string apellidoActEli;

        Cliente clienteSeleccionadoActual;
        public Form_Cliente(SqlConnection conexion)
        {
            InitializeComponent();
            msc = new metodos_Sql_Cliente();
            Conexion = conexion;
        }

        private void Form_Cliente_Load(object sender, EventArgs e)
        {
            msc.DesplegarDatosClientes(Conexion, DGWClientes);
        }

        private void DGWClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Define el ancho deseado para cada columna
            int[] columnWidths = { 200, 200, 200, 200, 200 }; // Ejemplo: 4 columnas con diferentes anchos

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

        private void BAgregar_Click(object sender, EventArgs e)
        {
            cliente = new Cliente(txtBNomClienteRegistrar.Text, txtBApeClienteRegistrar.Text, msc.idTaller, txtBCedClienteRegistrar.Text, txtBDirClienteRegistrar.Text);
            msc.InsertarDatosCliente(Conexion, cliente);
            //volver a desplegar para actualizar la tabla
            msc.DesplegarDatosClientes(Conexion, DGWClientes);
            limpiarCajasTexto();
        }

        private void DGWClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                nombreActEli = DGWClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                apellidoActEli = DGWClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            clienteSeleccionadoActual = msc.ObtenerClientePorNombreApellido(Conexion, nombreActEli, apellidoActEli);
            desplegarClienteActualizarEliminar();
        }

        //desplegar el cliente seleccionado actual en captos de actualizar y eliminar
        private void desplegarClienteActualizarEliminar()
        {

            //actulizar
            txtcedAct.Text = clienteSeleccionadoActual.NumCedulaCliente.Trim();
            txtnomAct.Text = clienteSeleccionadoActual.NombreCliente.Trim();
            txtapeAct.Text = clienteSeleccionadoActual.ApellidoCliente.Trim();
            txtdirAct.Text = clienteSeleccionadoActual.DireccionCliente.Trim();

            //eliminar
            txtcedEli.Text = clienteSeleccionadoActual.NumCedulaCliente.Trim();
            txtnomEli.Text = clienteSeleccionadoActual.NombreCliente.Trim();
            txtapeEli.Text = clienteSeleccionadoActual.ApellidoCliente.Trim();
            txtdirEli.Text = clienteSeleccionadoActual.DireccionCliente.Trim();
        }

        private void limpiarCajasTexto() {
            txtBNomClienteRegistrar.Text = "";
            txtBApeClienteRegistrar.Text = "";
            txtBCedClienteRegistrar.Text = "";
            txtBDirClienteRegistrar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clienteActualizar = new Cliente(txtnomAct.Text, txtapeAct.Text, msc.idTaller, txtcedAct.Text, txtdirAct.Text);
            msc.ActualizarDatosCliente(Conexion, clienteActualizar);

            //volver a desplegar para actualizar la tabla
            msc.DesplegarDatosClientes(Conexion, DGWClientes);
        }

        private void bttEliClientes_Click(object sender, EventArgs e)
        {
            msc.EliminarClientePorNombreApellido(Conexion, txtnomEli.Text, txtapeEli.Text);
            //volver a desplegar para actualizar la tabla
            msc.DesplegarDatosClientes(Conexion, DGWClientes);
        }
    }
}
