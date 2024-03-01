using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.CLASES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDDVistas.METODOS_SQL_CONEXION
{
    public class metodos_Sql_Reparacion
    {
        public string tabla = "VISTA_REPARACION";
        public string talaCliente = "VISTA_CLIENTE";
        public string tablaVehiculo = "VISTA_VEHICULO";
        //CAMBIE SEGUN SU ROL
        public string idTaller = "TALL002";
        public void DesplegarDatosReparacion(SqlConnection conexion, DataGridView dataGridView)
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

        // Método para insertar una nueva reparación
        public void InsertarReparacion(SqlConnection conexion, Reparacion reparacion)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la inserción de datos
                SqlCommand cmd = new SqlCommand($"INSERT INTO {tabla} (NUMMATRICULA_VEHICULO, ID_REPARACION, ID_TALLER, TIPO_REPARACION, FECHA_REPARACION, OBSERVACIONES_REPARACION, PRECIO_REPARACION) " +
                                                "VALUES (@NumMatriculaVehiculo, @IdReparacion, @IdTaller, @TipoReparacion, @FechaReparacion, @ObservacionesReparacion, @PrecioReparacion)", conexion);

                // Asignar valores a los parámetros utilizando el objeto Reparacion
                cmd.Parameters.AddWithValue("@NumMatriculaVehiculo", reparacion.NumMatriculaVehiculo);
                cmd.Parameters.AddWithValue("@IdReparacion", reparacion.IdReparacion);
                cmd.Parameters.AddWithValue("@IdTaller", reparacion.IdTaller);
                cmd.Parameters.AddWithValue("@TipoReparacion", reparacion.TipoReparacion);
                cmd.Parameters.AddWithValue("@FechaReparacion", reparacion.FechaReparacion);
                cmd.Parameters.AddWithValue("@ObservacionesReparacion", reparacion.ObservacionesReparacion);
                cmd.Parameters.AddWithValue("@PrecioReparacion", reparacion.PrecioReparacion);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        // Método para obtener información de reparación por ID_REPARACION
        public void ObtenerInformacionReparacion(SqlConnection conexion, string idReparacion, List<TextBox> labels, ComboBox comboBox, DateTimePicker dtPiker, RichTextBox rTBObsRepAct)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para obtener la información de reparación
                SqlCommand cmd = new SqlCommand($"SELECT C.NUMCEDULA_CLIENTE, C.NOMBRE_CLIENTE, C.APELLIDO_CLIENTE, C.DIRECCION_CLIENTE, " +
                                                $"V.NUMMATRICULA_VEHICULO, V.FECHACOMPRA_VEHICULO, " +
                                                $"R.ID_REPARACION, R.TIPO_REPARACION, R.FECHA_REPARACION, R.PRECIO_REPARACION, R.OBSERVACIONES_REPARACION " +
                                                $"FROM {talaCliente} C " +
                                                $"JOIN {tablaVehiculo} V ON C.NOMBRE_CLIENTE = V.NOMBRE_CLIENTE AND C.APELLIDO_CLIENTE = V.APELLIDO_CLIENTE AND C.ID_TALLER = V.ID_TALLER " +
                                                $"JOIN {tabla} R ON V.NUMMATRICULA_VEHICULO = R.NUMMATRICULA_VEHICULO " +
                                                $"WHERE R.ID_REPARACION = @IdReparacion", conexion);

                // Asignar valor al parámetro
                cmd.Parameters.AddWithValue("@IdReparacion", idReparacion);

                // Ejecutar la consulta y leer los resultados
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Asignar la información a las etiquetas
                        labels[0].Text = reader["NUMCEDULA_CLIENTE"].ToString();
                        labels[1].Text = reader["NOMBRE_CLIENTE"].ToString();
                        labels[2].Text = reader["APELLIDO_CLIENTE"].ToString();
                        labels[3].Text = reader["DIRECCION_CLIENTE"].ToString();
                        labels[4].Text = reader["NUMMATRICULA_VEHICULO"].ToString();
                        labels[5].Text = reader["FECHACOMPRA_VEHICULO"].ToString();
                        labels[6].Text = reader["ID_REPARACION"].ToString();
                        comboBox.SelectedItem = reader["TIPO_REPARACION"].ToString().Trim();
                        if (DateTime.TryParse(reader["FECHA_REPARACION"].ToString(), out DateTime fechaReparacion))
                        {
                            dtPiker.Value = fechaReparacion;
                        }
                        labels[7].Text = reader["PRECIO_REPARACION"].ToString();
                        rTBObsRepAct.Text = reader["OBSERVACIONES_REPARACION"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener información de reparación: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void ActualizarReparacion(SqlConnection conexion, Reparacion reparacion)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la actualización de datos
                SqlCommand cmd = new SqlCommand($"UPDATE {tabla} SET " +
                                                "TIPO_REPARACION = @TipoReparacion, " +
                                                "FECHA_REPARACION = @FechaReparacion, " +
                                                "OBSERVACIONES_REPARACION = @ObservacionesReparacion, " +
                                                "PRECIO_REPARACION = @PrecioReparacion " +
                                                "WHERE ID_REPARACION = @IdReparacion", conexion);

                // Asignar valores a los parámetros utilizando el objeto Reparacion
                cmd.Parameters.AddWithValue("@TipoReparacion", reparacion.TipoReparacion);
                cmd.Parameters.AddWithValue("@FechaReparacion", reparacion.FechaReparacion);
                cmd.Parameters.AddWithValue("@ObservacionesReparacion", reparacion.ObservacionesReparacion);
                cmd.Parameters.AddWithValue("@PrecioReparacion", reparacion.PrecioReparacion);
                cmd.Parameters.AddWithValue("@IdReparacion", reparacion.IdReparacion);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void EliminarReparacion(SqlConnection conexion, string idReparacion)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la eliminación de datos
                SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE ID_REPARACION = @IdReparacion", conexion);

                // Asignar valor al parámetro utilizando el ID_REPARACION
                cmd.Parameters.AddWithValue("@IdReparacion", idReparacion);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();

                MessageBox.Show("Reparación eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public Reparacion ObtenerReparacionPorId(SqlConnection conexion, string idReparacion)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para obtener la información de reparación
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {tabla} WHERE ID_REPARACION = @IdReparacion", conexion);

                // Asignar valor al parámetro
                cmd.Parameters.AddWithValue("@IdReparacion", idReparacion);

                // Crear un objeto Reparacion para almacenar los resultados
                Reparacion reparacion = null;

                // Ejecutar la consulta y leer los resultados
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reparacion = new Reparacion(
                            reader["NUMMATRICULA_VEHICULO"].ToString(),
                            reader["ID_REPARACION"].ToString(),
                            reader["ID_TALLER"].ToString(),
                            reader["TIPO_REPARACION"].ToString(),
                            Convert.ToDateTime(reader["FECHA_REPARACION"]),
                            reader["OBSERVACIONES_REPARACION"].ToString(),
                            Convert.ToDecimal(reader["PRECIO_REPARACION"])
                        );
                    }
                }

                return reparacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener información de reparación: " + ex.Message);
                return null; // Return null in case of an error
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
