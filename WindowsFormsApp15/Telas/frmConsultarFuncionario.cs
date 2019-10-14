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


        Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();
        Model.tb_funcionario modelo = new Model.tb_funcionario();
       
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioNome(nome);

            dgvConsultarFuncionario.DataSource = lista;
        }
        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            string rg = txtRg.Text;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioRg(rg);

            dgvConsultarFuncionario.DataSource = lista;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioCpf(cpf);

            dgvConsultarFuncionario.DataSource = lista;
        }

        private void cboCargo_TextChanged(object sender, EventArgs e)
        {
            string cargo = cboCargo.Text;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioCargo(cargo);

            dgvConsultarFuncionario.DataSource = lista;
        }

        private void dtpContrat_onValueChanged(object sender, EventArgs e)
        {
            DateTime contrat = dtpContrat.Value;

            List<Model.tb_funcionario> lista = business.ConsultarFuncionarioContratacao(contrat);

            dgvConsultarFuncionario.DataSource = lista;
        }
    }
}
