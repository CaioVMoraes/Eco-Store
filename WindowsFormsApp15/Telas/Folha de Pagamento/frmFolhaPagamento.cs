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
    public partial class nudSaude : Form
    {
        public nudSaude()
        {
            InitializeComponent();
            this.CarregarFuncionario();

        }

        private void CarregarFuncionario()
        {
            Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();

            List<tb_funcionario> lista = business.ConsultarFuncionario();

            cboID.DisplayMember = nameof(tb_funcionario.nm_funcionario);
            cboID.DataSource = lista;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Business.FolhaDePagamentoBusiness business = new Business.FolhaDePagamentoBusiness();
            tb_folhapagamento model = new tb_folhapagamento();

            int id =Convert.ToInt32( cboID.Text);

            decimal gratificaçoes = nudGratificacoes.Value;
            decimal Plr = nudPLR.Value;
            decimal INSS = nudINSS.Value;
            decimal FGTS = nudFGTS.Value;
            decimal planosaude = nudPlanosaude.Value;
            decimal salariofami = nudFamilia.Value;
            decimal VA = nudAli.Value;
            decimal VR = nudRef.Value;
            decimal VT = nudTransporte.Value;
            decimal planodent = nudDentario.Value;
            DateTime data = dtpPagamento.Value;
            decimal bruto = nudDescontos.Value;

            lblLiquido.Text = (bruto + gratificaçoes - Plr - INSS - FGTS - planosaude - salariofami - VA - VR - VT - planodent).ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int funcionarioID = Convert.ToInt32(cboID.Text);
            int mes = dtpPagamento.Value.Month;

            Business.FuncionarioBusiness funcionarioBusiness = new Business.FuncionarioBusiness();
            Business.ControleDePontoBusiness controleBusiness = new Business.ControleDePontoBusiness();

            List<tb_controledeponto> ponto = controleBusiness.ListarPorFuncionario(funcionarioID, mes);
            tb_funcionario funcionario = funcionarioBusiness.Listar(funcionarioID);

            Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

            Image imagem = imageConverter.byteArrayToImage(funcionario.img_foto);

            imgFoto.Image = imagem;

            int entradaAlmoco = ponto.Sum(x => x.dt_saidaAlmoco.Value.Hour);
            int voltaAlmoco = ponto.Sum(x => x.dt_voltaAlmoco.Value.Hour);

            int totalAlmoco = voltaAlmoco - entradaAlmoco;

            int chegada = ponto.Sum(x => x.dt_chegada.Value.Hour);
            int saida = ponto.Sum(x => x.dt_saida.Value.Hour);

            int expediente = (saida - chegada) - totalAlmoco;

            nudDescontos.Value = expediente * funcionario.vl_salarioPorHora;

        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudDentario_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
