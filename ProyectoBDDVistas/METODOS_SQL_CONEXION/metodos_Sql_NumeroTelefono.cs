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
    public class metodos_Sql_NumeroTelefono
    {
        public string tabla = "VISTA_NUMEROTELEFONO";
        public string tablaEmpleado = "VISTA_EMPLEADO";

        //CAMBIE SEGUN SU ROL
        public string idTaller = "TALL002";

        public void DesplegarDatosNumeroTelefono(SqlConnection conexion, DataGridView dataGridView)
        {
            try
            {
                // Crear un adaptador SQL para cargar los datos
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {tabla} WHERE ID_TALLER = {idTaller}", conexion);
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

        public void AgregarNumeroTelefono(SqlConnection conexion, NumeroTelefono numeroTelefono)
        {
            try
            {
                // Crear el comando SQL para la inserción de datos
                SqlCommand cmd = new SqlCommand($"INSERT INTO {tabla} (ID_EMPLEADO, NUMEROTELEFONO, ID_TALLER) " +
                                                "VALUES (@IdEmpleado, @NumeroTelefono, @IdTaller)", conexion);

                // Asignar valores a los parámetros utilizando el objeto NumeroTelefono
                cmd.Parameters.AddWithValue("@IdEmpleado", numeroTelefono.IdEmpleado);
                cmd.Parameters.AddWithValue("@NumeroTelefono", numeroTelefono.NumeroTelefonico);
                cmd.Parameters.AddWithValue("@IdTaller", numeroTelefono.IdTaller);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();

                MessageBox.Show("Número de teléfono agregado correctamente" );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar número de teléfono: " + ex.Message);
            }
        }
        /*No se puede actaulizar porque todo es clave primaria*//*
        public void ActualizarNumeroTelefono(SqlConnection conexion, NumeroTelefono numeroTelefono)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la actualización de datos
                SqlCommand cmd = new SqlCommand($"UPDATE {tabla} SET NUMERO_TELEFONO = @NumeroTelefono " +
                                                "WHERE ID_EMPLEADO = @IdEmpleado AND ID_TALLER = @IdTaller", conexion);

                // Asignar valores a los parámetros utilizando el objeto NumeroTelefono
                cmd.Parameters.AddWithValue("@NumeroTelefono", numeroTelefono.NumeroTelefonico);
                cmd.Parameters.AddWithValue("@IdEmpleado", numeroTelefono.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdTaller", numeroTelefono.IdTaller);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();

                MessageBox.Show("Número de teléfono actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar número de teléfono: " + ex.Message);
            }
        }*/

        public void EliminarNumeroTelefono(SqlConnection conexion, NumeroTelefono numeroTelefono)
        {
            try
            {

                // Antes de eliminar, mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el número de teléfono "+numeroTelefono+"?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Crear el comando SQL para la eliminación de datos
                    SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE ID_EMPLEADO = @IdEmpleado AND ID_TALLER = @IdTaller AND NUMEROTELEFONO = @NumTelefono", conexion);

                    // Asignar valores a los parámetros utilizando el ID_EMPLEADO
                    cmd.Parameters.AddWithValue("@IdEmpleado", numeroTelefono.IdEmpleado);
                    cmd.Parameters.AddWithValue("@IdTaller", numeroTelefono.IdTaller); 
                    cmd.Parameters.AddWithValue("@NumTelefono", numeroTelefono.NumeroTelefonico);
                    // Ejecutar la consulta
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Mostrar mensaje de confirmación después de la eliminación
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Número de telefono con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el número de telefono para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar número de teléfono: " + ex.Message);
            }

        }
        public void MostrarInformacionEmpleado(SqlConnection conexion, string idEmpleado, TextBox textBoxInfoEmpleado, TextBox textBoxNombreApellido, TextBox textBoxNumTelefono)
        {
            try
            {

                // Crear el comando SQL para obtener la información del empleado y su número de teléfono
                SqlCommand cmd = new SqlCommand($"SELECT E.ID_EMPLEADO, E.NOMBRE_EMPLEADO, E.APELLIDO_EMPLEADO, N.NUMEROTELEFONO " +
                                                $"FROM {tablaEmpleado} E " +
                                                $"JOIN {tabla} N ON E.ID_EMPLEADO = N.ID_EMPLEADO " +
                                                $"WHERE E.ID_EMPLEADO = @IdEmpleado", conexion);/* AND N.ID_TALLER ={idTaller}*/

                // Asignar valores a los parámetros
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@IdTaller", idTaller);

                // Ejecutar la consulta y leer los resultados
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Asignar la información a los TextBox
                        textBoxInfoEmpleado.Text = $"{reader["ID_EMPLEADO"]}";
                        string nombre = $"{reader["NOMBRE_EMPLEADO"]}";
                        string apellido = $"{ reader["APELLIDO_EMPLEADO"] }";
                        textBoxNombreApellido.Text = nombre.Trim()+" "+apellido.Trim();
                        textBoxNumTelefono.Text = $"{reader["NUMEROTELEFONO"]}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener información del empleado: " + ex.Message);
            }
        }

    }
}
