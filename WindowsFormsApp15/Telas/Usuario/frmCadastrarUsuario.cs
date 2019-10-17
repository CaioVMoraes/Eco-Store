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
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        Model.tb_usuario model = new Model.tb_usuario();
        Business.UsuarioBusiness business = new Business.UsuarioBusiness();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //*Informações Pessoais*

                //model.id_funcionario = 
                model.nm_usuario = txtUsuario.Text;
                model.

                //*Endereço*

                model.ds_endereco = txtEndereço.Text;
                model.ds_cep = txtCep.Text;
                model.ds_cidade = txtCidade.Text;
                model.ds_UF = cboUF.Text;
                model.ds_complemento = txtComplemento.Text;
                model.ds_numeroCasa = txtNumRes.Text;
                model.img_foto = null;

                business.CadastrarFuncionario(model);

                MessageBox.Show("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
