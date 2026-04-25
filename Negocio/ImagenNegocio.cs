using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {

        public List<Imagenes> listarPorArticulo(int idArticulo)
        {
            List<Imagenes> lista = new List<Imagenes>();
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery(@"
                    SELECT 
                        I.Id,
                        I.IdArticulo,
                        I.ImagenUrl
                    FROM IMAGENES I
                    WHERE I.IdArticulo = @idArticulo
                ");

                datos.setParameter("@idArticulo", idArticulo);
                datos.executeRead();

                while (datos.Reader.Read())
                {
                    Imagenes aux = new Imagenes();

                    aux.id = Convert.ToInt32(datos.Reader["Id"]);
                    aux.imagenUrl = datos.Reader["ImagenUrl"].ToString();

                    aux.idArticulo = new Articulo();
                    aux.idArticulo.idArticulo = Convert.ToInt32(datos.Reader["IdArticulo"]);

                    lista.Add(aux);
                }

                return lista;
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

        public void agregarImagen(Imagenes nueva)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery(@"
                    INSERT INTO IMAGENES 
                    (
                        IdArticulo,
                        ImagenUrl
                    )
                    VALUES 
                    (
                        @idArticulo,
                        @ImagenUrl
                    )
                ");

                datos.setParameter("@idArticulo", nueva.idArticulo.idArticulo);
                datos.setParameter("@ImagenUrl", nueva.imagenUrl);

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
        public void eliminarImagen(int id)
        {
            dbAccess datos = new dbAccess();

            try
            {
                datos.setQuery(@"
                    DELETE FROM IMAGENES
                    WHERE Id = @id
                ");

                datos.setParameter("@id", id);

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
