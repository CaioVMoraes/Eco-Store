﻿using System;
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
    public partial class frmDeletarFuncionario : Form
    {
        public frmDeletarFuncionario()
        {
            InitializeComponent();
        }

        Model.tb_funcionario model = new Model.tb_funcionario();
        Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                              
                business.RemoverFuncionario(id);

                MessageBox.Show("Deletado com Sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

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
                txtNumRes.Text = model.ds_numeroCasa;

                //*Beneficíos*

               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
           
    
}