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
using BancoDeDados.Models;

namespace BancoDeDados.Views
{
    public partial class Form_cidade : Form
    {
        Cidades c;
        public Form_cidade()
        {
            InitializeComponent();
        }

        private void Form_cidade_Load(object sender, EventArgs e)
        {

        }

        void limpar() 
        {
            txt_cidade.Clear();
            txt_cod.Clear();
            txt_pesquisa.Clear();
            txt_uf.Clear();
        }
        void carregarnoDGV() 
        {
            c = new Cidades();
            {
                nome = pesquisa
            };
            

        }
    }
}
