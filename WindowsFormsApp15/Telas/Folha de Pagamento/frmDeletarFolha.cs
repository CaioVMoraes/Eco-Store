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

namespace WindowsFormsApp15.Telas.Folha_de_Pagamento
{
    public partial class frmDeletarFolha : Form
    {
        public frmDeletarFolha()
        {
            InitializeComponent();

            this.CarregarFuncionario();
        }

        public void CarregarTela(tb_folhapagamento model)
        {
            cboFuncionario.Text = model.tb_funcionario.nm_funcionario;
            cboMes.Text = model.dt_pagamento.Month.ToString();

            txtIdFolha.Text = model.id_folhaPagamento.ToString();
            nudAli.Value = model.vl_valeAlimentacao;
            nudDentario.Value = model.vl_planoOdonto;
            nudDescontos.Value = model.vl_liquido;
            nudFamilia.Value = model.vl_salarioFamilia;
            nudFGTS.Value = model.vl_fgts;
            nudGratificacoes.Value = model.vl_gratificacoes;
            nudINSS.Value = model.vl_inss;
            nudIR.Value = model.vl_ir;
            nudPlanosaude.Value = model.vl_planoSaude;
            nudPLR.Value = model.vl_plr;
            nudRef.Value = model.vl_valeRefeicao;
            nudTransporte.Value = model.vl_valeTransporte;
        }

        private void CarregarFuncionario()
        {
            Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();

            List<tb_funcionario> lista = business.ConsultarFuncionario();

            cboFuncionario.DisplayMember = nameof(tb_funcionario.nm_funcionario);
            cboFuncionario.DataSource = lista;
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdFolha.Text);

                Business.FolhaDePagamentoBusiness business = new Business.FolhaDePagamentoBusiness();

                business.RemoverFolha(id);

                MessageBox.Show("Removido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
