using System;
using System.Collections.Generic;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<categoria> listarCategorias()
        {
            List<categoria> lista = new List<categoria>();
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM Categorias");
                datos.executeRead();

                while (datos.Reader.Read())
                {
                    categoria aux = new categoria();

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
    }
}
