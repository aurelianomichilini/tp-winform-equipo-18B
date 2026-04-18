using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class articulo
    {
        public int idArticulo { get; set; }

        public int codigo { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public marca IdMarca { get; set; }

        public categoria IdCategoria { get; set; }

        public float precio { get; set; }
    }
}
