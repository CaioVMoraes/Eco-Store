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
    public partial class frmAlterarFuncionario : Form
    {
        public frmAlterarFuncionario()
        {
            InitializeComponent();
        }

        Model.tb_funcionario model = new Model.tb_funcionario();
        Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);

                business.Listar(id);

                //*Informações Pessoais*

                txtNome.Text = model.nm_funcionario;
                dtpNascimento.Value = model.dt_nascimento;
                txtRg.Text = model.ds_rg;
                txtEmail.Text = model.ds_email;
                dtpContrat.Value = model.dt_contratacao;
                cboGen.Text = model.ds_genero;
                cboCargo.Text = model.ds_cargo;
                txtCelular.Text = model.ds_celular;
                txtTelefone.Text = model.ds_telefone;
                nudSalario.Value = model.vl_salario;

                //*Endereço*

                txtEndereço.Text = model.ds_endereco;
                txtCep.Text = model.ds_cep;
                txtCidade.Text = model.ds_cidade;
                cboUF.Text = model.ds_UF;
                txtComplemento.Text = model.ds_complemento;

                //*Beneficíos*

                nudTransp.Value = model.vl_transporte;
                nudRef.Value = model.vl_refeicao;
                nudAliment.Value = model.vl_alimentacao;

                MessageBox.Show("Alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            
            id = model.id_funcionario;


            //*Informações Pessoais*

            model.nm_funcionario = txtNome.Text;
            model.dt_nascimento = dtpNascimento.Value;
            model.ds_rg = txtRg.Text;
            model.ds_email = txtEmail.Text;
            model.dt_contratacao = dtpContrat.Value;
            model.ds_genero = cboGen.Text;
            model.ds_cargo = cboCargo.Text;
            model.ds_celular = txtCelular.Text;
            model.ds_telefone = txtTelefone.Text;
            model.vl_salario = nudSalario.Value;

            //*Endereço*

            model.ds_endereco = txtEndereço.Text;
            model.ds_cep = txtCep.Text;
            model.ds_cidade = txtCidade.Text;
            model.ds_UF = cboUF.Text;
            model.ds_complemento = txtComplemento.Text;
            model.ds_numeroCasa = txtNumRes.Text;

            //*Beneficíos*

            model.vl_transporte = nudTransp.Value;
            model.vl_refeicao = nudRef.Value;
            model.vl_alimentacao = nudAliment.Value;

            business.CadastrarFuncionario(model);

            MessageBox.Show("Cadastrado com Sucesso");
        }
    }
}
