using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Cuatrimestral_Grupo14
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario() ;
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                usuario._Usuario = txtUsuario.Text;
                usuario._Contraseña = txtContraseña.Text;
                if (negocio.Loguear(usuario)){
                    Session.Add("usuario", usuario);
                    Response.Redirect("MenuIngreso.aspx",false);
                }
                else
                {
                    string script = "alert('usuario u contraseña incorrecta.');";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                }
                    

            }
            catch (Exception ex)
            {

                Session.Add("error",ex.ToString());
            }

        }
    }
}