using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TP_WinForm
{
    public partial class frmAltaArticulo : Form
    {
        //ATRIBUTOS:
        private Articulo _articulo = null;
        private NegocioDetalle _negocioDetalle;
        private NegocioArticulo _negocioArticulo;
        private OpenFileDialog _archivo = null;

        //CONSTRUCTOR:
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo art)
        {
            InitializeComponent();
            _articulo = art;
        }

        //METODOS:
        // Evento Boton Cancelar:
        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Load:
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            _negocioDetalle = new NegocioDetalle();
            try
            {
                cboBoxMarca.DataSource = _negocioDetalle.listar("MARCAS");
                cboBoxCategoria.ValueMember = "_Id";
                cboBoxCategoria.DisplayMember = "_Descripcion";
                cboBoxCategoria.DataSource = _negocioDetalle.listar("CATEGORIAS");
                cboBoxMarca.ValueMember = "_Id";
                cboBoxMarca.DisplayMember = "_Descripcion";

                if (_articulo != null)
                {
                    txtBoxCodigoArticulo.Text = _articulo._codArticulo;
                    txtBoxNombre.Text = _articulo._nombre;
                    txtBoxDescripcion.Text = _articulo._descripcion;
                    txtBoxPrecio.Text = decimal.Round(_articulo._precio, 2).ToString();
                    txtBoxUrlImagen.Text = _articulo._urlImagen;
                    cargarImagen(_articulo._urlImagen);
                    cboBoxCategoria.SelectedValue = _articulo._categoria._Id;
                    cboBoxMarca.SelectedValue = _articulo._marca._Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Evento al dejar caja de texto Urlimagen:
        private void txtBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtBoxUrlImagen.Text);
        }

        // Evento boton Aceptar:
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string urlString = null;
            _negocioArticulo = new NegocioArticulo();
            try
            {
                if(_articulo == null) _articulo = new Articulo();

                _articulo._codArticulo = txtBoxCodigoArticulo.Text;
                _articulo._descripcion = txtBoxDescripcion.Text;
                _articulo._precio = Convert.ToDecimal(txtBoxPrecio.Text);
                _articulo._urlImagen = txtBoxUrlImagen.Text;
                urlString = txtBoxUrlImagen.Text;
                _articulo._nombre = txtBoxNombre.Text;
                _articulo._categoria = (Detalle)cboBoxCategoria.SelectedItem;
                _articulo._marca = (Detalle)cboBoxMarca.SelectedItem;

                if(_articulo._Id == 0)
                {
                    _negocioArticulo.agregarArticulo(_articulo);
                    MessageBox.Show("Articulo Agregado");
                }
                else
                {
                    _negocioArticulo.modificarArticulo(_articulo);
                    MessageBox.Show("Articulo Modificado");
                }
                if ( _archivo != null && !(urlString.ToUpper().Contains("HTTP")) )
                {
                    guardarImagen(txtBoxUrlImagen.Text, _archivo.SafeFileName);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        // Evento Boton Cargar Imagen:
        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            _archivo = new OpenFileDialog();
            _archivo.Filter = "jpg|*.jpg; |png|*.png";
            try
            {
               if( _archivo.ShowDialog() == DialogResult.OK )
                {
                    txtBoxUrlImagen.Text = _archivo.FileName;
                    cargarImagen(txtBoxUrlImagen.Text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        // Metodo Cargar Imagen:
        private void cargarImagen(string img)
        {
            try
            {
                pBoxImagenArticulo.Load(img);
            }
            catch
            {
                pBoxImagenArticulo.Load("https://static.vecteezy.com/system/resources/previews/004/639/366/non_2x/error-404-not-found-text-design-vector.jpg");
            }
        }


        // Metodo GuardarImagen:
        //     - si string destino es null, guardamos en ruta por defecto, sino usamos su valor como ruta
        public void guardarImagen(string fuente, string nombreArchivo, string destino = null)
        {
            destino = destino ?? ConfigurationManager.AppSettings["images-folder"] + nombreArchivo;
            try
            {
                if ( !File.Exists(destino) ) File.Copy(fuente, destino);
                else MessageBox.Show("Imagen no guardada, ya existe");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


    }//fin form
}
