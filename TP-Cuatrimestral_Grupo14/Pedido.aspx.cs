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
            try
            {

                RestoNegocio restoNegocio = new RestoNegocio();

                    listaPlatos = restoNegocio.listarplatos();
                    listaBebidas = restoNegocio.listarcbebidas();

                if (!IsPostBack)
                {
                    ddlPlatos.DataSource = restoNegocio.listarplatos();
                    ddlPlatos.DataTextField = "NombrePlato";
                    ddlPlatos.DataValueField = "IDPlato";
                    ddlPlatos.DataBind();

                    ddlBebidas.DataSource = restoNegocio.listarcbebidas();
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
    }
}