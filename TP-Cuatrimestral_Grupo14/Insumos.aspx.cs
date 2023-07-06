using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace TP_Cuatrimestral_Grupo14
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarStockInsumos();
                CargarStockPlatos();
                CargarStockBebidas();
            }
        }
        private void CargarStockInsumos()
        {
            RestoNegocio negocio = new RestoNegocio();
            List<Insumo> stockInsumos = negocio.listarinsumo();

            // Crear un nuevo DataTable con las columnas deseadas
            DataTable dtInsumos = new DataTable();
            dtInsumos.Columns.Add("Nombre", typeof(string));
            dtInsumos.Columns.Add("Stock", typeof(int));

            // Recorrer la lista de insumos y agregar los datos al DataTable
            foreach (Insumo insumo in stockInsumos)
            {
                string nombre = insumo.Nombre;
                int stock = insumo.CantidadStock;

                dtInsumos.Rows.Add(nombre, stock);
            }

            gvStockInsumos.DataSource = dtInsumos;
            gvStockInsumos.DataBind();
        }
        private void CargarStockPlatos()
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearconsulta("SELECT p.NombrePlato, SUM(pi.Cantidad) AS StockTotalPlato " +
                                 "FROM plato p " +
                                 "INNER JOIN platoInsumo pi ON p.IDPlato = pi.IDPlato " +
                                 "GROUP BY p.NombrePlato");
            
            datos.ejecutarLectura();

            DataTable dtStockPlatos = new DataTable();
            dtStockPlatos.Load(datos.Lector);
            datos.cerrarconexion();

            gvStockPlatos.DataSource = dtStockPlatos;
            gvStockPlatos.DataBind();
        }
        private void CargarStockBebidas()
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearconsulta("SELECT i.Nombre, SUM(i.Stock) AS StockTotalBebidas " +
                                 "FROM Insumo i " +
                                 "WHERE i.IDTipoinsumo = 2 " +
                                 "GROUP BY i.Nombre");
            datos.ejecutarLectura();

            DataTable dtStockBebidas = new DataTable();
            dtStockBebidas.Load(datos.Lector);
            datos.cerrarconexion();

            gvStockBebidas.DataSource = dtStockBebidas;
            gvStockBebidas.DataBind();
        }
    }
}