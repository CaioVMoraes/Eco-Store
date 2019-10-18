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

namespace WindowsFormsApp15.Telas.Estoque
{
    public partial class frmAlterarEstoque : Form
    {
        public frmAlterarEstoque()
        {
            InitializeComponent();
        }

        Business.EstoqueBusiness business = new Business.EstoqueBusiness();
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);

                tb_estoque modelo = business.Listar(id);

                modelo.id_produto = Convert.ToInt32(txtNomeProduto.Text);
                modelo.dt_entrada = dtpData.Value;
                modelo.vl_valor = nudValor.Value;

                if (rdnSim.Checked == true)
                {
                    modelo.bt_vendido = true;
                }
                if (rdnNao.Checked == true)
                {
                    modelo.bt_vendido = false;
                }

                business.AlterarEstoque(modelo);

                MessageBox.Show("Alterado com sucesso");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);

                tb_estoque estoque = business.Listar(id);

                txtNomeProduto.Text = Convert.ToString(estoque.id_produto);
                dtpData.Value = estoque.dt_entrada;
                nudValor.Value = estoque.vl_valor;

                if (estoque.bt_vendido == true)
                {
                    rdnSim.Checked = true;
                }
                if (estoque.bt_vendido == false)
                {
                    rdnNao.Checked = true;
                }

                Business.ProdutoBusiness produtoBusiness = new Business.ProdutoBusiness();
                tb_produto produto = produtoBusiness.Listar(estoque.id_produto);

                txtNomeProduto.Text = produto.nm_produto;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
