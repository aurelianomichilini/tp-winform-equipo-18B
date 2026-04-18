using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {



        public List<marca> listarMarcas()
        {
            List<marca> lista = new List<marca>();
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM MARCAS");
                datos.executeRead();

                while (datos.Reader.Read())
                {
                    marca aux = new marca();

                    aux.id = (int)datos.Reader["Id"];
                    aux.descripcion = datos.Reader["Descripcion"].ToString();

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.closeConnection();
            }
        }

        public void agregarMarca(marca nueva)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("INSERT INTO MARCAS (Descripcion) VALUES ('" + nueva.descripcion + "')");
                datos.executeAction();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.closeConnection();
            }
        }

        public void eliminarMarca(int id)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("DELETE FROM MARCAS WHERE Id = @Id");
                datos.setParameter("@Id", id);
                datos.executeAction();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.closeConnection();
            }
        }

        public void editarMarca(marca marca)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id");
                datos.setParameter("@Descripcion", marca.descripcion);
                datos.setParameter("@Id", marca.id);
                datos.executeAction();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.closeConnection();
            }
        }

    }
}
