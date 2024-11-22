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
    }
}
