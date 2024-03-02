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
    public class metodos_Sql_Empleado
    {
        public string tabla = "VISTA_EMPLEADO";
        public string tabla2 = "VISTA_NUMEROTELEFONO";
        //CAMBIE SEGUN SU ROL
        public string idTaller = "TALL001";

        public void DesplegarDatosEmpleados(SqlConnection conexion, DataGridView dataGridView)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                // Crear un adaptador SQL para cargar los datos
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {tabla}", conexion);
                // Crear un DataTable para contener los datos
                DataTable dataTable = new DataTable();
                // Llenar el DataTable con los datos del adaptador
                sqlDataAdapter.Fill(dataTable);
                // Asignar el DataTable como DataSource del DataGridView
                dataGridView.DataSource = dataTable;
                // Configurar el DataGridView


            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción aquí
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        public void InsertarDatosEmpleado(SqlConnection conexion, Empleado empleado)
        {
            try
            {

               

            
                // Crear el comando SQL para la inserción de datos
                SqlCommand cmd = new SqlCommand($"INSERT INTO {tabla} (ID_EMPLEADO, ID_TALLER, NUMCED_EMPLEADO, NOMBRE_EMPLEADO, APELLIDO_EMPLEADO, SALARIO_EMPLEADO, FECHAINICIOCONTRATO_EMPLEADO) VALUES (@IdEmpleado, @IdTaller, @NumCedEmpleado, @NombreEmpleado, @ApellidoEmpleado, @SalarioEmpleado, @FechaInicioContratoEmpleado)", conexion);

                // Asignar valores a los parámetros utilizando el objeto Empleado
                cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdTaller", empleado.IdTaller);
                cmd.Parameters.AddWithValue("@NumCedEmpleado", empleado.NumCedulaEmpleado);
                cmd.Parameters.AddWithValue("@NombreEmpleado", empleado.NombreEmpleado);
                cmd.Parameters.AddWithValue("@ApellidoEmpleado", empleado.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@SalarioEmpleado", empleado.SalarioEmpleado);
                cmd.Parameters.AddWithValue("@FechaInicioContratoEmpleado", empleado.FechaInicioContratoEmpleado);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
                 }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }

        }

        public void ActualizarDatosEmpleado(SqlConnection conexion, Empleado empleado)
        {
            try
            {
               
                SqlCommand cmd = new SqlCommand($"UPDATE {tabla} SET NUMCED_EMPLEADO = @NumCedEmpleado, NOMBRE_EMPLEADO = @NombreEmpleado, APELLIDO_EMPLEADO = @ApellidoEmpleado, SALARIO_EMPLEADO = @SalarioEmpleado, FECHAINICIOCONTRATO_EMPLEADO = @FechaInicioContratoEmpleado WHERE ID_EMPLEADO = @IdEmpleado AND ID_TALLER = @IdTaller", conexion);

                // Asignar valores a los parámetros utilizando el objeto Empleado
                cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdTaller", empleado.IdTaller);
                cmd.Parameters.AddWithValue("@NumCedEmpleado", empleado.NumCedulaEmpleado);
                cmd.Parameters.AddWithValue("@NombreEmpleado", empleado.NombreEmpleado);
                cmd.Parameters.AddWithValue("@ApellidoEmpleado", empleado.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@SalarioEmpleado", empleado.SalarioEmpleado);
                cmd.Parameters.AddWithValue("@FechaInicioContratoEmpleado", empleado.FechaInicioContratoEmpleado);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }

        }

        /// <summary>
        /// Es necesario recibir el idEmpleado e idTaller??
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="idEmpleado"></param>
        /// <param name="idTaller"></param>
        public void EliminarDatosEmpleado(SqlConnection conexion, string idEmpleado)
        {
            
            try
            {


                // Confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado con id: "+idEmpleado+"?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Crear el comando SQL para la eliminación de datos
                    SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE ID_EMPLEADO = @IdEmpleado", conexion);

                    // Asignar valores a los parámetros utilizando el ID_EMPLEADO
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    // Ejecutar la consulta
                    int rowsAffected = cmd.ExecuteNonQuery();
                    // Crear el comando SQL para la eliminación del número de teléfono
                    SqlCommand cmdTelefono = new SqlCommand("DELETE FROM NUMEROTELEFONO_01 WHERE ID_EMPLEADO = @IdEmpleado", conexion);

                    // Asignar valores a los parámetros utilizando el ID_EMPLEADO
                    cmdTelefono.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    // Ejecutar la consulta de eliminación del número de teléfono
                    int rowsAffectedTelefono = cmdTelefono.ExecuteNonQuery();

                    // Confirmación después de eliminar
             

                    // Confirmación después de eliminar
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado para eliminar.", "Eliminación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos: " + ex.Message);
            }

        }
    
        public Empleado BuscarEmpleadoPorId(SqlConnection conexion, string idEmpleado)
        {
            Empleado empleado = null;

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand cmd = new SqlCommand($"SELECT * FROM {tabla} WHERE ID_EMPLEADO = @IdEmpleado", conexion);
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {tabla}", conexion);

                // Asignar valor al parámetro
                cmd.Parameters.AddWithValue("@IdTaller", idTaller);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                // Ejecutar la consulta y leer los resultados
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        empleado = new Empleado(
                            reader["ID_EMPLEADO"].ToString(),
                            reader["ID_TALLER"].ToString(),
                            reader["NUMCED_EMPLEADO"].ToString(),
                            reader["NOMBRE_EMPLEADO"].ToString(),
                            reader["APELLIDO_EMPLEADO"].ToString(),
                            Convert.ToDecimal(reader["SALARIO_EMPLEADO"]),
                            Convert.ToDateTime(reader["FECHAINICIOCONTRATO_EMPLEADO"])
                            
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos del empleado: " + ex.Message);
            }
            finally
            {
                // Es buena práctica cerrar la conexión después de usarla
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return empleado;
        }


    }
}
