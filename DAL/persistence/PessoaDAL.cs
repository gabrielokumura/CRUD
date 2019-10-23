using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;
using System.Data.SqlClient;


namespace DAL.persistence
{
    public class PessoaDAL : Conexao
    {
        //metodo - Gravar dados(insert)
        public void Gravar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Pessoa (Nome, Endereco, Email) values (@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);

                Cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao gravar pessoa " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }

        //metodo para atualizar dados (update)

        public void atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Pessoa set Nome=@v1,Endereco=@v2,Email=@v3 where codigo = @v4", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);

                Cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao atualizar pessoa" + ex.Message);

            }
            finally
            {
                FecharConexao();
            }
        }

        //metodo para excluir dados (delete)

        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Pessoa where Codigo=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao excluir dados " + ex.Message);
            }
            finally
            {
                FecharConexao();

            }
        }

        //metodo para obter dados de uma pessoa por codigo 

        public Pessoa PesquisaPorCodigo(int codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa where Codigo=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Dr = Cmd.ExecuteReader();

                Pessoa p = null;
                if (Dr.Read())
                {
                    p = new Pessoa();

                    p.Codigo   = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome     = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email    = Convert.ToString(Dr["Email"]);
                }

                return p;


            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao pesquisar por codigo" + ex.Message);
            }
            finally
            {
                FecharConexao();

            }
        }

        //metodo para listar todas as pessoas 

        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa", Con);
                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Codigo   = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome     = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email    = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }

                return lista;



            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao listar pessoas:" + ex.Message);

            }
            finally
            {
                FecharConexao();
            }

        }

    }
}
