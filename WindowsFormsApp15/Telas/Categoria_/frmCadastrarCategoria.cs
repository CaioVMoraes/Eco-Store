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
    public partial class frmCadastrarCategoria : Form
    {
        public frmCadastrarCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Business.CategoriaBusiness business = new Business.CategoriaBusiness();
            Model.tb_categoria model = new Model.tb_categoria();

            model.nm_categoria = txtNome.Text;
            model.ds_categoria = txtDescricao.Text;

            business.CadastrarCategoria(model);

            MessageBox.Show("Cadastrado com sucesso");
        }
    }
}
