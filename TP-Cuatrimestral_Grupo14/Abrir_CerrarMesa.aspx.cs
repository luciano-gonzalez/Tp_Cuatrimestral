using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP_Cuatrimestral_Grupo14
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (!IsPostBack)
                {
                    CargarOpcionesDropDownLists();
                    RestaurarValoresDesdeSession();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void ddlmesa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ActualizarOpcionesDisponibles((DropDownList)sender);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CargarOpcionesDropDownLists()
        {
            try
            {
                List<string> opciones = new List<string> { " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

                foreach (DropDownList ddl in ObtenerDropDownLists())
                {
                    ddl.DataSource = opciones;
                    ddl.DataBind();
                    Session[ddl.ID] = ddl.SelectedValue;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ActualizarOpcionesDisponibles(DropDownList ddl)
        {
            // Obtener la opción seleccionada en el DropDownList actual
            ListItem opcionSeleccionada = ddl.SelectedItem;

            // Iterar a través de los otros DropDownList y deshabilitar la opción seleccionada
            foreach (DropDownList ddlActual in ObtenerDropDownLists())
            {
                if (ddlActual != ddl)
                {
                    ddlActual.Items.FindByValue(opcionSeleccionada.Value).Enabled = false;
                }
            }
        }

        private List<DropDownList> ObtenerDropDownLists()
        {
            // Crea una lista con los 10 DropDownList
            List<DropDownList> dropDownLists = new List<DropDownList>
            {
                ddlmesa1, ddlmesa2, ddlmesa3, ddlmesa4, ddlmesa5, ddlmesa6, ddlmesa7, ddlmesa8, ddlmesa9, ddlmesa10
            };

            return dropDownLists;
        }

        protected void resetearMesas_Click(object sender, EventArgs e)
        {
            foreach (DropDownList ddl in ObtenerDropDownLists())
            {
                ddl.ClearSelection();
            }
            CargarOpcionesDropDownLists();
        }

        private void RestaurarValoresDesdeSession()
        {
            foreach (DropDownList ddl in ObtenerDropDownLists())
            {
                if (Session[ddl.ID] != null)
                {
                    string valorSeleccionado = Session[ddl.ID].ToString();

                    // Restaurar el valor seleccionado
                    ddl.SelectedValue = valorSeleccionado;
                }
            }
        }
    }
}