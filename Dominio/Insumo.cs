using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumo
    {
        public int IdTipoInsumo{ get; set; }

        public int IdInsumo { get; set; }

        public int CantidadStock { get; set; }

        public float Precio { get; set; }

        public string Descripcion { get; set; }

        public string UrlImagen { get; set; }

        public string Nombre { get; set; }
    }
}
