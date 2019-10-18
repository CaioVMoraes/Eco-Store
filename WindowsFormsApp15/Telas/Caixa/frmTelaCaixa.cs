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
            Model.tb_produto produto = listBox1.SelectedItem as Model.tb_produto;

            List<Model.tb_estoque> estoque = estoqueBusiness.ConsultarEstoqueId(produto.id_produto);

            if(estoque != null)
            {
                List<Model.tb_produto> itens = dataGridView1.DataSource as List<Model.tb_produto>;
                if (itens == null)
                    itens = new List<Model.tb_produto>();

                itens.Add(produto);


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = itens;
            }
            else
            {
                MessageBox.Show("Produto Indisponivel");
            }
        }

        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            List<tb_produto> lista = produtoBusiness.ConsultarTodosProdutos();

            listBox1.DataSource = lista.Select(x => x.nm_produto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.
        }
    }
}
