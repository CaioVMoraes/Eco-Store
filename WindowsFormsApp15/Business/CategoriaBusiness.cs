using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class CategoriaBusiness
    {
        Database.CategoriaDatabase db = new Database.CategoriaDatabase();
        public void CadastrarCategoria(tb_categoria modelo)
        {
            db.CadastrarCategoria(modelo);
        }
        public List<tb_categoria> ConsultarCategoria()
        {
            List<tb_categoria> lista = db.ListarCategoria();

            return lista;
        }
        public void AlterarPonto(tb_categoria modelo)
        {
            db.AlterarCategoria(modelo);
        }
        public void RemoverPonto(tb_categoria modelo)
        {
            db.RemoverCategoria(modelo);
        }

    }
}
