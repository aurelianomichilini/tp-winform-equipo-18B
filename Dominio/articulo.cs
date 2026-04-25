using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int idArticulo { get; set; }

        public string codigo { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public Marca IdMarca { get; set; }

        public Categoria IdCategoria { get; set; }

        public decimal precio { get; set; }
    }
}
