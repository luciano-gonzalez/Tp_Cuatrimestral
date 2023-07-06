using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        [DisplayName ("IDPedido")]
        public int IdPedido { get; set; }

        public Insumo _insumo { get; set; }

        public float Cuenta{ get; set; }

        public string NombreCliente { get; set; }
        public int IdMesa { get; set; }

        

    }
}
