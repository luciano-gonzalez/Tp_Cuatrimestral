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
    public partial class About : Page
    {
        private List<Plato> listaPlatos;
        private List<Insumo> listaBebidas;
        private List<Plato> platosSeleccionados;
        private List<Insumo> bebidasSeleccionadas;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Declarar e inicializar los vectores en el Page_Load
                string[] nombreClienteArray = new string[10];
                string[] numeroMesaArray = new string[10];
                string[] precioPlatoArray = new string[10];

                // Guardar los vectores en la sesión
                Session["NombreCliente"] = nombreClienteArray;
                Session["NumeroMesa"] = numeroMesaArray;
                Session["PrecioPlato"] = precioPlatoArray;
            }

            try
            {
                RestoNegocio restoNegocio = new RestoNegocio();

                listaPlatos = restoNegocio.listarplatos();
                listaBebidas = restoNegocio.listarcbebidas();

                if (!IsPostBack)
                {
                    ddlPlatos.DataSource = listaPlatos;
                    ddlPlatos.DataTextField = "NombrePlato";
                    ddlPlatos.DataValueField = "IDPlato";
                    ddlPlatos.DataBind();

                    ddlBebidas.DataSource = listaBebidas;
                    ddlBebidas.DataTextField = "Nombre";
                    ddlBebidas.DataValueField = "IDInsumo";
                    ddlBebidas.DataBind();

                    platosSeleccionados = new List<Plato>();
                    bebidasSeleccionadas = new List<Insumo>();

                    Session["PlatosSeleccionados"] = platosSeleccionados;
                    Session["BebidasSeleccionadas"] = bebidasSeleccionadas;
                }
                else
                {
                    platosSeleccionados = (List<Plato>)Session["PlatosSeleccionados"];
                    bebidasSeleccionadas = (List<Insumo>)Session["BebidasSeleccionadas"];
                }

                ActualizarPedido();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        protected void btn_bebida_Click(object sender, EventArgs e)
        {
            try
            {
                int idBebida = Convert.ToInt32(ddlBebidas.SelectedValue);
                Insumo bebida = listaBebidas.FirstOrDefault(b => b.IdInsumo == idBebida);

                if (bebida != null)
                {
                    bebidasSeleccionadas.Add(bebida);
                    ActualizarPedido();
                    Txtdescripcion.Text += "(" + bebida.Descripcion + ") " + "- ";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btn_plato_Click(object sender, EventArgs e)
        {
            try
            {
                int idPlato = Convert.ToInt32(ddlPlatos.SelectedValue);
                Plato plato = listaPlatos.FirstOrDefault(p => p.IDPlato == idPlato);

                if (plato != null)
                {
                    platosSeleccionados.Add(plato);
                    ActualizarPedido();
                    Txtdescripcion.Text += "(" + plato.Descripcion + ") " + "- ";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void ActualizarPedido()
        {
            try
            {

                gvPlatosSeleccionados.DataSource = platosSeleccionados;
                gvPlatosSeleccionados.DataBind();


                gvBebidasSeleccionadas.DataSource = bebidasSeleccionadas;
                gvBebidasSeleccionadas.DataBind();


                float totalPlatos = platosSeleccionados.Sum(p => p.Costo);
                float totalBebidas = bebidasSeleccionadas.Sum(b => b.Precio);
                float costoTotal = totalPlatos + totalBebidas;

                TxtMonto.Text = "$" + costoTotal.ToString();
                gvPlatosSeleccionados.Visible = false;
                gvBebidasSeleccionadas.Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        protected void btn_reset_Click(object sender, EventArgs e)
        {
            Txtdescripcion.Text = string.Empty;
            TxtMonto.Text = "$" + 0.ToString();
            platosSeleccionados.Clear();
            bebidasSeleccionadas.Clear();

            gvPlatosSeleccionados.DataSource = platosSeleccionados;
            gvPlatosSeleccionados.DataBind();


            gvBebidasSeleccionadas.DataSource = bebidasSeleccionadas;
            gvBebidasSeleccionadas.DataBind();


        }

       
        protected void ConfirmarPedido_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string nombreCliente = Txtnombre.Text.Trim();
            string numeroMesa = ddlmesa.SelectedValue;
            string precioPlato = TxtMonto.Text.Trim();

            // Validar si algún campo está vacío o tiene valor 0
            if (string.IsNullOrEmpty(nombreCliente) || numeroMesa == "0" || precioPlato == "$0")
            {
                // Mostrar mensaje de advertencia
                string script = "alert('Faltan completar campos o agregar platos/bebidas.');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                return;
            }

            // Convertir el número de mesa a un índice de vector
            int index = int.Parse(numeroMesa) - 1;

            // Obtener los vectores de la sesión
            string[] nombreClienteArray = (string[])Session["NombreCliente"];
            string[] numeroMesaArray = (string[])Session["NumeroMesa"];
            string[] precioPlatoArray = (string[])Session["PrecioPlato"];

            // Guardar los valores en los vectores correspondientes
            nombreClienteArray[index] = nombreCliente;
            numeroMesaArray[index] = numeroMesa;
            precioPlatoArray[index] = precioPlato;

            // Guardar los vectores actualizados en la sesión
            Session["NombreCliente"] = nombreClienteArray;
            Session["NumeroMesa"] = numeroMesaArray;
            Session["PrecioPlato"] = precioPlatoArray;

            // Restablecer los campos del formulario
            Txtnombre.Text = string.Empty;
            Txtdescripcion.Text = string.Empty;
            TxtMonto.Text = "$" + 0.ToString();
            platosSeleccionados.Clear();
            bebidasSeleccionadas.Clear();

        }
    }
}