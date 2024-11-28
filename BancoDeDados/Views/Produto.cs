using BancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados.Views
{
    public partial class Produto : Form
    {
        Produtos p;
        public Produto()
        {
            InitializeComponent();
        }
        void limpar()
        {
            
            txtid.Clear();
            txtpesquisa.Clear();
            txtnome.Clear();
            imagem.ImageLocation = "";
            

        }

        void carregarnoDGV(string pesquisa)
        {
            p = new Produtos()
            {
                nome = pesquisa
            };
            dgv.DataSource = p.consulta();

        }
        private void Produto_Load(object sender, EventArgs e)
        {

        }

        
    }
}
