using System;
using System.Collections.Generic;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM Categorias");
                datos.executeRead();

                while (datos.Reader.Read())
                {
                    Categoria aux = new Categoria();

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

        public void modificarCategoria(Categoria Categoria)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("UPDATE CATEGORIAS SET Descripcion = @descripcion WHERE Id = @id");
                datos.setParameter("@descripcion", Categoria.descripcion);
                datos.setParameter("@id", Categoria.id);

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

        public bool existeCategoria(string descripcion)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("SELECT Id FROM CATEGORIAS WHERE Descripcion = @descripcion");
                datos.setParameter("@descripcion", descripcion);
                datos.executeRead();

                if (datos.Reader.Read())
                    return true;

                return false;
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
    }
}
