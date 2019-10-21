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

        Business.EstoqueBusiness estoqueBusiness = new Business.EstoqueBusiness();
        Business.ProdutoBusiness produtoBusiness = new Business.ProdutoBusiness();

        private void label15_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto produto = listBox1.SelectedItem as Model.tb_produto;

                List<Model.tb_estoque> estoque = estoqueBusiness.ConsultarEstoqueId(produto.id_produto);

                if (estoque.Count != 0)
                {
                    List<Model.tb_estoque> itens = dataGridView1.DataSource as List<Model.tb_estoque>;

                    if (itens == null)
                    {
                        itens = new List<Model.tb_estoque>();
                    }

                    tb_estoque estoqueModelo = estoqueBusiness.ListarAlterarNaoVendidos(produto.id_produto);

                    itens.Add(estoqueModelo);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = itens;

                    decimal total = itens.Sum(x => x.vl_valor);

                    label1.Text = "R$" + total;
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
            List<tb_produto> lista = produtoBusiness.ConsultarTodosProdutos();

            listBox1.DisplayMember = nameof(tb_produto.nm_produto);
            listBox1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.


            List<Model.tb_estoque> itens = dataGridView1.DataSource as List<Model.tb_estoque>;

            foreach (var item in itens)
            {
                
            }
        }
    }
}
