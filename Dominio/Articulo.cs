using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Articulo
    {
        // Atributos:
        public int _codArticulo { get; set; }
        public string _nombre { get; set; } 
        public string _descripcion { get; set; }
        public string _urlImagen { get; set; }
        public decimal _precio { get; set; }
    }
}
