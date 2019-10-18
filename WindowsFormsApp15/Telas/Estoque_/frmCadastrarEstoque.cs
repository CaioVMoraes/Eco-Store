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
    public partial class frmCadastrarEstoque : Form
    {
        public frmCadastrarEstoque()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_estoque modelo = new Model.tb_estoque();
                Business.EstoqueBusiness business = new Business.EstoqueBusiness();

                modelo.id_estoque = Convert.ToInt32(txtID.Text);
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

                business.CadastrarEstoque(modelo);

                MessageBox.Show("Cadastrado com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
