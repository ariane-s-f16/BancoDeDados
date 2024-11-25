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
using static System.Net.Mime.MediaTypeNames;

namespace BancoDeDados.Views
{
    public partial class Categorias : Form
    {

        Categoria ca;
        public Categorias()
        {
            InitializeComponent();
        }


        void limpar()
        {
            txtnome.Clear();
            txtid.Clear();
            txtpesquisa.Clear();

        }

        void carregarnoDGV(string pesquisa)
        {
            ca = new Categoria()
            {
                nome = pesquisa
            };
            dgv.DataSource = ca.consulta();

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "") return;

            ca = new Categoria()
            {
                id = int.Parse(txtid.Text),
                nome = txtnome.Text,
                
            };

            ca.alterar();
            limpar();
            carregarnoDGV("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "") return;

            if (MessageBox.Show("Deseja excluir uma categoria? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ca = new Categoria()
                {
                    id = int.Parse(txtid.Text)
                };

                ca.excluir();
                limpar();
                carregarnoDGV("");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar();
            carregarnoDGV("");
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            carregarnoDGV(txtpesquisa.Text);
        }


        private void Categorias_Load(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "") return;

            ca = new Categoria()
            {
                id = int.Parse(txtid.Text),
                nome = txtnome.Text
               
            };

            ca.alterar();
            limpar();
            carregarnoDGV("");
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "") return;
            ca = new Categoria()
            {
                nome = txtnome.Text
                
            };

            ca.incluir();
            limpar();
            carregarnoDGV("");
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                txtid.Text = dgv.CurrentRow.Cells["id"].Value.ToString();
                txtnome.Text = dgv.CurrentRow.Cells["nome"].Value.ToString();
               

            }
        }
    }
}
