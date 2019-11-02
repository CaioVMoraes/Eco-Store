using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.Telas
{

    public partial class Menu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Menu()
        {
            InitializeComponent();
        }

        Business.ControleDePontoBusiness business = new Business.ControleDePontoBusiness();
        Model.tb_controledeponto ponto = new Model.tb_controledeponto();

        private void Menu_Load(object sender, EventArgs e)
        {
            lblNome.Text = Autenticacao.Usuario.UsuarioLogado.Nome;

            Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

            Image imagem = imageConverter.byteArrayToImage(Autenticacao.Usuario.UsuarioLogado.Foto);

            imgPerfil.Image = imagem;

            ponto.id_funcionario = Autenticacao.Usuario.UsuarioLogado.ID;

            ponto.dt_chegada = DateTime.Now;
            ponto.dt_saida = null;
            ponto.dt_saidaAlmoco = null;
            ponto.dt_voltaAlmoco = null;

            business.CadastrarPonto(ponto);
        }

        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Telas.frmCadastrarUsuario CadastrarUser = new frmCadastrarUsuario();
            CadastrarUser.Show();
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            Telas.Usuario.frmConsultarUsuario ConsultarUser = new Usuario.frmConsultarUsuario();
            ConsultarUser.Show();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Telas.frmCadastrarFuncionario CadastrarFunc = new frmCadastrarFuncionario();
            CadastrarFunc.Show();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            Telas.frmConsultarFuncionario ConsultarFunc = new frmConsultarFuncionario();
            ConsultarFunc.Show();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Telas.frmCadastroFornecedores Forne = new frmCadastroFornecedores();
            Forne.Show();
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            Telas.frmConsultarFornecedor ConsulForne = new frmConsultarFornecedor();
            ConsulForne.Show();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Telas.frmCadastrarProduto CadaProd = new frmCadastrarProduto();
            CadaProd.Show();
        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            Telas.frmConsultarProduto ConsuProd = new frmConsultarProduto();
            ConsuProd.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Telas.frmFluxoCaixa Caixa = new frmFluxoCaixa();
            Caixa.Show();
        }

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmConsultarEstoque ConsuEsto = new Estoque.frmConsultarEstoque();
            ConsuEsto.Show();
        }

        private void btnFluxoCaixa_Click(object sender, EventArgs e)
        {
            Telas.Fluxo_de_Caixa.frmFluxoDeCaixa Fluxo = new Fluxo_de_Caixa.frmFluxoDeCaixa();
            Fluxo.Show();
        }

        private void btnGerarFolhaPagamento_Click(object sender, EventArgs e)
        {
            Telas.nudSaude CadastrarFolha = new nudSaude();
            CadastrarFolha.Show();
        }

        private void btnDespesasEGastos_Click(object sender, EventArgs e)
        {
            Telas.Fluxo_de_Caixa.frmFluxoDeCaixa Fluxo = new Fluxo_de_Caixa.frmFluxoDeCaixa();
            Fluxo.Show();
        }

        private void btnConsultarFolhaPagamento_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Telas.frmAlterarFuncionario CadastrarFunc = new frmAlterarFuncionario();
            CadastrarFunc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.frmDeletarFuncionario CadastrarFunc = new frmDeletarFuncionario();
            CadastrarFunc.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Telas.Compra.frmTelaCompra CadastrarFunc = new Telas.Compra.frmTelaCompra();
            CadastrarFunc.Show();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            if (ponto.dt_saida == null)
            {
                MessageBox.Show("Saída não cadastrada");
            }
            else
            {
                Application.Exit();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Telas.Compra.frmConsultarCompra CadastrarFunc = new Telas.Compra.frmConsultarCompra();
            CadastrarFunc.Show();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblPausar_Click(object sender, EventArgs e)
        {
            ponto.dt_saidaAlmoco = DateTime.Now;

            business.AlterarPonto(ponto);

            lblPausar.Enabled = false;
            lblVoltarPausa.Enabled = true;
        }

        private void lblVoltarPausa_Click(object sender, EventArgs e)
        {
            ponto.dt_voltaAlmoco = DateTime.Now;

            business.AlterarPonto(ponto);

            lblVoltarPausa.Enabled = false;
        }

        private void lblDesligar_Click(object sender, EventArgs e)
        {
            ponto.dt_saida = DateTime.Now;

            business.AlterarPonto(ponto);

            lblDesligar.Enabled = false;

            //Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }
    }
}
