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
        public string tablaVehiculo = "VISTA_VEHICULO";
        public string tablaCliente = "VISTA_CLIENTE";
        public string tablaReparacion = "VISTA_REPARACION";
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


                MessageBox.Show("Factura insertada correctamente.");
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


        public void ObtenerInformacionFactura(SqlConnection conexion, string idFactura, List<TextBox> textBoxes, DateTimePicker dateTimePicker, DataGridView dataGridView)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para obtener la información de la factura
                SqlCommand cmd = new SqlCommand($"SELECT C.NOMBRE_CLIENTE, C.APELLIDO_CLIENTE, F.ID_FACTURA, F.NUMMATRICULA_VEHICULO, F.ID_REPARACION, R.PRECIO_REPARACION, F.FECHAEMISION_FACTURA " +
                                                $"FROM {tabla} F " +
                                                $"JOIN {tablaVehiculo} V ON F.NUMMATRICULA_VEHICULO = V.NUMMATRICULA_VEHICULO " +
                                                $"JOIN {tablaCliente} C ON V.NOMBRE_CLIENTE = C.NOMBRE_CLIENTE AND V.APELLIDO_CLIENTE = C.APELLIDO_CLIENTE AND V.ID_TALLER = C.ID_TALLER " +
                                                $"JOIN {tablaReparacion} R ON F.ID_REPARACION = R.ID_REPARACION " +
                                                $"WHERE F.ID_FACTURA = @IdFactura", conexion);

                // Asignar valor al parámetro
                cmd.Parameters.AddWithValue("@IdFactura", idFactura);

                // Ejecutar la consulta y leer los resultados
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Asignar la información a los controles
                        textBoxes[0].Text = $"{reader["NOMBRE_CLIENTE"]} {reader["APELLIDO_CLIENTE"]}";
                        textBoxes[1].Text = reader["ID_FACTURA"].ToString();
                        dateTimePicker.Value = Convert.ToDateTime(reader["FECHAEMISION_FACTURA"]);
                        textBoxes[2].Text = reader["NUMMATRICULA_VEHICULO"].ToString();
                        textBoxes[3].Text = reader["ID_REPARACION"].ToString();
                        textBoxes[4].Text = reader["PRECIO_REPARACION"].ToString();
                    }
                }

                // Cargar detalles de la factura en el DataGridView (puedes ajustar esta parte según tu estructura)
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM DetallesFactura WHERE ID_FACTURA = @IdFactura", conexion);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@IdFactura", idFactura);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener información de la factura: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void ActualizarFactura(SqlConnection conexion, Factura factura)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la actualización de datos
                SqlCommand cmd = new SqlCommand($"UPDATE {tabla} SET " +
                                                "NUMMATRICULA_VEHICULO = @NumMatriculaVehiculo, " +
                                                "ID_REPARACION = @IdReparacion, " +
                                                "ID_TALLER = @IdTaller, " +
                                                "FECHAEMISION_FACTURA = @FechaEmisionFactura, " +
                                                "SUBTOTAL_FACTURA = @SubtotalFactura, " +
                                                "IVA_FACTURA = @IvaFactura, " +
                                                "TOTAL_FACTURA = @TotalFactura " +
                                                "WHERE ID_FACTURA = @IdFactura", conexion);

                // Asignar valores a los parámetros utilizando el objeto Factura
                cmd.Parameters.AddWithValue("@NumMatriculaVehiculo", factura.NumMatriculaVehiculo);
                cmd.Parameters.AddWithValue("@IdReparacion", factura.IdReparacion);
                cmd.Parameters.AddWithValue("@IdTaller", factura.IdTaller);
                cmd.Parameters.AddWithValue("@FechaEmisionFactura", factura.FechaEmisionFactura);
                cmd.Parameters.AddWithValue("@SubtotalFactura", factura.SubtotalFactura);
                cmd.Parameters.AddWithValue("@IvaFactura", factura.IvaFactura);
                cmd.Parameters.AddWithValue("@TotalFactura", factura.TotalFactura);
                cmd.Parameters.AddWithValue("@IdFactura", factura.IdFactura);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Factura actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna factura con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos de la factura: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void EliminarFactura(SqlConnection conexion, string idFactura)
        {
            try
            {
                // Pregunta al usuario antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta factura?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    // Crear el comando SQL para la eliminación de datos
                    SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE ID_FACTURA = @IdFactura", conexion);

                    // Asignar valor al parámetro utilizando el ID_FACTURA
                    cmd.Parameters.AddWithValue("@IdFactura", idFactura);

                    // Ejecutar la consulta
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Factura eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna factura con el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos de la factura: " + ex.Message);
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
