using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;
using System.Runtime.InteropServices;
using System.ComponentModel;



namespace Negocio
{
    public class RestoNegocio
    {
        public List<Insumo> listarinsumo()
        {
            List<Insumo> lista = new List<Insumo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearconsulta("select i.IDInsumo,i.IDTipoinsumo,i.Nombre,i.Descripcion,i.Stock,i.Precio,i.ImagenUrl from Insumo i");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Insumo insu = new Insumo();
                    insu.IdInsumo = (int)datos.lector["IDInsumo"];
                    insu.IdTipoInsumo = (int)datos.lector["IDTipoinsumo"];
                    insu.Nombre = (string)datos.lector["Nombre"];
                    insu.Descripcion = (string)datos.lector["Descripcion"];
                    insu.CantidadStock = (int)datos.lector["Stock"];
                    insu.Precio = (float)datos.lector.GetDecimal(5);
                    insu.UrlImagen = (string)datos.lector["ImagenUrl"];

                    lista.Add(insu);
                }
                return lista;
            }



            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }

        public List<Insumo> listarcbebidas()
        {
            List<Insumo> lista = new List<Insumo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearconsulta("select i.IDInsumo,i.IDTipoinsumo,i.Nombre,i.Descripcion,i.Stock,i.Precio,i.ImagenUrl from Insumo i where i.IDTipoinsumo = 2 ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Insumo insu = new Insumo();
                    insu.IdInsumo = (int)datos.lector["IDInsumo"];
                    insu.IdTipoInsumo = (int)datos.lector["IDTipoinsumo"];
                    insu.Nombre = (string)datos.lector["Nombre"];
                    insu.Descripcion = (string)datos.lector["Descripcion"];
                    insu.CantidadStock = (int)datos.lector["Stock"];
                    insu.Precio = (float)datos.lector.GetDecimal(5);
                    insu.UrlImagen = (string)datos.lector["ImagenUrl"];

                    lista.Add(insu);
                }
                return lista;
            }



            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }

        public List<Plato> listarplatos()
        {
            List<Plato> lista = new List<Plato>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearconsulta("select p.IDPlato,p.NombrePlato,p.Descripcion,p.Costo from plato p ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Plato plato = new Plato();
                    plato.IDPlato = (int)datos.Lector["IDPlato"];
                    plato.NombrePlato = (string)datos.Lector["NombrePlato"];
                    plato.Descripcion = (string)datos.Lector["Descripcion"];
                    plato.Costo = (float)datos.Lector.GetDecimal(3);


                    lista.Add(plato);
                }
                return lista;
            }



            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }




        public float Getprecioplatos(int idplato)
        {
            RestoNegocio resto = new RestoNegocio();

            try
            {
                List<Plato> listaplatos = resto.listarplatos();
                Plato plato = listaplatos.FirstOrDefault(p => p.IDPlato == idplato);
                if (plato != null)
                {

                    return plato.Costo;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return 0;

        }


        public float Getpreciobebidas(int idnsumo)
        {
            RestoNegocio resto = new RestoNegocio();

            try
            {
                List<Insumo> listarbebidas = resto.listarcbebidas();
                Insumo bebida = listarbebidas.FirstOrDefault(p => p.IdInsumo == idnsumo);
                if (bebida != null)
                {

                    return bebida.Precio;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return 0;

        }








    }






}