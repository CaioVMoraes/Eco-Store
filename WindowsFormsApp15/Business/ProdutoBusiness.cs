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
        public List<Model.tb_produto> ConsultarProduto(string nome)
        {
            List<Model.tb_produto> lista = db.ConsultarProdutoNome(nome);

            return lista;
        }
        public List<Model.tb_produto> ConsultarProdutoCategoria(int idcategoria)
        {
            List<Model.tb_produto> lista = db.ConsultarProdutoCategoria(idcategoria);

            return lista;
        }
        public List<Model.tb_produto> ConsultarProdutoFornecedor(int idfornecedor)
        {
            List<Model.tb_produto> lista = db.ConsultarProdutoFornecedor(idfornecedor);

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

