using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class FolhaDePagamentoDatabase
    {
        Model.ecostorEntities db = new Model.ecostorEntities();
        public void inserirFolha(Model.tb_folhapagamento modelo)
        {
            db.tb_folhapagamento.Add(modelo);
            db.SaveChanges();
        }

        public List<tb_folhapagamento> COnsultarFolha(int id)
        {
            List<tb_folhapagamento> lista = db.tb_folhapagamento.Where(x => x.id_funcionario == id).ToList();

            return lista;
        }
        public void AlterarFolha(tb_folhapagamento modelo)
        {
            tb_folhapagamento alterar = db.tb_folhapagamento.FirstOrDefault(x => x.id_funcionario == x.id_funcionario);

            modelo.vl_fgts = alterar.vl_fgts;
            modelo.vl_gratificacoes = alterar.vl_gratificacoes;
            modelo.vl_inss = alterar.vl_inss;
            modelo.vl_ir = alterar.vl_ir;
            modelo.vl_liquido = alterar.vl_liquido;
            modelo.vl_planoOdonto = alterar.vl_planoOdonto;
            modelo.vl_planoSaude = modelo.vl_planoSaude;
            modelo.vl_plr = alterar.vl_plr;
            modelo.vl_salarioFamilia = alterar.vl_salarioFamilia;
            modelo.vl_valeAlimentacao = alterar.vl_valeAlimentacao;
            modelo.vl_valeRefeicao = alterar.vl_valeRefeicao;
            modelo.vl_valeTransporte = alterar.vl_valeTransporte;
            modelo.dt_pagamento = alterar.dt_pagamento;
            

            db.SaveChanges();
        }

        public void RemoverFolha(int id)
        {
            tb_folhapagamento deletar = db.tb_folhapagamento.FirstOrDefault(x => x.id_funcionario == id);
            db.tb_folhapagamento.Remove(deletar);

            db.SaveChanges();
        }
    }
}
