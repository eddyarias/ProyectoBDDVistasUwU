using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.CLASES;
using ProyectoBDDVistas.METODOS_SQL_CONEXION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDDVistas.FORMS
{
    public partial class Form_ClienteInformacion : Form
    {
        public SqlConnection Conexion;
        public metodo_sql_InfoCliente msi;
     
        public Form_ClienteInformacion(SqlConnection conexion)
        {
  

            InitializeComponent();
            Conexion = conexion;
            parametros parametros = new parametros();
            if (parametros.idTaller == "TALL001")
            {
                msi = new metodo_sql_InfoCliente();
                msi.DesplegarDatosCliente(conexion, dtgvInfoCliente);
            }
        }
    }
}
