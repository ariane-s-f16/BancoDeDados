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
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

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

        private void btn_incluir_Click(object sender, EventArgs e)
        {

            if (txtnome.Text == "") return;
            p = new Produtos()
            {
                nome = txtnome.Text,
                id_marca = (int)cb_marca.SelectedValue,
                id_categoria = (int)cb_categoria.SelectedValue,
                estoque = int.Parse(txtestoque.Text),
                valorvenda = int.Parse(txtvalor.Text),
                imagem = imagem.ImageLocation,

            };


            p.incluir();
            limpar();
            carregarnoDGV("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "") return;

            p = new Produtos()
            {
                id = int.Parse(txtid.Text),
                nome = txtnome.Text,
                id_marca = (int)cb_marca.SelectedValue,
                id_categoria = (int)cb_categoria.SelectedValue,
                estoque = int.Parse(txtestoque.Text),
                valorvenda = int.Parse(txtvalor.Text),
                imagem = imagem.ImageLocation,
            };

            p.alterar();
            limpar();
            carregarnoDGV("");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar();
            carregarnoDGV("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "") return;

            if (MessageBox.Show("Deseja excluir cliente? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                p = new Produtos()
                {
                    id = int.Parse(txtid.Text)
                };

                p.excluir();
                limpar();
                carregarnoDGV("");
            }
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            carregarnoDGV(txtpesquisa.Text);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                txtid.Text = dgv.CurrentRow.Cells["id"].Value.ToString();
                txtnome.Text = dgv.CurrentRow.Cells["nome"].Value.ToString();
                txtestoque.Text = dgv.CurrentRow.Cells["estoque"].Value.ToString();
                cb_categoria.Text = dgv.CurrentRow.Cells["id_categoria"].Value.ToString();
                cb_marca.Text = dgv.CurrentRow.Cells["id_marca"].Value.ToString();
                txtvalor.Text = dgv.CurrentRow.Cells["valorvenda"].Value.ToString();
                imagem.ImageLocation = dgv.CurrentRow.Cells["imagem"].Value.ToString();

            }
        }

        private void imagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:/fotos/clientes/";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            imagem.ImageLocation = openFileDialog1.FileName;
        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_categoria.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cb_categoria.SelectedItem;

            }
        }

        private void cb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_marca.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cb_marca.SelectedItem;

            }
        }
    }

}
