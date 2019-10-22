﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class ProdutoBusiness
    {

        Database.ProdutoDatabase db = new Database.ProdutoDatabase();
        Model.tb_produto modelo = new Model.tb_produto();

        public void CadastrarProduto(Model.tb_produto modelo)
        {
            db.CadastrarProduto(modelo);

            if(modelo.id_fornecedor == 0 )
            {
                throw new ArgumentException("O campo fornecedor é obrigatório");
            }
            if (modelo.id_categoria == 0)
            {
                throw new ArgumentException("O campo categoria é obrigatório");
            }
            if (modelo.nm_produto == string.Empty)
            {
                throw new ArgumentException("O campo Nome do produto é obrigatório");
            }
             if(modelo.vl_valor == 0 )
            {
                throw new ArgumentException("O campo Valor é obrigatório");
            }
            if (modelo.img_produto == null)
            {
                throw new ArgumentException("imagem do produto é obrigatório");
            }
        }
        public List<Model.tb_produto> ConsultarProduto(string nome)
        {
            List<Model.tb_produto> lista = db.ConsultarProdutoNome(nome);

            return lista;
        }
        public List<Model.tb_produto> ConsultarProdutoCategoria(int idcategoria)
        {
            List<Model.tb_produto> lista = db.ConsultarProdutoCategoria(idcategoria);

            return lista;
        }
        public List<Model.tb_produto> ConsultarProdutoFornecedor(int idfornecedor)
        {
            List<Model.tb_produto> lista = db.ConsultarProdutoFornecedor(idfornecedor);

            return lista;
        }

        public List<tb_produto> ConsultarTodosProdutos()
        {
            List<tb_produto> lista = db.ConsultarTodosProdutos();

            return lista;
        }

        public Model.tb_produto Listar(int id)
        {
            Model.tb_produto modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarProduto(Model.tb_produto modelo)
        {
            db.AlterarProduto(modelo);

            if (modelo.id_fornecedor == 0)
            {
                throw new ArgumentException("O campo fornecedor é obrigatório");
            }
            if (modelo.id_categoria == 0)
            {
                throw new ArgumentException("O campo categoria é obrigatório");
            }
            if (modelo.nm_produto == string.Empty)
            {
                throw new ArgumentException("O campo Nome do produto é obrigatório");
            }
            if (modelo.vl_valor == 0)
            {
                throw new ArgumentException("O campo Valor é obrigatório");
            }
            if (modelo.img_produto == null)
            {
                throw new ArgumentException("imagem do produto é obrigatório");
            }
        }
        public void RemoverProduto(int id)
        {
            db.RemoverProduto(id);

            if (modelo.id_fornecedor == 0)
            {
                throw new ArgumentException("O campo fornecedor é obrigatório");
            }
            if (modelo.id_categoria == 0)
            {
                throw new ArgumentException("O campo categoria é obrigatório");
            }
            if (modelo.nm_produto == string.Empty)
            {
                throw new ArgumentException("O campo Nome do produto é obrigatório");
            }
            if (modelo.vl_valor == 0)
            {
                throw new ArgumentException("O campo Valor é obrigatório");
            }
            if (modelo.img_produto == null)
            {
                throw new ArgumentException("imagem do produto é obrigatório");
            }

        }
    }
}

