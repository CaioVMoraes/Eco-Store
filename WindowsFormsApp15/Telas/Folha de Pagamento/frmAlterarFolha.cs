using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.Telas.Folha_de_Pagamento
{
    public partial class frmAlterarFolha : Form
    {
        public frmAlterarFolha()
        {
            InitializeComponent();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterarFolha_Load(object sender, EventArgs e)
        {

        }
    }
}
