using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.CLASES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.METODOS_SQL_CONEXION
{
    public class metodos_Sql_Factura
    {
        public string tabla = "VISTA_FACTURA";
        //CAMBIE SEGUN SU ROL
        public string idTaller = "TALL002";

        public void DesplegarDatosFacturas(SqlConnection conexion, DataGridView dataGridView)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                // Crear un adaptador SQL para cargar los datos
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tabla + "", conexion);
                // Crear un DataTable para contener los datos
                DataTable dataTable = new DataTable();
                // Llenar el DataTable con los datos del adaptador
                sqlDataAdapter.Fill(dataTable);
                // Asignar el DataTable como DataSource del DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción aquí
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        public void InsertarFactura(SqlConnection conexion, Factura factura)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la inserción de datos
                SqlCommand cmd = new SqlCommand($"INSERT INTO {tabla} (ID_FACTURA, NUMMATRICULA_VEHICULO, ID_REPARACION, ID_TALLER, FECHAEMISION_FACTURA, SUBTOTAL_FACTURA, IVA_FACTURA, TOTAL_FACTURA) " +
                                                "VALUES (@IdFactura, @NumMatriculaVehiculo, @IdReparacion, @IdTaller, @FechaEmisionFactura, @SubtotalFactura, @IvaFactura, @TotalFactura)", conexion);

                // Asignar valores a los parámetros utilizando el objeto Factura
                cmd.Parameters.AddWithValue("@IdFactura", factura.IdFactura);
                cmd.Parameters.AddWithValue("@NumMatriculaVehiculo", factura.NumMatriculaVehiculo);
                cmd.Parameters.AddWithValue("@IdReparacion", factura.IdReparacion);
                cmd.Parameters.AddWithValue("@IdTaller", factura.IdTaller);
                cmd.Parameters.AddWithValue("@FechaEmisionFactura", factura.FechaEmisionFactura);
                cmd.Parameters.AddWithValue("@SubtotalFactura", factura.SubtotalFactura);
                cmd.Parameters.AddWithValue("@IvaFactura", factura.IvaFactura);
                cmd.Parameters.AddWithValue("@TotalFactura", factura.TotalFactura);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos en la factura: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
