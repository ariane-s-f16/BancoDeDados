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

       

        void limpar() 
        {
            txt_cidade.Clear();
            txt_cod.Clear();
            txt_pesquisa.Clear();
            txt_uf.Clear();
        }
        void carregarnoDGV(string pesquisa) 
        {
            c = new Cidades()
            {
                nome = pesquisa
            };
            dgvcidade.DataSource = c.consulta();

        }
        private void Form_cidade_Load(object sender, EventArgs e)
        {
            limpar();
            carregarnoDGV("");
        }


        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if(txt_cidade.Text == String.Empty) return;


            c = new Cidades()
            {
                nome = txt_cidade.Text,
            uf = txt_uf.Text
            };

            c.incluir();
            limpar();
            carregarnoDGV("");

        }

        private void dgvcidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcidade.Rows.Count > 0) 
            {
                txt_cod.Text= dgvcidade.CurrentRow.Cells["id"].Value.ToString();
                txt_cidade.Text = dgvcidade.CurrentRow.Cells["nome"].Value.ToString();
                txt_uf.Text = dgvcidade.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if(txt_cod.Text == String.Empty) return;
            c = new Cidades()
            {
                id = int.Parse(txt_cod.Text),
                nome = txt_cidade.Text,
                uf = txt_uf.Text
            };
            c.alterar();
            limpar();
            carregarnoDGV("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(txt_cod.Text == "") return;

            if (MessageBox.Show("Deseja excluir a cidade? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                c = new Cidades()
                {
                    id = int.Parse(txt_cod.Text),
                };
                c.excluir();
                limpar();
                carregarnoDGV("");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar();
            carregarnoDGV("");
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            carregarnoDGV(txt_pesquisa.Text);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
