using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.Recuperação_de_Senha
{
    public partial class ConfirmarEmail : Form
    {
        public ConfirmarEmail()
        {
            InitializeComponent();
        }

        private void lblConfirmar_Click(object sender, EventArgs e)
        {
            Business.FuncionarioBusiness business = new Business.FuncionarioBusiness();
            Utils.GmailSender gmail = new Utils.GmailSender();

            string email = txtEmail.Text;

            bool conf = business.ConfirmarEmail(email);

            if(conf == true)
            {
                Random rdn = new Random();
                string codigo = rdn.Next(6).ToString();

                gmail.Enviar(email, codigo);
            }
            else
            {
                lblErro.Text = "Email Invalido";
            }
        }
    }
}
