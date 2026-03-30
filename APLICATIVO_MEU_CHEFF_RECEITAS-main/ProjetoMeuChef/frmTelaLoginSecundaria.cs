using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMeuChef
{
    public partial class frmTelaLoginSecundaria : Form
    {
        public frmTelaLoginSecundaria()
        {
            InitializeComponent();
        }

        private void btnEntreAqui_Click(object sender, EventArgs e)
        {
            int NomeFuncionario = txtNomeFuncionario.Text;
            int SenhaFuncionario = txtSenhaFuncionario.Text;
            string Funcao = cbFuncionarios.Text;

            CredenciaisFuncionarios cf = new CredenciaisFuncionarios();

            if (cf.CredenciaisAjudante)
            {
                this.Visible = false;//fecha a tela
            }
            else
            {
                MessageBox.Show("Credenciais incorretas. Tente novamente!");
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
