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
    public class marcas
    {
        
            public int id { get; set; }

            public string nome { get; set; }

            public void incluir()
            {
                try
                {
                    banco.abrirconexao();

                    banco.comando = new MySqlCommand("INSERT INTO marcas (nome) VALUES (@nome)", banco.conexao);

                    banco.comando.Parameters.AddWithValue("@nome", nome);

                    banco.comando.ExecuteNonQuery();

                    banco.fecharconexao();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        public void alterar()
        {
            try
            {
                banco.abrirconexao();

                banco.comando = new MySqlCommand("UPDATE marcas SET nome = @nome WHERE id = @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@id", id);

                banco.comando.ExecuteNonQuery();

                banco.fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void excluir()
        {
            try
            {
                banco.abrirconexao();

                banco.comando = new MySqlCommand("DELETE FROM marcas WHERE id = @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@id", id);
                banco.comando.ExecuteNonQuery();

                banco.fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable consultar()
        {
            try
            {
                banco.abrirconexao();
                banco.comando = new MySqlCommand("SELECT * FROM marcas WHERE nome like @nome " +
                    "order by nome", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome + "%");
                

                banco.adaptador = new MySqlDataAdapter(banco.comando);
                banco.dataTable = new DataTable();
                banco.adaptador.Fill(banco.dataTable);

                banco.fecharconexao();
                return banco.dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }

}
