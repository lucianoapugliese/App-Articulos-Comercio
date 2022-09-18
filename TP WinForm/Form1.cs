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
        public List<Articulo> lista;

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
                NegocioArticulo negocioArticulo = new NegocioArticulo();
                lista = negocioArticulo.listarArticulos();
                dgbArticulos.DataSource = lista;
                dgbArticulos.Columns["_codArticulo"].HeaderText = "CODIGO";
                dgbArticulos.Columns["_categoria"].HeaderText = "CATEGORIA";
                dgbArticulos.Columns["_marca"].HeaderText = "MARCA";
                dgbArticulos.Columns["_nombre"].HeaderText = "NOMBRE";
                dgbArticulos.Columns["_descripcion"].HeaderText = "DESCRIPCION";
                dgbArticulos.Columns["_precio"].HeaderText = "PRECIO";
                dgbArticulos.Columns["_urlImagen"].Visible = false;
                dgbArticulos.Columns["_Id"].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Cargar Imagen:
        private void dgbArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgbArticulos.CurrentRow.DataBoundItem;
            cargarImagen(articulo._urlImagen);
        }
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

    }// Fin Form1
}
