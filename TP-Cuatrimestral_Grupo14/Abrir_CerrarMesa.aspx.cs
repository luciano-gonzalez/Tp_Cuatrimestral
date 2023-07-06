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
            if (!IsPostBack)
            {
                // Verificar si ya existe la variable en la sesión
                if (Session["Asignaciones"] == null)
                {
                    // Obtener los nombres de los meseros desde la base de datos
                    List<string> nombresMeseros = ObtenerNombresMeserosDesdeBD();

                    // Crear una nueva variable de asignaciones en la sesión
                    Dictionary<int, string> asignaciones = new Dictionary<int, string>();

                    // Asignar los nombres de los meseros a las mesas en orden
                    for (int i = 1; i <= nombresMeseros.Count; i++)
                    {
                        asignaciones[i] = nombresMeseros[i - 1];
                    }

                    // Guardar la variable en la sesión
                    Session["Asignaciones"] = asignaciones;
                }
            }

        }

        protected void btnAsignarReasignarMesas_Click(object sender, EventArgs e)
        {
            // Obtener la lista de nombres de meseros desde la base de datos
            List<string> nombresMeseros = ObtenerNombresMeserosDesdeBD();

            // Crear una lista de números de mesa
            List<int> numerosMesa = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numerosMesa.Add(i);
            }

            // Realizar la asignación aleatoria de meseros a mesas
            Random random = new Random();
            Dictionary<int, string> asignaciones = new Dictionary<int, string>();
            foreach (int numeroMesa in numerosMesa)
            {
                int indiceAleatorio = random.Next(nombresMeseros.Count);
                string nombreMesero = nombresMeseros[indiceAleatorio];
                asignaciones[numeroMesa] = nombreMesero;

                // Remover el nombre del mesero asignado de la lista
                nombresMeseros.RemoveAt(indiceAleatorio);
            }

            // Almacenar la asignación en la sesión
            Session["Asignaciones"] = asignaciones;

            // Utilizar los datos de asignación para cualquier lógica adicional o visualización en la página
            //MostrarAsignaciones(asignaciones);

            // lblMensaje.Text = "Asignación/Reasignación exitosa";

        }

        private List<string> ObtenerNombresMeserosDesdeBD()
        {
            // Aquí debes implementar la lógica para obtener los nombres de los meseros desde la base de datos
            // y retornarlos como una lista de strings

            // Ejemplo de implementación ficticia:
            List<string> nombresMeseros = new List<string>();

            /*// Supongamos que tienes una conexión a la base de datos llamada "conexionBD"
            using (SqlConnection conexionBD = new SqlConnection("tu_cadena_de_conexion"))
            {
                // Abre la conexión
                conexionBD.Open();

                // Crea el comando SQL para obtener los nombres de los meseros
                SqlCommand comando = new SqlCommand("SELECT Nombre FROM Mesero", conexionBD);

                // Ejecuta el comando y lee los resultados
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string nombreMesero = reader.GetString(0);
                    nombresMeseros.Add(nombreMesero);
                }

                // Cierra el DataReader
                reader.Close();
            }*/

            return nombresMeseros;
        }

    }
}