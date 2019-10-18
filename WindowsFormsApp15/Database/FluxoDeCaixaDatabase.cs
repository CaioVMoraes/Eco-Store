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
        internal object vw_fluxocaixa;
        Model.ecostoreEntities db = new ecostoreEntities();
        public List<vw_fluxocaixa> FluxoDeCaixa()
        {
            List<vw_fluxocaixa> lista = db.vw_fluxocaixa.ToList();

            return lista;
        }
    }
}
