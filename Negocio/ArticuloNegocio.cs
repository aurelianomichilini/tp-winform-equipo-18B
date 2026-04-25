using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public void agregarArticulo(Articulo nuevo)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio)");
                datos.setParameter("@codigo", nuevo.codigo);
                datos.setParameter("@nombre", nuevo.nombre);
                datos.setParameter("@descripcion", nuevo.descripcion);
                datos.setParameter("@idMarca", nuevo.IdMarca.id);
                datos.setParameter("@idCategoria", nuevo.IdCategoria.id);
                datos.setParameter("@precio", nuevo.precio);

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
