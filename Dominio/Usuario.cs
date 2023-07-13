using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

    public enum TipoUsuario
    {
        Normal = 0,
        Admin = 1
    }
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string _Usuario { get; set; }

        public string _Contraseña { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
        
        public bool Admin { get; set; }

        
    
    
    }

    
}
