using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Business
{
    class ProdutoBusiness
    {

        Database.ProdutoDatabase db = new Database.ProdutoDatabase();

        public void CadastrarProduto(Model.tb_produto modelo)
        {
            db.CadastrarProduto(modelo);
        }
        public List<Model.tb_produto> ConsultarFuncionario()
        {
            List<Model.tb_produto> lista = db.ConsultarProduto();

            return lista;
        }
        public Model.tb_produto Listar(int id)
        {
            Model.tb_produto modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarProduto(Model.tb_produto modelo)
        {
            db.AlterarProduto(modelo);
        }
        public void RemoverFuncionario(Model.tb_produto modelo)
        {
            db.RemoverProduto(modelo);

        }
    }
}

