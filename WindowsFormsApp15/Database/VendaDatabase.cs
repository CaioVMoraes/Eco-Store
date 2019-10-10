﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class VendaDatabase
    {
        Model.ecostoreEntities db = new Model.ecostoreEntities();
        public void InserirVenda(tb_venda modelo)
        {
            db.tb_venda.Add(modelo);
            db.SaveChanges();
        }
        public void InserirVendaitem(tb_venda_item modelo)
        {
            db.tb_venda_item.Add(modelo);
            db.SaveChanges();
        } 

        public List<tb_venda> ConsultarVenda()
        {
            List<tb_venda> lista = db.tb_venda.ToList();

            return lista;
        }
        public tb_venda Listar(int id)
        {
            tb_venda modelo = db.tb_venda.FirstOrDefault(x => x.id_venda == id);

            return modelo;
        }

        public void AlterarVenda(tb_venda modelo)
        {
            tb_venda alterar = db.tb_venda.FirstOrDefault(x => x.id_venda == x.id_venda);

            modelo.dt_saida = alterar.dt_saida;
            modelo.vl_valorTotal = alterar.vl_valorTotal;
            

            db.SaveChanges();
        }
        public void RemoverVenda(tb_venda modelo)
        {
            db.tb_venda.Remove(modelo);
        }
    }
}
