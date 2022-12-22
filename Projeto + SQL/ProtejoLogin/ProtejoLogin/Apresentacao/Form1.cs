using ProtejoLogin.Apresentacao;
using ProtejoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtejoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(textBox1.Text, textBox2.Text);
          if(controle.mensagem.Equals(""))
          { 
            if(controle.tem)
            {
                MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();

            }
            else
            {
                MessageBox.Show("Login Nao encontrado, Verificar Email e senha", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
