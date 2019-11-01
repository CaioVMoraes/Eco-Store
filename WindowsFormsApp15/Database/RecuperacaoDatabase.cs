﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class RecuperacaoDatabase
    {
        Model.db_a4e776_ecostorEntities db = new db_a4e776_ecostorEntities();
        public void Inserir (tb_recuperacao model)
        {
            db.tb_recuperacao.Add(model);
            db.SaveChanges();
        }

        public tb_recuperacao Consultar(string codigo)
        {
            tb_recuperacao recuperacao = db.tb_recuperacao.FirstOrDefault(x => x.ds_codigo == codigo);

            return recuperacao;
        }

        public void AlterarUsado(tb_recuperacao model)
        {
            tb_recuperacao alterar = db.tb_recuperacao.FirstOrDefault(x => x.id_recuperacao == model.id_recuperacao);

            alterar.bt_usado = true;

            db.SaveChanges();
        }
    }
}
