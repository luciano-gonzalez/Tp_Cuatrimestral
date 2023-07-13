using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public bool Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearconsulta("select IDUsuario,IDTipousuario from Usuario where usuario=@usuario and contraseña=@contraseña ");
                datos.setearParametro("@usuario",usuario._Usuario);
                datos.setearParametro("@contraseña",usuario._Contraseña);
                datos.ejecutarLectura();
                while (datos.lector.Read())
                {
                    usuario.IdUsuario = (int)datos.lector["IDUsuario"];
                    usuario.TipoUsuario = (int)(datos.lector["IDTipousuario"]) == 1 ? TipoUsuario.Admin : TipoUsuario.Normal;
                    return true;
                }
                return false;



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally{
                datos.cerrarconexion();
            }

        }



    }
}
