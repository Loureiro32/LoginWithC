using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtejoLogin.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String Login, String senha)
        {
            cmd.CommandText = "select* from logins where email = @Login and senha = @senha";
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com a Base de Dados!";
            }

            return tem;
        }







        public String cadastrar(String email, String Senha, String confsenha)
        {
            tem = false;
            //Comandos para inserir
            if(Senha.Equals(confsenha))
            {
                cmd.CommandText = "insert into logins values(@e,@s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", Senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Registado com Sucesso";
                    tem = true;

                }
                catch(Exception)
                {
                    this.mensagem = "Erro com a Base de dados";
                }
            }
            else
            {
                this.mensagem = "Senha não compativel";
            }
           
            return mensagem;
        }
    }
}
