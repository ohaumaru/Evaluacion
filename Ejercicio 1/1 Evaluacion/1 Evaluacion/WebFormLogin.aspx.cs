using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace _1_Evaluacion
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        String FuenteEncriptacion = "evaluacion";
        protected void ButtonIngresar_Clic(object sender, EventArgs e)
        {
            string Conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
            SqlConnection Conectar = new SqlConnection(Conexion);
            SqlCommand cmd = new SqlCommand("SP_ComprobarUsuario", Conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 250).Value=TextBoxUsuario.Text;
            cmd.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 250).Value = TextBoxContra.Text;
            cmd.Parameters.Add("@Fuente", SqlDbType.VarChar, 250).Value = FuenteEncriptacion;

            SqlDataReader Lector = cmd.ExecuteReader();

            if (Lector.Read()) 
            {
                Session["UsuarioAutorizado"] = TextBoxUsuario.Text;
                Response.Redirect("WebFormIndex.aspx");
            }
            else
            {
                LabelError.Text = "Usuario o Contraseña incorrectos.";
            }
            cmd.Connection.Close();
        }
    }
}