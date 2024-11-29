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

        public int valorvenda { get; set; }
        public int id_marca { get; set; }
        public int id_categoria { get; set; }
        public int estoque { get; set; }

        public string imagem { get; set; }

        public void incluir()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("insert into produtos (nome, estoque, valorvenda, id_marca, id_categoria, imagem ) VALUES (@nome, @estoque, @valorvenda, @id_marca, @id_categoria, @imagem)", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@estoque", estoque);
                banco.comando.Parameters.AddWithValue("@valorvenda", valorvenda);
                banco.comando.Parameters.AddWithValue("@id_marcas", id_marca);
                banco.comando.Parameters.AddWithValue("@id_categorias", id_categoria);
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
                banco.comando = new MySqlCommand("update produtos set nome = @nome, uf = @uf where id= @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@estoque", estoque);
                banco.comando.Parameters.AddWithValue("@valorvenda", valorvenda);
                banco.comando.Parameters.AddWithValue("@id_marcas", id_marca);
                banco.comando.Parameters.AddWithValue("@id_categorias", id_categoria);
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

                banco.comando = new MySqlCommand("SELECT p.*, m.marcas, c.categorias FROM produtos p inner join marcas m on (m.id = p.id_marca) " +
                                                    "inner join categorias c on (c.id = p.id_categoria) ", banco.conexao);
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
