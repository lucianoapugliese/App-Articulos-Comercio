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
        private Articulo articulo;

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
                dgbArticulos.DataSource = listaArticulos;

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
            try
            {
                articulo = (Articulo)dgbArticulos.CurrentRow.DataBoundItem;
                cargarImagen(articulo._urlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
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
            articulo = new Articulo();

            try
            {
                // El MessageBox maneja estas alertas asi:
                DialogResult respuesta = MessageBox.Show("Desea Eliminar el Pokemon seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.Yes)
                {
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }// Fin Form1
}
