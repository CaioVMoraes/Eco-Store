using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.Telas.Usuario
{
    public partial class frmConsultarUsuario : Form
    {
        public frmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Database.UsuarioDatabase database = new Database.UsuarioDatabase();
            List<Model.tb_usuario> lista = database.ListaDeUsuarios();

            dataGridView1.DataSource = lista;
        }
    }
}
