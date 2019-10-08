using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class EstoqueDatabase
    {
        Model.ecostoreEntities db = new Model.ecostoreEntities();
        public void CadastrarEstoque(tb_estoque modelo)
        {
            db.tb_estoque.Add(modelo);

            db.SaveChanges();
        }
        public List<tb_estoque> ConsultarEstoque()
        {
            List<tb_estoque> lista = db.tb_estoque.ToList();

            return lista;
        }
        public tb_estoque Listar(int id)
        {
            tb_estoque modelo = db.tb_estoque.FirstOrDefault(x => x.id_estoque == id);

            return modelo;
        }
        public void AlterarEstoque(tb_estoque modelo)
        {
            tb_estoque alterar = db.tb_estoque.FirstOrDefault(x => x.id_estoque == x.id_estoque);

            modelo.qtd_produto = alterar.qtd_produto;
            modelo.vl_valor = alterar.vl_valor;
            modelo.dt_entrada = alterar.dt_entrada;
            modelo.dt_validade = alterar.dt_validade;

            db.SaveChanges();
        }
        public void RemoverEstoque(tb_estoque modelo)
        {
            db.tb_estoque.Remove(modelo);
        }
    }
}
