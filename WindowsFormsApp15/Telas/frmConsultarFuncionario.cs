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
    public partial class frmConsultarFuncionario : Form
    {
        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();
                Model.tb_funcionario modelo = new Model.tb_funcionario();

                txtNome.Text = modelo.nm_funcionario;
                txtRg.Text = modelo.ds_rg;
                txtCPF.Text = modelo.ds_cpf;
                cboCargo.Text = modelo.ds_cargo;
                dtpContrat.Value = modelo.dt_contratacao;

                List<Model.tb_funcionario> lista = business.ConsultarFuncionario();

                dgvConsultarFuncionario.DataSource = lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
