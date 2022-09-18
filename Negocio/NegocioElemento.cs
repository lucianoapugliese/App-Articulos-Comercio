using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioElemento
    {
        //ATRIBUTOS:
        private List<Elemento> _listaElementos;
        private AccesoDatos _accesoDatos;
        private Elemento elementoAux;

        //METODOS:
        public List<Elemento> listar(string str)
        {
            _listaElementos = new List<Elemento>();
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery($"SELECT Id, Descripcion FROM {str}");
                _accesoDatos.ejecutarLectura();
                while(_accesoDatos._lector.Read())
                {
                    elementoAux = new Elemento();
                    elementoAux._Id = (int)_accesoDatos._lector["Id"];
                    elementoAux._Descripcion = (string)_accesoDatos._lector["Descripcion"];
                    _listaElementos.Add(elementoAux);
                }

                return _listaElementos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _accesoDatos.cerrarConexion();
            }
        }

    }
}
