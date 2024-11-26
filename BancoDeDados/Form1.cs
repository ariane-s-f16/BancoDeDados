using BancoDeDados.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeDados.Views;
using BancoDeDados.Models;


namespace BancoDeDados
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cidade form = new Form_cidade();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banco.criarbanco();
        }

        

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marca form = new marca();
            form.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias form = new Categorias();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto form = new Produto();
            form.Show();
        }
    }
}
