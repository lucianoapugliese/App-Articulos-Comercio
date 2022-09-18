using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace TP_WinForm
{
    // -- FORM MAIN --
    public partial class Form1 : Form
    {
        //CONSTRUCTOR:
        public Form1()
        {
            InitializeComponent();
        }

        //ATRIBUTOS:
        private List<Articulo> listaArticulos;
        private List<Elemento> listaElementos;
        private NegocioArticulo negocioArticulo;

        //METODOS:
        // Load:
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                actualizarGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Actulizar GridView:
        public void actualizarGridView()
        {
            try
            {
                negocioArticulo = new NegocioArticulo();
                listaArticulos= negocioArticulo.listarArticulos();
                dgvArticulos.DataSource = listaArticulos;

                dgvArticulos.Columns["_codArticulo"].HeaderText = "CODIGO";
                dgvArticulos.Columns["_categoria"].HeaderText = "CATEGORIA";
                dgvArticulos.Columns["_marca"].HeaderText = "MARCA";
                dgvArticulos.Columns["_nombre"].HeaderText = "NOMBRE";
                dgvArticulos.Columns["_descripcion"].HeaderText = "DESCRIPCION";
                dgvArticulos.Columns["_precio"].HeaderText = "PRECIO";
                dgvArticulos.Columns["_urlImagen"].Visible = false;
                dgvArticulos.Columns["_Id"].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Cargar Imagen:
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado._urlImagen);
        }

        // Metodo cargarImagen:
        private void cargarImagen(string img)
        {
            try
            { 
               pbArticulos.Load(img);
            }
            catch (Exception)
            {
                pbArticulos.Load("https://static.vecteezy.com/system/resources/previews/004/639/366/non_2x/error-404-not-found-text-design-vector.jpg");
            }
        }

        // Metodo Eliminar:
        public void eliminar()
        {

        }

    }// Fin Form1
}
