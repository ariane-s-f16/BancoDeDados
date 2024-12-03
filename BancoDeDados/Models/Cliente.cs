using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BancoDeDados.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; } 

        public int id_cidade {  get; set; }
        public DateTime data_nascimento { get; set; }

        public decimal renda { get; set; }

        public string cpf { get; set; }

        public string foto { get; set; }

        public bool venda { get; set; }


        public void incluir() 
        {
            try
            {
                banco.abrirconexao();

                banco.comando = new MySqlCommand("Insert into clientes (nome, id_cidade, data_nascimento, renda, cpf, venda, foto)" + "values (@nome, @id_cidade, @data_nascimento, @renda, @cpf, @venda, @foto)", banco.conexao);


                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                banco.comando.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                banco.comando.Parameters.AddWithValue("@renda", renda);
                banco.comando.Parameters.AddWithValue("@cpf", cpf);
                banco.comando.Parameters.AddWithValue("@foto", foto);
                banco.comando.Parameters.AddWithValue("@venda", venda);

                banco.comando.ExecuteNonQuery();
                banco.conexao.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

         public void excluir()
        {
            try
            {
                banco.abrirconexao();

                banco.comando = new MySqlCommand("DELETE FROM clientes WHERE id = @id", banco.conexao);
                banco.comando.Parameters.AddWithValue("@id", id);
                banco.comando.ExecuteNonQuery();

                banco.fecharconexao();
            }
             catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable consulta()
        {
            try
            {
                banco.abrirconexao();

                banco.comando = new MySqlCommand("SELECT cl.*, ci.nome cidade, ci.uf FROM clientes cl INNER JOIN cidades ci on (ci.id = cl.id_cidade) where cl.nome like ?nome order by cl.nome", banco.conexao);
                banco.comando.Parameters.AddWithValue("@nome", nome + "%");
                banco.adaptador = new MySqlDataAdapter(banco.comando);
                banco.dataTable = new DataTable();
                banco.adaptador.Fill(banco.dataTable);

                return banco.dataTable;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }       
        }

         public void alterar()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("UPDATE clientes SET nome = @nome, id_cidade= @id_cidade, data_nascimento= @data_nascimento," +
                    "renda= @renda, cpf= @cpf, foto= @foto, venda= @venda WHERE id = @id ", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                banco.comando.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                banco.comando.Parameters.AddWithValue("@renda", renda);
                banco.comando.Parameters.AddWithValue("@cpf", cpf);
                banco.comando.Parameters.AddWithValue("@foto", foto);
                banco.comando.Parameters.AddWithValue("@venda", venda);
                banco.comando.Parameters.AddWithValue("@id", id);
                banco.comando.ExecuteNonQuery();

                banco.fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        




    }
}
