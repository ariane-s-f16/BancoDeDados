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
                conexao = new MySqlConnection("server=localhost, port=3307, uid=root, pwd=etecjau ");

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
                comando = new MySqlCommand("create database if not exists vendas; use vendas", conexao);

                comando.ExecuteNonQuery();

                comando = new MySqlCommand("create table if not exists cidades" +"(id int auto_increment primary key,"+"nome varchar (40) not null,"+"uf char (02))", conexao);

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
