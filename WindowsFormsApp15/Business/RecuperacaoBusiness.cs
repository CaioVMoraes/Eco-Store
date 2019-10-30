using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class RecuperacaoBusiness
    {
        public void Inserir(tb_recuperacao model)
        {
            Database.RecuperacaoDatabase database = new Database.RecuperacaoDatabase();

            if(model.ds_codigo.Length != 6)
            {
                throw new ArgumentException("Codigo invalido");
            }
             if(model.id_usuario == 0)
            {
                throw new ArgumentException("Usuario Inválido");
            }

            database.Inserir(model);
        }
    }
}
