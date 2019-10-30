using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class RecuperacaoDatabase
    {
        Model.ecostoreEntities db = new ecostoreEntities();
        public void Inserir (tb_recuperacao model)
        {
            db.tb_recuperacao.Add(model);
            db.SaveChanges();
        }
    }
}
