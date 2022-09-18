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
        //ATRIBUTOS:
        private Articulo _articulo;
        private AccesoDatos _accesoDatos;
        private List<Articulo> _listaArticulos;

        //METODOS:
        // Listar Articulos:
        public List<Articulo> listarArticulos()
        {
            _listaArticulos = new List<Articulo>();
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery("SELECT a.Id, a.Codigo, c.Descripcion AS Categoria, c.Id AS IdCategoria, m.Id AS IdMarca, m.Descripcion AS Marca, a.Nombre, a.Descripcion, a.Precio, a.ImagenUrl FROM ARTICULOS a, MARCAS m, CATEGORIAS c WHERE a.IdMarca = m.Id AND a.IdCategoria = c.Id");
                _accesoDatos.ejecutarLectura();
                while (_accesoDatos._lector.Read())
                {
                    _articulo = new Articulo();

                    _articulo._Id = (int)_accesoDatos._lector["Id"];
                    if(!(_accesoDatos._lector["Codigo"] is DBNull)) _articulo._codArticulo = (string)_accesoDatos._lector["Codigo"];
                    _articulo._categoria._Id = (int)_accesoDatos._lector["IdCategoria"];
                    if(!(_accesoDatos._lector["Categoria"] is DBNull))_articulo._categoria._Descripcion = (string)_accesoDatos._lector["Categoria"];
                    _articulo._marca._Id = (int)_accesoDatos._lector["IdMarca"];
                    if(!(_accesoDatos._lector["Marca"] is DBNull))_articulo._marca._Descripcion = (string)_accesoDatos._lector["Marca"];
                    if(!(_accesoDatos._lector["Nombre"] is DBNull))_articulo._nombre = (string)_accesoDatos._lector["Nombre"];
                    if(!(_accesoDatos._lector["Descripcion"] is DBNull))_articulo._descripcion = (string)_accesoDatos._lector["Descripcion"];
                    if (!(_accesoDatos._lector["Precio"] is DBNull)) _articulo._precio = (decimal)_accesoDatos._lector["Precio"];
                    if (!(_accesoDatos._lector["ImagenUrl"] is DBNull)) _articulo._urlImagen = (string)_accesoDatos._lector["ImagenUrl"];
                    
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

        // Agregar Articulo:
        public void agregarArticulo(Articulo art)
        {
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery($"INSERT INTO ARTICULOS VALUES ('{art._codArticulo}','{art._nombre}', '{art._descripcion}', {art._marca._Id}, {art._categoria._Id}, '{art._urlImagen}', {art._precio})");
                _accesoDatos.ejecutarQuery();
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

        // Modificar Articulo:
        public void modificarArticulo(Articulo art)
        {
            _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearQuery($"UPDATE ARTICULOS SET Codigo = '{art._codArticulo}', Nombre = '{art._nombre}', Descripcion = '{art._descripcion}', IdMarca = {art._marca._Id}, IdCategoria = {art._categoria._Id}, ImagenUrl = '{art._urlImagen}', Precio = {art._precio} WHERE Id = {art._Id}");
                _accesoDatos.ejecutarQuery();
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

        // Eliminar Articulo:
        public void eliminarArticulo(int id, bool flag)
        {
            _accesoDatos = new AccesoDatos();
            try
            {
                if(flag)
                {
                    //Eliminacion logica
                    _accesoDatos.setearQuery($"UPDATE ARTICULOS SET Activo = 0 WHERE Id = {id}");
                }
                else
                {
                    //Eliminacion fisica
                    _accesoDatos.setearQuery($"DELETE FROM ARTICULOS WHERE Id = {id}");
                }
                _accesoDatos.ejecutarQuery();
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

    }//Fin NegocioArticulo
}