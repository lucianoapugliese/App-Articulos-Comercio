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
        private List<Articulo> listAux;
        private string filtro;

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

        // Evento Selecionar una fila:
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(articulo._urlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
       
        // Evento Boton Eliminar:
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        // Evento Boton Agregar:
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // falta formulario de datos
        }

        // Evento Boton Modificar:
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // falta formulario de datos
        }
        
        // Evento Cambio texto en caja de busqueda rapida:
        private void tbxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filtrarRapido();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Metodo filtrarRapido:
        public void filtrarRapido()
        {
            filtro = tbxFiltroRapido.Text;
            try
            {
                if(filtro.Length > 2)
                {
                    listAux = listaArticulos.FindAll(itm => itm._nombre.ToUpper().Contains(filtro.ToUpper()) || itm._codArticulo.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                { 
                    listAux = listaArticulos;
                }
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listAux;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Metodo Actulizar GridView:
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
            negocioArticulo = new NegocioArticulo();
            try
            {
                // El MessageBox maneja estas alertas asi:
                DialogResult respuesta = MessageBox.Show("Desea Eliminar el Pokemon seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.Yes)
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocioArticulo.eliminarArticulo(articulo._Id);
                    MessageBox.Show("Registro Eliminado permanentemente");
                    actualizarGridView();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }// Fin Form1
}
