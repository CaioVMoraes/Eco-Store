using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Telas
{
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        Business.EstoqueBusiness    estoqueBusiness =   new Business.EstoqueBusiness();
        Business.ProdutoBusiness    produtoBusiness =   new Business.ProdutoBusiness();
        Business.VendaBusiness      vendaBusiness =     new Business.VendaBusiness();
        Business.ClienteBusiness    clienteBusiness =   new Business.ClienteBusiness();

        private void label15_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto produto = listBox1.SelectedItem as Model.tb_produto;

                List<Model.tb_estoque> estoque = estoqueBusiness.ConsultarEstoqueId(produto.id_produto);

                if (estoque.Count != 0)
                {
                    List<Model.tb_estoque> itens = dgvProdutos.DataSource as List<Model.tb_estoque>;

                    if (itens == null)
                    {
                        itens = new List<Model.tb_estoque>();
                    }

                    tb_estoque estoqueModelo = estoqueBusiness.ListarAlterarNaoVendidos(produto.id_produto);

                    itens.Add(estoqueModelo);

                    dgvProdutos.AutoGenerateColumns = false;
                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = itens;

                    decimal total = itens.Sum(x => x.vl_valor);

                    lblTotal.Text = total.ToString();
                    lblRestante.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Produto Indisponivel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                //Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

                //Image imagem = imageConverter.byteArrayToImage(Autenticacao.Usuario.UsuarioLogado.Foto);

                //imgUsuario.Image = imagem;

                lblUsuario.Text = Autenticacao.Usuario.UsuarioLogado.Nome;

                List<tb_produto> lista = produtoBusiness.ConsultarTodosProdutos();

                listBox1.DisplayMember = nameof(tb_produto.nm_produto);
                listBox1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Model.tb_estoque> itens = dgvProdutos.DataSource as List<Model.tb_estoque>;
                tb_cliente cliente = clienteBusiness.ListarClienteCpf(txtCPFCliente.Text);

                Model.tb_venda venda = new Model.tb_venda();

                if (txtCPFCliente.Visible == true)
                    venda.id_cliente = cliente.id_cliente;

                else
                    venda.id_cliente = null;

                venda.id_usuario = Autenticacao.Usuario.UsuarioLogado.IDUsuario;
                venda.dt_saida = DateTime.Now;
                venda.vl_valorTotal = Convert.ToDecimal(lblTotal.Text);

                vendaBusiness.InserirVenda(venda);

                Model.tb_venda_item vendaItem = new Model.tb_venda_item();

                if (lblRestante.Text == "0,00")
                {
                    foreach (var item in itens)
                    {
                        vendaItem.id_venda = venda.id_venda;
                        vendaItem.id_estoque = item.id_estoque;

                        vendaBusiness.InserirVendaItem(vendaItem);
                    }

                    MessageBox.Show("Pedido finalizado com sucesso");

                    dgvProdutos.DataSource = null;

                    lblTotal.Text = "0,00";
                    lblTroco.Text = "0,00";
                    lblRestante.Text = "0,00";
                    nudPago.Value = 0;
                    txtCPFCliente.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Valor não foi liquidado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(txtCPFCliente.Visible == true)
            {
                txtCPFCliente.Visible = false;
            }

            else
            {
                txtCPFCliente.Visible = true;
            }
        }

        private void nudPago_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal total = Convert.ToDecimal(lblTotal.Text);
                decimal pago = nudPago.Value;

                lblRestante.Text = (total - pago).ToString();

                if (pago == total)
                {
                    lblTroco.Text = "0,00";
                }

                if (pago > total)
                {
                    lblRestante.Text = "0,00";
                    lblTroco.Text = (pago - total).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
