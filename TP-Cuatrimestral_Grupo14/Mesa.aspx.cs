using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace TP_Cuatrimestral_Grupo14
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            // Obtener los parámetros de URL
            string mesa = Request.QueryString["mesa"];
            string nombreCliente = Request.QueryString["nombre"];
            string precioPlato = Request.QueryString["precio"];

            // Verificar si se pasaron los parámetros de URL
            if (!string.IsNullOrEmpty(mesa) && !string.IsNullOrEmpty(nombreCliente) && !string.IsNullOrEmpty(precioPlato))
            {
                // Convertir el número de mesa a un índice de vector
                int index = int.Parse(mesa) - 1;

                // Actualizar la visualización de la mesa correspondiente con los datos pasados
                var mesaContent = (HtmlGenericControl)FindControl($"MesaContent{mesa}");
                mesaContent.InnerHtml = $"{nombreCliente} - Monto: {precioPlato}";

                // Guardar los valores en los vectores correspondientes en la sesión
                string[] nombreClienteArray = (string[])Session["NombreCliente"];
                string[] numeroMesaArray = (string[])Session["NumeroMesa"];
                string[] precioPlatoArray = (string[])Session["PrecioPlato"];
                nombreClienteArray[index] = nombreCliente;
                numeroMesaArray[index] = mesa;
                precioPlatoArray[index] = precioPlato;
                Session["NombreCliente"] = nombreClienteArray;
                Session["NumeroMesa"] = numeroMesaArray;
                Session["PrecioPlato"] = precioPlatoArray;
            }



        }

        protected void Boton_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            if (boton.CssClass.Contains("verde"))
            {
                boton.CssClass = "boton rojo";
            }
            else
            {
                boton.CssClass = "boton verde";
            }
        }

        protected void btnObtenerColores_Click(object sender, EventArgs e)
        {
            List<string> colores = ObtenerColoresBotones();

            // Realizar acciones con la lista de colores obtenida
        }

        private List<string> ObtenerColoresBotones()
        {
            List<string> colores = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                Button boton = FindControl("btnMesa" + i) as Button;
                if (boton != null)
                {
                    string color = boton.Attributes["data-color"];
                    colores.Add(color);
                }
            }

            return colores;
        }
        protected void LiberarPedidoButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int mesaIndex = int.Parse(button.ID.Replace("Button", ""));

            LiberarPedido(mesaIndex);

            // Actualizar el HTML para mostrar la información del pedido
            MostrarPedido(mesaIndex);
        }

        private void LiberarPedido(int mesaIndex)
        {
            var nombreClienteArray = (string[])Session["NombreCliente"];
            var precioPlatoArray = (string[])Session["PrecioPlato"];

            nombreClienteArray[mesaIndex - 1] = string.Empty;
            precioPlatoArray[mesaIndex - 1] = string.Empty;

            Session["NombreCliente"] = nombreClienteArray;
            Session["PrecioPlato"] = precioPlatoArray;
        }

        private void MostrarPedido(int mesaIndex)
        {
            var button = (Button)FindControl($"Button{mesaIndex}");
            var mesaContent = (HtmlGenericControl)FindControl($"MesaContent{mesaIndex}");

            var nombreClienteArray = (string[])Session["NombreCliente"];
            var precioPlatoArray = (string[])Session["PrecioPlato"];

            // Verificar si hay un pedido para esta mesa
            if (!string.IsNullOrEmpty(nombreClienteArray[mesaIndex - 1]) && !string.IsNullOrEmpty(precioPlatoArray[mesaIndex - 1]))
            {
                button.CssClass = "boton rojo";
                mesaContent.InnerHtml = $"{nombreClienteArray[mesaIndex - 1]} - Monto: {precioPlatoArray[mesaIndex - 1]}";
            }
            else
            {
                button.CssClass = "boton verde";
                mesaContent.InnerHtml = string.Empty;
            }
        }



    }
}