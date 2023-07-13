using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TP_Cuatrimestral_Grupo14
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page is WebForm2))
            {
                if (!Seguridad.sessionActiva(Session["Usuario"]))
                    Response.Redirect("Login.aspx", false);

            }

        }
    }
}