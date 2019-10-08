﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class CategoriaDatabase
    {
        Model.ecostoreEntities db = new Model.ecostoreEntities();
        public void CadastrarCategoria(tb_categoria modelo)
        {
            db.tb_categoria.Add(modelo);
            db.SaveChanges();
        }

        public List<tb_categoria> ListarCategoria()
        {
            List<tb_categoria> lista = db.tb_categoria.ToList();

            return lista;
        }
        public void AlterarCategoria(tb_categoria modelo)
        {
            tb_categoria alterar = db.tb_categoria.FirstOrDefault(x => x.id_categoria == x.id_categoria);

            modelo.nm_categoria = alterar.nm_categoria;
            modelo.ds_categoria = alterar.ds_categoria;

            db.SaveChanges();
        }
        public void RemoverCategoria(tb_categoria modelo)
        {
            db.tb_categoria.Remove(modelo);
        }
    }
}
