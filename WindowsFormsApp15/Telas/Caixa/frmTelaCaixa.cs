using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.Telas
{
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Model.tb_produto produto = listBox1.SelectedItem as Model.tb_produto;

            // business pra ver se tem item no stock


            List<Model.tb_produto> itens = dataGridView1.DataSource as List<Model.tb_produto>;
            if (itens == null)
                itens = new List<Model.tb_produto>();

            itens.Add(produto);


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = itens;
        }
    }
}
