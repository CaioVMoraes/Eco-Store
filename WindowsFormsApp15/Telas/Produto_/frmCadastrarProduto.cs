using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.Telas
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto modelo = new Model.tb_produto();
                Business.ProdutoBusiness business = new Business.ProdutoBusiness();

                byte[] imagem_byte = null;

                FileStream fstream = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fstream);

                imagem_byte = br.ReadBytes((int)fstream.Length);

                modelo.img_produto = imagem_byte;
                modelo.id_fornecedor = Convert.ToInt32(txtIDFornecedor.Text);
                modelo.id_categoria = Convert.ToInt32(cboCategoria.Text);
                modelo.nm_produto = txtNome.Text;
                modelo.vl_valor = nudValor.Value;

                business.CadastrarProduto(modelo);

                MessageBox.Show("Cadastrado com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|JPEG Files(*.jfif)|*.jfif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtImagem.Text = foto;
                picProduto.ImageLocation = foto;
            }
        }
    }
}
