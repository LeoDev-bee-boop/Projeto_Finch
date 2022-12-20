using Projeto_Finch.Controller;
using Projeto_Finch.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Finch
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            //Instânciando classes
            APIController controller = new APIController();

            //Validação de Login
            if(controller.ValidarLogin(txtUsu.Text, txtSenha.Text) == true)
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha ou usuário incorretos, favor tentar novamente!",
                                "Atenção", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question);
            }
        }
    }
}
