using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        // ATRIBUTOS:
        public string _codArticulo { get; set; }
        public string _nombre { get; set; } 
        public string _descripcion { get; set; }
        public string _urlImagen { get; set; }
        public decimal _precio { get; set; }
        public Elemento _categoria;
        public Elemento _marca;

        // CONSTRUCTOR:
        public Articulo()
        {
            _categoria = new Elemento();
            _marca = new Elemento();
        }

        // METODOS:

    }
}
