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
    public partial class Form_NumeroTelefono : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_NumeroTelefono msnt;
        public metodos_Sql_Empleado mse;
        public Form_NumeroTelefono(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msnt = new metodos_Sql_NumeroTelefono();
            msnt.DesplegarDatosNumeroTelefono(Conexion, dGWNumeroTelefono);
            mse.DesplegarDatosEmpleados(Conexion, dGWEmpleado);

        }
        NumeroTelefono numeroTelefono;
        private void bttAgregarRegistrar_Click(object sender, EventArgs e)
        {
            numeroTelefono = new NumeroTelefono(txtBnumTelEmpleadoRegistrar.Text, 
                txtBidEmpleadoRegistrar.Text, msnt.idTaller);
            msnt.AgregarNumeroTelefono(Conexion, numeroTelefono);

            //actualizar tabla numeroTelefono
            msnt.DesplegarDatosNumeroTelefono(Conexion, dGWNumeroTelefono);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeroTelefono = new NumeroTelefono(txtBnumTelEmpleadoActEli.Text, 
                txtBidEmpleadoActEli.Text, msnt.idTaller);
            msnt.EliminarNumeroTelefono(Conexion, numeroTelefono);
        }
    }
}
