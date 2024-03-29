using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.METODOS_SQL_CONEXION;
    using ProyectoBDDVistas.METODOS_SQL_CONEXION;

namespace ProyectoBDDVistas
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            String usuario= TBUsername.Text;
            String contraseņa = TBPassword.Text;

            //Cuando ustedes hagan descomente la linea de conexion suya y comente la del resto

            //Alex TallerReparacionQ
            //Conexion conexion = new Conexion("LAPTOP-MQ2NT5FG\\MSSQLSERVERI", "TallerReparacionQ",usuario,contraseņa);

            //Milton TallerReparacionG
            Conexion conexion = new Conexion("LAPTOP-VF0SV152", "TallerReparacionG",usuario,contraseņa);

            //Eddy 
            //Conexion conexion = new Conexion("DESKTOP-85782JV","TallerReparacionG",usuario,contraseņa);
           

            bool continuar = conexion.AbrirConexion(true);

            if(continuar )
            {
                
                FORMS.Form_Menu form_menu = new FORMS.Form_Menu(conexion.ObtenerConexion());
                form_menu.Show();
                this.Hide();
            }
            
        }
    }
}
