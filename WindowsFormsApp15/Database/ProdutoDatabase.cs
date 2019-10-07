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
        public List<tb_produto> ConsultarProduto()
        {
            List<tb_produto> lista = db.tb_produto.ToList();

            return lista;
        }

        public void AlterarProduto(tb_produto modelo)
        {
            tb_produto alterar = db.tb_produto.FirstOrDefault(x => x.id_produto == x.id_produto);

            alterar.nm_produto = alterar.nm_produto;
            alterar.vl_valor = alterar.vl_valor;
            alterar.ds_categoria = alterar.ds_categoria;

            db.SaveChanges();
          

        }
        public void RemoverProduto(tb_produto modelo)
        {
            db.tb_produto.Remove(modelo);

            db.SaveChanges();
        }



    }
}
