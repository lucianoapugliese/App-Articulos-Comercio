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
    public partial class Form1 : Form
    {
        // Form Principal
        public Form1()
        {
            InitializeComponent();
        }

        // ATRIBUTOS:
        public List<Articulo> lista;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                NegocioArticulo negocioArticulo = new NegocioArticulo();
                lista = negocioArticulo.listarArticulos();
                dataGridView1.DataSource = lista;
                dataGridView1.Columns["_codArticulo"].HeaderText = "Articulo"; // Cambiamos el nombre de la columna
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
