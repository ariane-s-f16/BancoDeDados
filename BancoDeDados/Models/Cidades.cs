using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BancoDeDados.Models
{
    public class Cidades
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }

        public void incluir () 
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("insert into cidade (nome, uf ) VALUES (@nome, @uf)", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@uf", uf);

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
                banco.comando = new MySqlCommand("update cidade set nome = @nome, uf = @uf where id= @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@uf", uf);
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
                banco.comando = new MySqlCommand("delete from cidade where id= @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@id", id);

                banco.comando.ExecuteNonQuery();
                banco.fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public  DataTable consulta()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("select * from cidade set where nome like @nome" + "order by nome", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome + "%");
               
                banco.adaptador = new MySqlDataAdapter(banco.comando); 
                banco.dataTable = new DataTable();
                banco.adaptador.Fill(banco.dataTable);
                
                banco.fecharconexao();

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
