using ProtejoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtejoLogin.Modelo
{
  public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.verificarLogin(login, senha);
            if(!LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String Senha, String confSenha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            this.mensagem = LoginDao.cadastrar(email, Senha, confSenha);
            if(LoginDao.tem)
            {
                this.tem = true;
            }

            return mensagem;
        }
    }
}
