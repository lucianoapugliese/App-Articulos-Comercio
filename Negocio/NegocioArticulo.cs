using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioArticulo
    {
        // -- ATRIBUTOS -- :
        private Articulo _articulo;
        private AccesoDatos _accesoDatos;
        private List<Articulo> _listaArticulos;

        // -- CONSTRUCTORES -- :

        // -- METODOS -- :
        // Listar Articulos
        public List<Articulo> listarArticulos()
        {
            _listaArticulos = new List<Articulo>();
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery("select * from ARTICULOS");
                _accesoDatos.ejecutarLectrua();
                while (_accesoDatos._lector.Read())
                {
                    _articulo = new Articulo();
                    _articulo._codArticulo = (string)_accesoDatos._lector["Codigo"];
                    _articulo._nombre = (string)_accesoDatos._lector["Nombre"];
                    _articulo._descripcion = (string)_accesoDatos._lector["Descripcion"];
                    _listaArticulos.Add(_articulo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _accesoDatos.cerrarConexion();
            }

            return _listaArticulos;
        }

    }//Fin NegocioArticulo
}