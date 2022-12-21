using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Projeto_Finch.Controller;

namespace Projeto_Finch.View
{
    public partial class frmPrincipal : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #region ..:: Construtor::..
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #endregion ..:: Construtor::..

        #region ..:: Métodos ::..
        private void AdicionaValores(Bored bored)
        {
            txtRespostaAtividade.Text = bored.activity.ToString();
            txtRespostaTipo.Text = bored.type.ToString();
            txtRespostaParticipantes.Text = bored.participants.ToString();
            txtRespostasPrecos.Text = bored.price.ToString();
            txtRespostaLinks.Text = bored.link.ToString();
            txtRespostaChave.Text = bored.key.ToString();
            txtRespostaAcessibilidade.Text = bored.accessibility.ToString();
        }
        #endregion ..:: Métodos ::..

        #region ..:: Eventos ::..
        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Instânciando classes
            APIController controller = new APIController();
            Bored bored = new Bored();

            //Inicia o form buscando os dados da bored API 
            bored = await controller.BuscarDadosApi();

            if (bored == null)
                return;

            //Adicionando valores aos labels
            AdicionaValores(bored);
        }

        private void panCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private async void btnCarregarProxima_Click(object sender, EventArgs e)
        {
            //Instânciando classes
            APIController controller = new APIController();
            Bored bored = new Bored();

            //Inicia o form buscando os dados da bored API 
            bored = await controller.BuscarDadosApi();

            //Validando retorno da API
            if (bored == null)
                return;

            //Adicionando valores aos labels
            AdicionaValores(bored);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion ..:: Eventos ::..
    }
}
