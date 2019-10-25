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
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Telas.Compra
{
    public partial class frmTelaCompra : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmTelaCompra()
        {
            InitializeComponent();
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

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Business.ProdutoBusiness produtoBusiness = new Business.ProdutoBusiness();
        private void frmTelaCompra_Load(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto produto = listProduto.SelectedItem as Model.tb_produto;

                List<Model.tb_produto> itens = dgvProdutos.DataSource as List<Model.tb_produto>;

                    if (itens == null)
                    {
                        itens = new List<Model.tb_produto>();
                    }

                    tb_produto produtoModelo = produtoBusiness.Listar(produto.id_produto);

                    itens.Add(produtoModelo);

                    dgvProdutos.AutoGenerateColumns = false;
                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = itens;

                    decimal total = itens.Sum(x => x.vl_valor);

                    lblTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            {
                //try
                //{
                //    Business.c
                //    List<Model.tb_estoque> itens = dgvProdutos.DataSource as List<Model.tb_estoque>;

                //    Model.tb_venda venda = new Model.tb_venda();

                //    if (txtCPFCliente.Visible == true)
                //    {
                //        tb_cliente cliente = clienteBusiness.ListarClienteCpf(txtCPFCliente.Text);
                //        venda.id_cliente = cliente.id_cliente;
                //    }
                //    else
                //    {
                //        venda.id_cliente = null;
                //    }

                //    venda.id_usuario = Autenticacao.Usuario.UsuarioLogado.IDUsuario;
                //    venda.dt_saida = DateTime.Now;
                //    venda.vl_valorTotal = Convert.ToDecimal(lblTotal.Text);

                //    .InserirVenda(venda);

                //    Model.tb_venda_item vendaItem = new Model.tb_venda_item();

                //    if (lblRestante.Text == "0,00")
                //    {
                //        foreach (var item in itens)
                //        {
                //            vendaItem.id_venda = venda.id_venda;
                //            vendaItem.id_estoque = item.id_estoque;

                //            vendaBusiness.InserirVendaItem(vendaItem);
                //        }

                //        MessageBox.Show("Pedido finalizado com sucesso");

                //        dgvProdutos.DataSource = null;

                //        lblTotal.Text = "0,00";
                //    }
                //    else
                //    {
                //        MessageBox.Show("Valor não foi liquidado");
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
    }
}