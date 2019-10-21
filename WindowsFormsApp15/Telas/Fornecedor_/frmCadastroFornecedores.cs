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
    public partial class frmCadastroFornecedores : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Business.FornecedorBusiness business = new Business.FornecedorBusiness();

            Model.tb_fornecedor model = new Model.tb_fornecedor();

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            Business.FornecedorBusiness business = new Business.FornecedorBusiness();

            Model.tb_fornecedor model = new Model.tb_fornecedor();

            model.nm_fornecedor = txtNome.Text;
            model.nm_empresa = txtEmpresa.Text;
            model.ds_celular = txtCelular.Text;
            model.ds_cep = txtCEP.Text;
            model.ds_cidade = txtCidade.Text;
            model.ds_cnpj = txtCNPJ.Text;
            model.ds_complemento = txtComplemento.Text;
            model.ds_endereco = txtEndereco.Text;
            model.ds_telefone = txtTelefone.Text;
            model.ds_UF = txtUF.Text;

            business.CadastrarFornecedor(model);

            MessageBox.Show("Cadastrado com sucesso");
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
    }
}
