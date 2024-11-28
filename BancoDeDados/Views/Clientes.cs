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
     internal partial class Clientes : Form
    {

        Cidades ci;
        Cliente cl;
        public Clientes()
        {
            InitializeComponent();
        }
        void limpar()
        {
            txtuf.Clear();
            txtid.Clear();
            txtpesquisa.Clear();
            txtnome.Clear();
            imagem.ImageLocation = "";
            mask_cpf.Clear();
            cb_cidade.SelectedIndex = -1;
            ck_bloquear.Checked = false;

        }

        void carregarnoDGV(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            dvg.DataSource = cl.consulta();

        }
        private void Clientes_Load(object sender, EventArgs e)
        {

            ci= new Cidades();
            cb_cidade.DataSource = ci.consulta();
            cb_cidade.DisplayMember = "nome";
            cb_cidade.ValueMember ="id" ;

            limpar();
            carregarnoDGV("");

            dvg.Columns["id_cidade"].Visible = false;
            dvg.Columns["foto"].Visible = false;

        }

        private void cb_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cidade.SelectedIndex != -1) 
            {
                DataRowView reg =(DataRowView)cb_cidade.SelectedItem;
                txtuf.Text = reg["uf"].ToString();
            }
        }

        private void imagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:/fotos/clientes/";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            imagem.ImageLocation = openFileDialog1.FileName;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "") return;
            cl = new Cliente()
            {
                nome = txtnome.Text,
                id_cidade = (int)cb_cidade.SelectedValue,
                data_nascimento = data.Value,
                renda = decimal.Parse(txtrenda.Text),
                cpf = mask_cpf.Text,
                foto= imagem.ImageLocation,
                venda= ck_bloquear.Checked
            };

            cl.incluir();
            limpar();
            carregarnoDGV("");
        }

        private void dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvg.RowCount > 0 ) 
            {
                txtid.Text = dvg.CurrentRow.Cells["id"].Value.ToString();
                txtuf.Text = dvg.CurrentRow.Cells["uf"].Value.ToString();
                cb_cidade.Text = dvg.CurrentRow.Cells["cidade"].Value.ToString();
                ck_bloquear.Checked = (bool)dvg.CurrentRow.Cells["venda"].Value;
                data.Text = dvg.CurrentRow.Cells["data_nascimento"].Value.ToString();
                txtnome.Text = dvg.CurrentRow.Cells["nome"].Value.ToString();
                txtrenda.Text = dvg.CurrentRow.Cells["renda"].Value.ToString();
                mask_cpf.Text = dvg.CurrentRow.Cells["cpf"].Value.ToString();
                imagem.ImageLocation = dvg.CurrentRow.Cells["foto"].Value.ToString();

            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "") return;

            cl = new Cliente()
            {
                id = int.Parse(txtid.Text),
                nome = txtnome.Text,
                id_cidade = (int)cb_cidade.SelectedValue,
                data_nascimento = data.Value,
                renda = decimal.Parse(txtrenda.Text),
                cpf = mask_cpf.Text,
                foto = imagem.ImageLocation,
                venda = ck_bloquear.Checked
            };

            cl.alterar();
            limpar();
            carregarnoDGV("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(txtid.Text == "") return ;

            if(MessageBox.Show("Deseja excluir cliente? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                cl = new Cliente()
                {
                    id = int.Parse(txtid.Text)
                };

                cl.excluir();
                limpar();
                carregarnoDGV("");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar();
            carregarnoDGV("");
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            carregarnoDGV(txtpesquisa.Text);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
