using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class FluxoDeCaixaDatabase
    {
        Model.db_a4e776_ecostorEntities db = new db_a4e776_ecostorEntities();

        public List<vw_fluxocaixa> FluxoDeCaixa()
        {
            List<vw_fluxocaixa> lista = db.vw_fluxocaixa.ToList();

            return lista;
        }
    }
}
