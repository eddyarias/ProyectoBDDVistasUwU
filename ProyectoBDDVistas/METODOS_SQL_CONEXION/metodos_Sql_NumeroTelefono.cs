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
        //CAMBIE SEGUN SU ROL
        public string idTaller = "TALL001";

        public void DesplegarDatosNumeroTelefono(SqlConnection conexion, DataGridView dataGridView)
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

        public void AgregarNumeroTelefono(SqlConnection conexion, NumeroTelefono numeroTelefono)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la inserción de datos
                SqlCommand cmd = new SqlCommand($"INSERT INTO {tabla} (ID_EMPLEADO, NUMERO_TELEFONO, ID_TALLER) " +
                                                "VALUES (@IdEmpleado, @NumeroTelefono, @IdTaller)", conexion);

                // Asignar valores a los parámetros utilizando el objeto NumeroTelefono
                cmd.Parameters.AddWithValue("@IdEmpleado", numeroTelefono.IdEmpleado);
                cmd.Parameters.AddWithValue("@NumeroTelefono", numeroTelefono.NumeroTelefonico);
                cmd.Parameters.AddWithValue("@IdTaller", numeroTelefono.IdTaller);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
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
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Antes de eliminar, mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este número de teléfono?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Crear el comando SQL para la eliminación de datos
                    SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE ID_EMPLEADO = @IdEmpleado AND ID_TALLER = @IdTaller AND NUMEROTELEFONO = @NumTelefono", conexion);

                    // Asignar valores a los parámetros utilizando el ID_EMPLEADO
                    cmd.Parameters.AddWithValue("@IdEmpleado", numeroTelefono.IdEmpleado);
                    cmd.Parameters.AddWithValue("@IdTaller", numeroTelefono.IdTaller); 
                    cmd.Parameters.AddWithValue("@NumTelefono", numeroTelefono.NumeroTelefonico);
                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Número de teléfono eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar número de teléfono: " + ex.Message);
            }

        }

    }
}
