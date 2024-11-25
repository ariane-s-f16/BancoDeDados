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

        public double renda { get; set; }

        public string cpf { get; set; }

        public string foto { get; set; }

        public bool venda { get; set; }


        public void incluir() 
        {
            try
            {
                banco.abrirconexao();

                banco.comando = new MySqlCommand("Insert into clientes (nome, id_cidade, dat_nascimento, renda, cpf, venda)" + "values (@nome, @id_cidade, @data_nascimento, @renda, @cpf, @foto, @ venda)", banco.conexao);


                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                banco.comando.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                banco.comando.Parameters.AddWithValue("@renda", renda);
                banco.comando.Parameters.AddWithValue("@cpf", cpf);
                banco.comando.Parameters.AddWithValue("@venda", venda);
                banco.comando.Parameters.AddWithValue("@foto", foto);

                banco.comando.ExecuteNonQuery();
                banco.conexao.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

         public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("DELETE FROM clientes WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", Id);
                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
             catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable Consulta()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("SELECT cl.*, ci.nome cidade, ci.uf FROM clientes cl" +
                    "inner join cidades ci ON cl.idCidade = ci.id WHERE cl.nome LIKE ?nome ORDER BY cl.nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", Nome + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);

                return Banco.datTabela;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }       
        }

         public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("UPDATE clientes SET nome = @nome, id_cidade = @id_cidade, data_nascimento = @data_nascimento," +
                    "renda = @renda, cpf = @cpf, foto = @foto, venda = @venda WHERE id = @id ", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@nome", Nome);
                Banco.Comando.Parameters.AddWithValue("@id_cidade", IdCidade);
                Banco.Comando.Parameters.AddWithValue("@data_nascimento", DataNasc);
                Banco.Comando.Parameters.AddWithValue("@renda", Renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", Foto);
                Banco.Comando.Parameters.AddWithValue("@venda", Venda);
                Banco.Comando.Parameters.AddWithValue("@id", Id);
                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        
        
    }
}
