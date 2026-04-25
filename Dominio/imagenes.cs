using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagenes
    {
        public int id { get; set; }

        public Articulo idArticulo { get; set; }

        public string imagenUrl { get; set; }

    }
}
