using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery("SELECT Articulos.Id, Articulos.Codigo, Articulos.Nombre, Articulos.Descripcion, Articulos.Precio, " +
                               "Marcas.Id IdMarca, Marcas.Descripcion Marca, " +
                               "Categorias.Id IdCategoria, Categorias.Descripcion Categoria " +
                               "FROM ARTICULOS " +
                               "INNER JOIN MARCAS ON Articulos.IdMarca = Marcas.Id " +
                               "INNER JOIN CATEGORIAS ON Articulos.IdCategoria = Categorias.Id");

                datos.executeRead();

                while (datos.Reader.Read())
                {
                    Articulo aux = new Articulo();

                    aux.idArticulo = (int)datos.Reader["Id"];
                    aux.codigo = datos.Reader["Codigo"].ToString();
                    aux.nombre = datos.Reader["Nombre"].ToString();
                    aux.descripcion = datos.Reader["Descripcion"].ToString();
                    aux.precio = (decimal)datos.Reader["Precio"];

                    aux.IdMarca = new Marca();
                    aux.IdMarca.id = (int)datos.Reader["IdMarca"];
                    aux.IdMarca.descripcion = datos.Reader["Marca"].ToString();

                    aux.IdCategoria = new Categoria();
                    aux.IdCategoria.id = (int)datos.Reader["IdCategoria"];
                    aux.IdCategoria.descripcion = datos.Reader["Categoria"].ToString();

                    listaArticulos.Add(aux);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.closeConnection();
            }

        }

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
                throw ex;
            }
            finally
            {
                datos.closeConnection();
            }
        }
    }
}
