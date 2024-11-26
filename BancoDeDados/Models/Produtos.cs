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
        public int preco { get; set; }

        public int valorvenda { get; set; }
        public int id_marcas { get; set; }
        public int id_categorias { get; set; }
        public string estoque { get; set; }

        public string imagem { get; set; }

        public void incluir()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("insert into produto (nome, preco, estoque, valorvenda, id_marcas, id_categorias ) VALUES (@nome, @preco, @estoque, @valorvenda, @id_marcas, @id_categorias, @imagem)", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@preco", preco);
                banco.comando.Parameters.AddWithValue("@estoque", estoque);
                banco.comando.Parameters.AddWithValue("@valorvenda", valorvenda);
                banco.comando.Parameters.AddWithValue("@id_marcas", id_marcas);
                banco.comando.Parameters.AddWithValue("@id_categorias", id_categorias);
                banco.comando.Parameters.AddWithValue("@imagem", imagem);


                banco.comando.ExecuteNonQuery();
                banco.fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void alterar()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("update produto set nome = @nome, uf = @uf where id= @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@estoque", estoque);
                banco.comando.Parameters.AddWithValue("@preco", preco);
                banco.comando.Parameters.AddWithValue("@valorvenda", valorvenda);
                banco.comando.Parameters.AddWithValue("@id_marcas", id_marcas);
                banco.comando.Parameters.AddWithValue("@id_categorias", id_categorias);
                banco.comando.Parameters.AddWithValue("@imagem", imagem);

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
                banco.comando = new MySqlCommand("delete from produto where id= @id", banco.conexao);

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

                banco.comando = new MySqlCommand("SELECT cl.*, ci.nome marcas, ci.uf FROM categorias cl" +
                    "inner join cidades ci ON cl.id_cidade = ci.id WHERE cl.nome LIKE ?nome ORDER BY cl.nome", banco.conexao);
                banco.comando.Parameters.AddWithValue("@nome", nome + "%");
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
