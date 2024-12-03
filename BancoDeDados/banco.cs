using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BancoDeDados
{
    public class banco
    {
        public static MySqlConnection conexao;
        public static MySqlCommand comando;
        public static MySqlDataAdapter adaptador ;
        public static DataTable dataTable;


        public static void abrirconexao()
        {
            try
            {
                conexao = new MySqlConnection("server=localhost; port=3307; uid=root; pwd=etecjau ");

                conexao.Open();
                comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS BancoDeDados;  USE BancoDeDados", conexao);

                comando.ExecuteNonQuery();
                conexao.Close();

                conexao = new MySqlConnection("server=localhost; port=3307; uid=root; pwd=etecjau; database=BancoDeDados ");

                conexao.Open();
            }
            catch ( Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void fecharconexao()
        {
            try
            {

                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }
        public static void criarbanco()
        {
            try
            {
                abrirconexao();
                

                comando = new MySqlCommand("create table if not exists cidades( " + 
                    "id int auto_increment primary key, "+" nome varchar (40), " + " uf char (02))", conexao);

                comando.ExecuteNonQuery();

                comando = new MySqlCommand("create table if not exists marcas( " + "id int auto_increment primary key," +"marca varchar (20))", conexao);

                comando.ExecuteNonQuery();

                comando = new MySqlCommand("create table if not exists categorias( " + "id int auto_increment primary key," + "nome varchar (50))", conexao);

                comando.ExecuteNonQuery();

                comando = new MySqlCommand("create table if not exists clientes ( " + "id int auto_increment primary key," + "nome char (40) not null, " + "id_cidade int, "+ "data_nascimento date, "+ "renda decimal(10,2), "+"cpf varchar(14), "+ "foto varchar(50), " + "venda boolean)", conexao);

                comando.ExecuteNonQuery();

                comando = new MySqlCommand("create table if not exists produtos(" +
                    "id int auto_increment primary key, " +
                    "nome varchar(100)," +
                    "id_categorias integer, " +
                    "id_marcas integer, " +
                    "imagem varchar(100)," +
                    "estoque int, " +
                    "valorvenda decimal(10,2))", conexao);

                comando.ExecuteNonQuery();


                fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


    }
        

    
}
