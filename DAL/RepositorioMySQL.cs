using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class RepositorioMySQL : IRepositorio
    {
        private readonly string stringDeConexao = "server=localhost;user id=root;pwd=12345678;database=celulares";
        private void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            MySqlConnection con = ObterConexao();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                foreach (MySqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void Inserir(Celular celular)
        {
            try
            {
                ExecuteNonQuery($"INSERT INTO celular (marca, modelo, qualidadeTela, tamanho) values (@Marca,@Modelo,@QualidadeTela, @Tamanho)", new MySqlParameter("@marca", celular.Marca), new MySqlParameter("@Modelo", celular.Modelo), new MySqlParameter("@QualidadeTela", celular.QualidadeTela), new MySqlParameter("@Tamanho", celular.Tamanho) );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Deletar(int id)
        {
            try
            {
                ExecuteNonQuery($"DELETE FROM celular WHERE id = @id", new MySqlParameter("@id", id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Celular Consultar(string modelo)
        {
            Celular cel = null;
            MySqlConnection con = ObterConexao();
            MySqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(con, $"SELECT * FROM celular WHERE modelo like @modelo", new MySqlParameter("@modelo", modelo));
                while (dr.Read())
                {
                    cel = new Celular(dr.GetInt32("Id"), dr.GetString("Marca"), dr.GetString("Modelo"), dr.GetString("QualidadeTela"), dr.GetInt32("Tamanho"));
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexaoEDataReader(con, dr);
            }
            return cel;
        }

        public List<Celular> Listar()
        {
            List<Celular> clientes = null;
            MySqlConnection con = ObterConexao();
            MySqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(con, $"SELECT * FROM Celular");
                if (dr.HasRows)
                {
                    clientes = new List<Celular>();
                    while (dr.Read())
                    {
                        clientes.Add(new Celular(dr.GetInt32("Id"), dr.GetString("Marca"), dr.GetString("Modelo"), dr.GetString("QualidadeTela"), dr.GetInt32("Tamanho")));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexaoEDataReader(con, dr);
            }
            return clientes;
        }

        private static void FecharConexaoEDataReader(MySqlConnection con, MySqlDataReader dr)
        {
            con.Close();
            if (dr != null)
            {
                dr.Close();
            }
        }

        private static MySqlDataReader ExecuteReader(MySqlConnection con, string sql, params MySqlParameter[] parameters)
        {
            MySqlDataReader dr;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            foreach (MySqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            dr = cmd.ExecuteReader();
            return dr;
        }

        private MySqlConnection ObterConexao()
        {
            return new MySqlConnection(stringDeConexao);
        }
    }
}
