using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class ControledePontoDatabase
    {
        Model.ecostoreEntities db = new Model.ecostoreEntities();
        public void CadastrarPonto(tb_controledeponto modelo)
        {
            db.tb_controledeponto.Add(modelo);
            db.SaveChanges();
        }

        public List<tb_controledeponto> ConsultarPonto()
        {
            List<tb_controledeponto> lista = db.tb_controledeponto.ToList();

            return lista;
        }
        public void AlterarPonto(tb_controledeponto modelo)
        {
            tb_controledeponto alterar = db.tb_controledeponto.FirstOrDefault(x => x.id_controleDePonto == x.id_controleDePonto);

            modelo.dt_entrada = alterar.dt_entrada;
            modelo.dt_mes = alterar.dt_mes;
            modelo.dt_saida = alterar.dt_saida;

            db.SaveChanges();
        }
        public void RemoverPonto(tb_controledeponto modelo)
        {
            db.tb_controledeponto.Remove(modelo);
        }
    }
}
