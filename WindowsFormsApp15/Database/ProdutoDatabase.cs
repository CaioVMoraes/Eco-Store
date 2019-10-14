using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class ProdutoDatabase
    {
        Model.ecostoreEntities db = new Model.ecostoreEntities();

        public void CadastrarProduto(tb_produto produto)
        {
            db.tb_produto.Add(produto);
            db.SaveChanges();

        }
        public List<tb_produto> ConsultarProdutoNome(string Produtonome)
        {
            List<tb_produto> lista = db.tb_produto.Where(x=> x.nm_produto == Produtonome).ToList();

            return lista;
        }
        public List<tb_produto> ConsultarProdutoCategoria(int idcategoria)
        {
            List<tb_produto> lista = db.tb_produto.Where(x => x.id_categoria == idcategoria).ToList();

            return lista;
        }
        public List<tb_produto> ConsultarProdutoFornecedor(int idFornecedor)
        {
            List<tb_produto> lista = db.tb_produto.Where(x => x.id_fornecedor == idFornecedor).ToList();

            return lista;
        }

        public tb_produto Listar(int id)
        {
            tb_produto modelo = db.tb_produto.FirstOrDefault(x => x.id_produto == id);

            return modelo;
        }

        public void AlterarProduto(tb_produto modelo)
        {
            tb_produto alterar = db.tb_produto.FirstOrDefault(x => x.id_produto == x.id_produto);

            alterar.nm_produto = alterar.nm_produto;
            alterar.vl_valor = alterar.vl_valor;
            alterar.id_categoria = alterar.id_categoria;

            db.SaveChanges();
          
        }
        public void RemoverProduto(tb_produto modelo)
        {
            db.tb_produto.Remove(modelo);

            db.SaveChanges();
        }





    }
}
