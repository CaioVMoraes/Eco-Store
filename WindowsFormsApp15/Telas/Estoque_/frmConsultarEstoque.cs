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
    public partial class frmConsultarEstoque : Form
    {
        public frmConsultarEstoque()
        {
            InitializeComponent();
        }

        private void dtpData_onValueChanged(object sender, EventArgs e)
        {
            Business.EstoqueBusiness business = new Business.EstoqueBusiness();

            DateTime data = dtpData.Value;
            
           List<tb_estoque> listar = business.ConsultarEstoqueData(data);

            dgvConsultarEstoque.DataSource = listar;
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            Business.EstoqueBusiness business = new Business.EstoqueBusiness();

            int id = Convert.ToInt32(txtProduto.Text);

            List<tb_estoque> listar = business.ConsultarEstoqueId(id);

            dgvConsultarEstoque.DataSource = listar;
        }
        private void rdnSim_CheckedChanged(object sender, EventArgs e)
        {
            Business.EstoqueBusiness business = new Business.EstoqueBusiness();

            bool vendido = rdnSim.Checked;

            List<tb_estoque> listar = business.ConsultarEstoqueVendidoSim(vendido);

            dgvConsultarEstoque.DataSource = listar;
        }

        private void rdnNao_CheckedChanged(object sender, EventArgs e)
        {
            Business.EstoqueBusiness business = new Business.EstoqueBusiness();

            bool vendido = rdnSim.Checked;

            List<tb_estoque> listar = business.ConsultarEstoqueVendidoNao(vendido);

            dgvConsultarEstoque.DataSource = listar;
        }
    }
   }
