using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Business
{
    class FornecedorBusiness
    {
        Database.FornecedorDatabase db = new Database.FornecedorDatabase();
        public void CadastrarFornecedor(Model.tb_fornecedor modelo)
        {
            db.CadastarFornecedor(modelo);
        }

        public List<Model.tb_fornecedor> ConsultarFornecedor()
        {
            List<Model.tb_fornecedor> lista = db.ConsultarFornecedor();

            return lista;
        }
        public Model.tb_fornecedor Listar(int id)
        {
            Model.tb_fornecedor modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarFornecedor(Model.tb_fornecedor modelo)
        {
            db.AlterarFornecedor(modelo);
        }

        public void RemoverForncedor(int id)
        {
            db.RemoverFornecedor(id);
        }
    }
}
