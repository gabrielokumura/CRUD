using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;



namespace DAL.persistence
{
    public class Conexao
    {
        

        //atributos 
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Metodo-Abrir conexao
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection(@"Data Source=DESKTOP-IONUJNJ\SQLEXPRESS;Initial Catalog=bdteste;Integrated Security=True");
                Con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        //Metodo-Fechar conexao
        protected void FecharConexao()
        {

            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }
    }
}





