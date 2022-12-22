using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtejoLogin.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Estabelce Conexao com a BD
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-52JV8T1\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close(); 
            }

        }


    }
}
