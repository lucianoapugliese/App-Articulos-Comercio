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

        // Eliminar:
        public void eliminar()
        {

        }

    }// Fin Form1
}
