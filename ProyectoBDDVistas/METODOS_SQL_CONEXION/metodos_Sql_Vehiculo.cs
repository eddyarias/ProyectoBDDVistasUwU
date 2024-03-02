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
    public class metodos_Sql_Vehiculo
    {
        public string tabla = "VISTA_VEHICULO";
        public string tablaReplicada = "NUMMATRICULA_VEHICULO";
        //CAMBIE SEGUN SU ROL
        public parametros parametros = new parametros();
        public string idTaller = parametros.idTaller;


        public void DesplegarDatosVehiculos(SqlConnection conexion, DataGridView dataGridView)
        {
            try
            {
                // Crear un adaptador SQL para cargar los datos
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {tabla} WHERE ID_TALLER = '{idTaller}'", conexion);
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

        // Método para desplegar vehículos por nombre y apellido del cliente
        public void desplegarVehiculoPorNombreApellidoCliente(SqlConnection conexion, DataGridView dataGridView, string nombreCliente, string apellidoCliente)
        {
            try
            {
                // Crear un comando SQL con parámetros para el nombre y apellido
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM {tabla} WHERE NOMBRE_CLIENTE = @nombreCliente AND APELLIDO_CLIENTE = @apellidoCliente", conexion);
                sqlCommand.Parameters.AddWithValue("@nombreCliente", nombreCliente);
                sqlCommand.Parameters.AddWithValue("@apellidoCliente", apellidoCliente);
               

                // Crear un adaptador SQL para cargar los datos
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                // Crear un DataTable para contener los datos
                DataTable dataTable = new DataTable();
                // Llenar el DataTable con los datos del adaptador
                sqlDataAdapter.Fill(dataTable);
                // Asignar el DataTable como DataSource del DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        // Método para obtener un vehículo por número de matrícula
        public Vehiculo ObtenerVehiculoPorMatricula(SqlConnection conexion, string numMatriculaVehiculo)
        {
            Vehiculo vehiculo = null;

            try
            {

                // Crear un comando SQL con parámetros para el número de matrícula
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM {tabla} WHERE NUMMATRICULA_VEHICULO = @numMatriculaVehiculo", conexion);
                sqlCommand.Parameters.AddWithValue("@numMatriculaVehiculo", numMatriculaVehiculo);

                // Ejecutar la consulta y leer los resultados
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Crear un objeto Vehiculo con los datos obtenidos
                        vehiculo = new Vehiculo(
                            reader["NUMMATRICULA_VEHICULO"].ToString(),
                            reader["ID_TALLER"].ToString(),
                            reader["NOMBRE_CLIENTE"].ToString(),
                            reader["APELLIDO_CLIENTE"].ToString(),
                            Convert.ToDateTime(reader["FECHACOMPRA_VEHICULO"])
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                MessageBox.Show("Error al obtener vehículo: " + ex.Message);
            }

            return vehiculo;
        }

        public void InsertarDatosVehiculo(SqlConnection conexion, Vehiculo vehiculo)
        {
            try
            {
                // Crear el comando SQL para la inserción de datos
                SqlCommand cmd = new SqlCommand($"INSERT INTO {tabla} (NUMMATRICULA_VEHICULO, ID_TALLER, NOMBRE_CLIENTE, APELLIDO_CLIENTE, FECHACOMPRA_VEHICULO) VALUES (@NumMatriculaVehiculo, @IdTaller, @NombreCliente, @ApellidoCliente, @FechaCompraVehiculo); SELECT CAST(dbo.fn_VehiculoExiste(@NumMatriculaVehiculo) AS INT) AS VehiculoExiste", conexion);

                // Asignar valores a los parámetros utilizando el objeto Vehiculo
                cmd.Parameters.AddWithValue("@NumMatriculaVehiculo", vehiculo.NumMatriculaVehiculo);
                cmd.Parameters.AddWithValue("@IdTaller", vehiculo.IdTaller);
                cmd.Parameters.AddWithValue("@NombreCliente", vehiculo.NombreCliente);
                cmd.Parameters.AddWithValue("@ApellidoCliente", vehiculo.ApellidoCliente);
                cmd.Parameters.AddWithValue("@FechaCompraVehiculo", vehiculo.FechaCompraVehiculo);

                // Ejecutar la consulta y obtener el resultado
                int vehiculoExiste = (int)cmd.ExecuteScalar();

                // Verificar si el vehículo ya existe
                if (vehiculoExiste == 1)
                {
                    MessageBox.Show("El vehículo con esa matrícula ya existe en uno de los nodos Quito o Guayaquil");
                }
                else
                {
                    MessageBox.Show("Vehículo registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }




        public void ActualizarDatosVehiculo(SqlConnection conexion, Vehiculo vehiculo)
        {
            try
            {
                // Crear el comando SQL para la actualización de datos
                SqlCommand cmd = new SqlCommand($"UPDATE {tabla} SET FECHACOMPRA_VEHICULO = @FechaCompraVehiculo WHERE NUMMATRICULA_VEHICULO = @NumMatriculaVehiculo", conexion);

                // Asignar valores a los parámetros utilizando el objeto Vehiculo
                cmd.Parameters.AddWithValue("@NumMatriculaVehiculo", vehiculo.NumMatriculaVehiculo);
                cmd.Parameters.AddWithValue("@FechaCompraVehiculo", vehiculo.FechaCompraVehiculo);

                // Ejecutar la consulta
                int rowsAffected = cmd.ExecuteNonQuery();

                // Mostrar mensaje de confirmación después de la actualización
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Datos del vehículo actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
        }

        public void EliminarVehiculoPorNumMatricula(SqlConnection conexion, string numMatriculaVehiculo)
        {
            try
            {
                // Crear el comando SQL para la eliminación de datos
                SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE NUMMATRICULA_VEHICULO = @NumMatriculaVehiculo", conexion);

                // Asignar valor al parámetro
                cmd.Parameters.AddWithValue("@NumMatriculaVehiculo", numMatriculaVehiculo);

                // Ejecutar la consulta
                int rowsAffected = cmd.ExecuteNonQuery();

                // Mostrar mensaje de confirmación después de la eliminación
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Vehículo eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos del vehículo: " + ex.Message);
            }
        }

        public void DesplegarPlacaMatriculaVehiculos(SqlConnection conexion, DataGridView dataGridView)
        {
            try
            {
                // Crear un adaptador SQL para cargar los datos
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT {tablaReplicada} FROM {tabla}", conexion);
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



    }
}

