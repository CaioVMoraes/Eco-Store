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
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

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

        private void nudSaude_Load(object sender, EventArgs e)
        {

        }
    }
}
