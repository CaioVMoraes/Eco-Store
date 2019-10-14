using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class EstoqueBusiness
    {

        Database.EstoqueDatabase db = new Database.EstoqueDatabase();
        public void CadastrarEstoque(tb_estoque modelo)
        {
            db.CadastrarEstoque(modelo);

        }
        public List<tb_estoque> ConsultarEstoque()
        {
           List<tb_estoque> lista = db.ConsultarEstoque();

            return lista;
        }
        public Model.tb_estoque Listar(int id)
        {
            Model.tb_estoque modelo = db.Listar(id);

            return modelo;
        }
        public void AlterarEstoque(tb_estoque modelo)
        {
            db.AlterarEstoque(modelo);
        }
        public void RemoverEstoque(int id)
        {
            db.RemoverEstoque(id);
        }
    }
}
