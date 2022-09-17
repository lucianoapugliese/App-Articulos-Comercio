using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    // Esta clase es generica a MARCA y CATEGORIA de la BD
    public class Elemento
    {
        // ATRIBUTOS:
        public int _Id { get; set; }
        public string _Descripcion { get; set; }

        // METODOS:
        // sobrecargar el metodo ToString() para que en el dgbArticulo muestre la descripcion
        public override string ToString()
        {
            return _Descripcion;
        }
    }
}
