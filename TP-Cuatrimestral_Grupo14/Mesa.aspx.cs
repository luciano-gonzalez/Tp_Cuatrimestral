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
            for (int i = 1; i <= 10; i++)
            {
                var mesaDiv = new HtmlGenericControl("div");
                mesaDiv.Attributes["class"] = "mesa " + (i <= 8 ? "cuadrada" : "rectangular");
                mesaDiv.InnerText = i.ToString();

                var botonDiv = new HtmlGenericControl("div");
                botonDiv.Attributes["class"] = "boton-container";

                var boton = new Button();
                boton.CssClass = "boton verde";
                boton.Click += Boton_Click;

                botonDiv.Controls.Add(boton);
                mesaDiv.Controls.Add(botonDiv);
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

        
    }
}