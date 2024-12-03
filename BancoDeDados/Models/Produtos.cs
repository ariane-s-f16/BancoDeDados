using BancoDeDados.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados.Models
{
    public class Produtos
    {

        public int id { get; set; }
        public string nome { get; set; }
        public double valorvenda { get; set; }
        public int id_marcas { get; set; }
        public int id_categorias { get; set; }
        public int estoque { get; set; }
        public string descricao { get; set; }

        public string imagem { get; set; }

        public void incluir()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("INSERT INTO produtos (nome, id_categorias, id_marcas, estoque, valorvenda, imagem, descricao) VALUES (@nome, @id_categorias, @id_marcas, @estoque, @valorvenda, @imagem, @descricao)", banco.conexao);
                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@id_categorias", id_categorias);
                banco.comando.Parameters.AddWithValue("@id_marcas", id_marcas);
                banco.comando.Parameters.AddWithValue("@estoque", estoque);
                banco.comando.Parameters.AddWithValue("@valorvenda", valorvenda);
                banco.comando.Parameters.AddWithValue("@imagem", imagem);
                banco.comando.Parameters.AddWithValue("@descricao", descricao);
                banco.comando.ExecuteNonQuery();
                banco.conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void alterar()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("update produtos set nome = @nome, id_categorias = @id_categorias, id_marcas = @id_marcas, estoque = @estoque, valorvenda = @valorvenda, imagem = @imagem, descricao= @descricao where id= @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@estoque", estoque);
                banco.comando.Parameters.AddWithValue("@valorvenda", valorvenda);
                banco.comando.Parameters.AddWithValue("@id_marcas", id_marcas);
                banco.comando.Parameters.AddWithValue("@id_categorias", id_categorias);
                banco.comando.Parameters.AddWithValue("@imagem", imagem);
                banco.comando.Parameters.AddWithValue("@descricao", descricao);
                banco.comando.Parameters.AddWithValue("@id", id);

                banco.comando.ExecuteNonQuery();
                banco.fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void excluir()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("delete from produtos where id= @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@id", id);

                banco.comando.ExecuteNonQuery();
                banco.fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public DataTable consulta()
        {
            try
            {
                banco.abrirconexao();

                banco.comando = new MySqlCommand("SELECT p.*, c.nome categorias, m.marca marcas FROM produtos p INNER JOIN categorias c on (c.id = p.id_categorias)" +
                    " INNER JOIN marcas m on (m.id = p.id_marcas) where p.nome like ?descricao order by p.descricao", banco.conexao);
                banco.comando.Parameters.AddWithValue("@descricao", descricao + "%");
                banco.adaptador = new MySqlDataAdapter(banco.comando);
                banco.dataTable = new DataTable();
                banco.adaptador.Fill(banco.dataTable);

                return banco.dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
