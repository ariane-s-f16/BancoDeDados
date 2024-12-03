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
        marcas m;
        Categoria c;
        public Produto()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtnome.Clear();
            txtestoque.Clear();
            txtid.Clear();
            txtvalor.Clear();
            cb_categoria.SelectedIndex = -1;
            cb_marca.SelectedIndex = -1;
        }

        public void CarregarnoDGV(string pesquisa)
        {
            p = new Produtos()
            {
               nome = pesquisa
            };

            dgv.DataSource = p.consulta();
        }

        public void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "") return;

            p = new Produtos()
            {
                nome= txtnome.Text,
                imagem = imagem.ImageLocation,
                estoque = int.Parse(txtestoque.Text),
                valorvenda = int.Parse(txtvalor.Text),
                id_marcas = (int)cb_marca.SelectedValue,
                id_categorias = (int)cb_categoria.SelectedValue
            };
            p.incluir();

            Limpar();
            CarregarnoDGV("");

        }

        public void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "") return;

            p = new Produtos()
            {
                id = int.Parse(txtid.Text),
                nome = txtnome.Text,
                id_categorias = (int)cb_categoria.SelectedValue,
                id_marcas = (int)cb_marca.SelectedValue,
                estoque = int.Parse(txtestoque.Text),
                valorvenda = double.Parse(txtvalor.Text),
                imagem = imagem.ImageLocation
            };
            p.alterar();

            Limpar();
            CarregarnoDGV("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "") return;

            if (MessageBox.Show("Deseja excluir o cliente?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                p = new Produtos()
                {
                    id = int.Parse(txtid.Text),
                };
                p.excluir();

                Limpar();
                CarregarnoDGV("");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            CarregarnoDGV("");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            CarregarnoDGV(txtpesquisa.Text);
            Limpar();
        }

        public void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                txtid.Text = dgv.CurrentRow.Cells["id"].Value.ToString();
                txtnome.Text= dgv.CurrentRow.Cells["nome"].Value.ToString();
                cb_marca.Text = dgv.CurrentRow.Cells["id_marcas"].Value.ToString();
                cb_categoria.Text = dgv.CurrentRow.Cells["id_categorias"].Value.ToString();
                txtestoque.Text = dgv.CurrentRow.Cells["estoque"].Value.ToString();
                txtvalor.Text = dgv.CurrentRow.Cells["valorvenda"].Value.ToString();
            }
        }

       

        private void Produto_Load(object sender, EventArgs e)
        {
            c = new Categoria();
            cb_categoria.DataSource = c.consulta();
            cb_categoria.DisplayMember = "nome";
            cb_categoria.ValueMember = "id";

            m = new marcas();
            cb_marca.DataSource = m.consultar();
            cb_marca.DisplayMember = "nome";
            cb_marca.ValueMember = "id";

            Limpar();
           CarregarnoDGV("");

            dgv.Columns["id_categorias"].Visible = false;
            dgv.Columns["id_marcas"].Visible = false;
            dgv.Columns["imagem"].Visible = false;

        }

       
    }

}
