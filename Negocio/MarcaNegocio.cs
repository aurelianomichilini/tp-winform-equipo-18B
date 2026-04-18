using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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



    }
}
