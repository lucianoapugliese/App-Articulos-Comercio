using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Negocio
{
    // Acceso a Datos
    public class AccesoDatos
    {
        //ATRIBUTOS:
        private SqlConnection _conexion = null;
        private SqlCommand _command;
        private SqlDataReader _reader = null;
        public SqlDataReader _lector
        { 
            get {return _reader;} 
        }

        //CONSTRUCTOR:
        public AccesoDatos(string cadenaConexion = "server=.; database = CATALOGO_DB; integrated security = true")
        {
            //cadenaConexion="server =.\\SQLEXPRESS01; database = CATALOGO_DB; integrated security = true";
            // Luchoo! para conectarte vs cambia "serverDef1" por "serverDef2"...
            string server = ConfigurationManager.AppSettings["serverDef1"];
            cadenaConexion = "server="+server+";database = CATALOGO_DB; integrated security = true";
            try
            {
                _conexion = new SqlConnection(cadenaConexion);
                _conexion.Open();
                _conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al conectar con la base de datos");
            }
            _command = new SqlCommand();
        }

        //METODOS:
        // SetQuery:
        public void setearQuery(string query)
        {
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = query;
        }

        // Ejecutar Lectura de Datos:
        public void ejecutarLectura()
        {
            _command.Connection = _conexion;
            try
            {
                // Traemos un grupo de datos de la BD y colocamos en un SqlDatareader
                _conexion.Open();
                _reader = _command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Cerrar Conexion:
        public void cerrarConexion() 
        { 
            if( _reader != null )
            {
                _reader.Close();
            }
            _conexion.Close(); 
        }

        // Ejecutar Query:
        public void ejecutarQuery()
        {
            _command.Connection = _conexion;
            try
            {
                _conexion.Open();
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Modificar parametros sql en comando:
        public void setearParametro(string str, object valor)
        {
            _command.Parameters.AddWithValue(str, valor);
        }

    }//fin AccesoDatos
}