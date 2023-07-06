using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Resto
    {
        public int CantidadInsumos { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
