using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class FornecedorDatabase
    {
        Model.ecostoreEntities db = new Model.ecostoreEntities();
        public void CadastarFornecedor(tb_fornecedor modelo)
        {
            db.tb_fornecedor.Add(modelo);

            db.SaveChanges();
        }
        public List<tb_fornecedor> ConsultarFornecedor()
        {
            List<tb_fornecedor> lista = db.tb_fornecedor.ToList();

            return lista;
        
        }
        public void AlterarFornecedor (tb_fornecedor modelo)
        {
            tb_fornecedor alterar = db.tb_fornecedor.FirstOrDefault(x => x.nm_empresa == x.nm_empresa);

            modelo.nm_empresa = alterar.nm_empresa;
            modelo.ds_celular = alterar.ds_celular;
            modelo.ds_cnpj = alterar.ds_cnpj;
            modelo.ds_endereco = alterar.ds_endereco;
            modelo.ds_telefone = modelo.ds_telefone;
            modelo.nm_fornecedor = modelo.nm_fornecedor;

            db.SaveChanges();
        }
        public void RemoverFornecedor(tb_fornecedor modelo)
        {
            db.tb_fornecedor.Remove(modelo);
        }
    }
}
