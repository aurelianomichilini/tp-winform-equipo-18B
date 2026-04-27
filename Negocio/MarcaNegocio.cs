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



        public List<Marca> listarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM MARCAS");
                datos.executeRead();

                while (datos.Reader.Read())
                {
                    Marca aux = new Marca();

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

        public void agregarMarca(Marca nueva)
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
        public bool marcaConAritucloAsociado(int id)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("SELECT Id FROM ARTICULOS WHERE IdMarca = @id");
                datos.setParameter("@id", id);
                datos.executeRead();

                if (datos.Reader.Read())
                    return true;

                return false;
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

        public bool existeMarca(string descripcion)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("SELECT Id FROM MARCAS WHERE Descripcion = @descripcion");
                datos.setParameter("@descripcion", descripcion);
                datos.executeRead();

                if (datos.Reader.Read())
                    return true;

                return false;
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

        public void editarMarca(Marca Marca)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id");
                datos.setParameter("@Descripcion", Marca.descripcion);
                datos.setParameter("@Id", Marca.id);
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
