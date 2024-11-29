using BancoDeDados.Models;
using System;
using System.Windows.Forms;

namespace BancoDeDados.Views
{
    public partial class marca : Form
    {
        marcas ma;
       


        public marca()
        {
            InitializeComponent();
        }
        void limpar()
        {
           
            txtid.Clear();
            txtpesquisa.Clear();
            txtnome.Clear();
            

        }
        void carregarnoDGV(string pesquisa)
        {
            ma = new marcas()
            {
                marca = pesquisa
            };
            dgv.DataSource = ma.consultar();

        }

       

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "") return;

            ma = new marcas()
            {
                id = int.Parse(txtid.Text),
                marca = txtnome.Text,

            };

            ma.alterar();
            limpar();
            carregarnoDGV("");
        }

        private void btn_incluirmarca_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "") return;
            ma = new marcas()
            {
                marca = txtnome.Text

            };

            ma.incluir();
            limpar();
            carregarnoDGV("");
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            carregarnoDGV(txtpesquisa.Text);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar();
            carregarnoDGV("");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "") return;

            if (MessageBox.Show("Deseja excluir uma Marca? ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ma = new marcas()
                {
                    id = int.Parse(txtid.Text)
                };

                ma.excluir();
                limpar();
                carregarnoDGV("");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                txtid.Text = dgv.CurrentRow.Cells["id"].Value.ToString();
                txtnome.Text = dgv.CurrentRow.Cells["marca"].Value.ToString();


            }
        }
    }
}
