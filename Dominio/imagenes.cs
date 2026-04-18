using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class imagenes
    {
        public int id { get; set; }

        public articulo idArticulo { get; set; }

        public string imagenUrl { get; set; }

    }
}
