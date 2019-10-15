using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Business.UsuarioBusiness usuarioBusiness = new Business.UsuarioBusiness();
                Business.FuncionarioBusiness funcionarioBusiness = new Business.FuncionarioBusiness();

                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                Model.tb_usuario modeloUsuario = usuarioBusiness.ModeloUsuario(usuario, senha);

                bool login = usuarioBusiness.Usuario(usuario, senha);

                Model.tb_funcionario funcionario = funcionarioBusiness.Listar(modeloUsuario.id_funcionario);

                Objetos.Usuario.UsuarioLogado.ID = funcionario.id_funcionario;
                Objetos.Usuario.UsuarioLogado.Nome = funcionario.nm_funcionario;
                Objetos.Usuario.UsuarioLogado.RG = funcionario.ds_rg;
                Objetos.Usuario.UsuarioLogado.CPF = funcionario.ds_cpf;
                Objetos.Usuario.UsuarioLogado.Telefone = funcionario.ds_telefone;
                Objetos.Usuario.UsuarioLogado.Celular = funcionario.ds_celular;
                Objetos.Usuario.UsuarioLogado.Email = funcionario.ds_email;
                Objetos.Usuario.UsuarioLogado.Endereco = funcionario.ds_endereco;
                Objetos.Usuario.UsuarioLogado.cep = funcionario.ds_cep;
                Objetos.Usuario.UsuarioLogado.cidade = funcionario.ds_cidade;
                Objetos.Usuario.UsuarioLogado.UF = funcionario.ds_UF;
                Objetos.Usuario.UsuarioLogado.Complemento = funcionario.ds_complemento;
                Objetos.Usuario.UsuarioLogado.NumeroCasa = funcionario.ds_numeroCasa;
                Objetos.Usuario.UsuarioLogado.Cargo = funcionario.ds_cargo;
                Objetos.Usuario.UsuarioLogado.Salario = funcionario.vl_salario;
                Objetos.Usuario.UsuarioLogado.DataContratacao = funcionario.dt_contratacao;

                if (login == true)
                {
                    MessageBox.Show("login efetuado com sucesso");
                }
                else
                {
                    MessageBox.Show("Credenciais incorretas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Telas.frmCadastrarUsuario tela = new Telas.frmCadastrarUsuario();
            tela.Show();
        }
    }
}
