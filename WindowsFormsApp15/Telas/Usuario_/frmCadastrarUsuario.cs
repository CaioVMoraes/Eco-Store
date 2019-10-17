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
                model.id_funcionario = Convert.ToInt32(txtFuncionario.Text);
                model.nm_usuario = txtUsuario.Text;
                model.ds_senha = txtSenha.Text;
                string confirmar = txtConfirmar.Text;
                model.nv_nivelAcesso = cboNivel.Text;

                business.inserirUsuario(model, confirmar);

                MessageBox.Show("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
