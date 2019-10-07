using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Business
{
    class FuncionarioBusiness
    {

        Database.FuncionarioDatabase db = new Database.FuncionarioDatabase();

        public void CadastrarFuncionario(Model.tb_funcionario funcionario)
        {
            db.CadastrarFuncionario(funcionario);
        }
        public List<Model.tb_funcionario> ConsultarFuncionario()
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionario();

            return lista;
        }

        public void AlterarFuncionario(Model.tb_funcionario funcionario)
        {
            db.AlterarFuncionario(funcionario);
        }
        public void RemoverFuncionario(Model.tb_funcionario funcionario)
        {
            db.RemoverFuncionario(funcionario);
        }
    }
}
