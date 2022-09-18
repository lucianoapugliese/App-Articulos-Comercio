using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo _articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            NegocioElemento _negocioElemento = new NegocioElemento();
            try
            {
                cboBoxMarca.DataSource = _negocioElemento.listar("MARCAS");
                cboBoxMarca.ValueMember = "Id";
                cboBoxMarca.DisplayMember = "Descripcion";
                cboBoxCategoria.DataSource = _negocioElemento.listar("CATEGORIAS");
                cboBoxCategoria.ValueMember = "Id";
                cboBoxCategoria.DisplayMember = "Descripcion";
                if (_articulo != null)
                {
                    txtBoxCodigoArticulo.Text = _articulo._codArticulo;
                    txtBoxNombre.Text = _articulo._nombre;
                    txtBoxDescripcion.Text = _articulo._descripcion;
                    txtBoxPrecio.Text = _articulo._precio.ToString();
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

        private void cargarImagen(string img)
        {
            try
            {
                pBoxImagenArticulo.Load(img);
            }
            catch (Exception)
            {
                pBoxImagenArticulo.Load("https://static.vecteezy.com/system/resources/previews/004/639/366/non_2x/error-404-not-found-text-design-vector.jpg");
            }
        }

        private void txtBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtBoxUrlImagen.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo _articulo = new Articulo();
            NegocioArticulo _negocioArticulo = new NegocioArticulo();
            try
            {
                _articulo._codArticulo = txtBoxCodigoArticulo.Text;
                _articulo._descripcion = txtBoxDescripcion.Text;
                _articulo._precio = decimal.Parse(txtBoxPrecio.Text);
                _articulo._urlImagen = txtBoxUrlImagen.Text;
                _articulo._nombre = txtBoxNombre.Text;
                _articulo._categoria = (Elemento)cboBoxCategoria.SelectedItem;
                _articulo._marca = (Elemento)cboBoxMarca.SelectedItem;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
