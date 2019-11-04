using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class CompraBusiness
    {
        Database.CompraDatabase db = new Database.CompraDatabase();
        tb_compra model = new tb_compra();

        public void InserirCompra(tb_compra modelo)
        {
            if(model.dt_compra == null)
            {
                throw new ArgumentException("Data de compra inválida");
            }
            if (model.vl_valorTotal == 0)
            {
                throw new ArgumentException("Total inválido");
            }

            db.InserirCompra(modelo);



        }
        public void InserirCompraItem(tb_compra_item modelo)
        {

            tb_compra_item modelocompra = new tb_compra_item();

            if(modelocompra.id_compra == 0)
            {
                throw new ArgumentException("Id compra Inválido");
            }

            if (modelocompra.id_produto == 0)
            {
                throw new ArgumentException("Id prdouto Inválido");
            }

            if (modelocompra.nm_produto == string.Empty)
            {
                throw new ArgumentException("Nome do produto Inválido");
            }

            if (modelocompra.vl_valorTotal == 0)
            {
                throw new ArgumentException("valor total Inválido");
            }
            if (modelocompra.dt_compra == null)
            {
                throw new ArgumentException("Data de compra Inválida");
            }

            db.InserirCompraitem(modelo);


        }

        public List<tb_compra> ConsultarCompra()
        {
            List<tb_compra> lista = db.ConsultarCompra();

            return lista;
        }
        public List<tb_compra_item> ConsultarCompraItem(DateTime data)
        {
            List<tb_compra_item> lista = db.ConsultarCompraItem(data);

            return lista;
        }
        public tb_compra Listar(int id)
        {
            tb_compra modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarCompra(tb_compra modelo)
        {

            if (model.dt_compra == null)
            {
                throw new ArgumentException("Data de compra inválida");
            }
            if (model.vl_valorTotal == 0)
            {
                throw new ArgumentException("Total inválido");
            }

            db.AlterarCompra(modelo);


        }
        public void RemoverCompra(int id)
        {


            if (model.dt_compra == null)
            {
                throw new ArgumentException("Data de compra inválida");
            }
            if (model.vl_valorTotal == 0)
            {
                throw new ArgumentException("Total inválido");
            }

            db.RemoverCompra(id);

        }
    }
}
