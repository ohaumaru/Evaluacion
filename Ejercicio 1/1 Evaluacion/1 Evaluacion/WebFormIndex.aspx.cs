using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_Evaluacion
{
    public partial class WebFormIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioAutorizado"] != null)
            {
                string Usuarios = Session["UsuarioAutorizado"].ToString();
                LabelIngreso.Text = "Bienvenido " + Usuarios;
            }
            else
            {
                Response.Redirect("WebFormLogin.aspx");
            }
        }

        protected void ButtonCerrarSesion_Click (object sender, EventArgs e)
        {
            Session.Remove("UsuarioAutorizado");
            Response.Redirect("WebFormLogin.aspx");
        }
    }
}