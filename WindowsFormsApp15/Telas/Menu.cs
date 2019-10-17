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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Text = Objetos.Usuario.UsuarioLogado.Nome;
            label2.Text = Objetos.Usuario.UsuarioLogado.RG;
            label3.Text = Objetos.Usuario.UsuarioLogado.CPF;
            label4.Text = Objetos.Usuario.UsuarioLogado.Email;
            label5.Text = Objetos.Usuario.UsuarioLogado.Telefone;
            label6.Text = Objetos.Usuario.UsuarioLogado.Endereco;

        }
    }
}
