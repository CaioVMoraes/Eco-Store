﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class ClienteBusiness
    {
        Database.ClienteDatabase db = new Database.ClienteDatabase();
        tb_cliente modelo = new tb_cliente();
        public void InserirCliente(tb_cliente modelo)
        {
            if(modelo.id_cliente == 0)
            {
                throw new ArgumentException("Id inválido");
            }
            if (modelo.ds_celular == string.Empty)
            {
                throw new ArgumentException("O campo celular é obrigatório");
            }
            if (modelo.ds_telefone == string.Empty)
            {
                throw new ArgumentException("O campo telefone é obrigatório");
            }
            if (modelo.ds_cpf == string.Empty)
            {
                throw new ArgumentException("O campo CPF é obrigatório");
            }
            if (modelo.ds_email == string.Empty)
            {
                throw new ArgumentException("O campo Email é obrigatório");
            }
            if (modelo.ds_rg == string.Empty)
            {
                throw new ArgumentException("O campo RG é obrigatório");
            }
            if (modelo.nm_cliente == string.Empty)
            {
                throw new ArgumentException("O campo Nome é obrigatório");
            }
           
            db.InserirCliente(modelo);
        }
        public List<tb_cliente> ConsultarCliente()
        {
            List<tb_cliente> lista = db.ConsultarCliente();
            return lista;
        }
        public List<tb_cliente> ConsultarClienteId(int id)
        {
            List<tb_cliente> lista = db.ConsultarClienteId(id);

            return lista;
        }
        public List<tb_cliente> ConsultarClienteNome(string nome)
        {
            List<tb_cliente> lista = db.ConsultarClienteNome(nome);

            return lista;
        }
        public List<tb_cliente> ConsultarClienteCpf(string cpf)
        {
            List<tb_cliente> lista = db.ConsultarClienteCpf(cpf);

            return lista;
        }
        public List<tb_cliente> ConsultarClienteRg(string RG)
        {
            List<tb_cliente> lista = db.ConsultarClienteRg(RG);

            return lista;
        }
        public List<tb_cliente> ConsultarClienteTelefone(string tel)
        {
            List<tb_cliente> lista = db.ConsultarClienteTelefone(tel);

            return lista;
        }
        public List<tb_cliente> ConsultarClienteCelular(string cel)
        {
            List<tb_cliente> lista = db.ConsultarClienteCelular(cel);

            return lista;
        }
        public List<tb_cliente> ConsultarClienteEmail(string email)
        {
            List<tb_cliente> lista = db.ConsultarClienteEmail(email);

            return lista;
        }

        public void AlterarCliente(tb_cliente modelo)
        {

            if (modelo.id_cliente == 0)
            {
                throw new ArgumentException("Id inválido");
            }
            if (modelo.ds_celular == string.Empty)
            {
                throw new ArgumentException("O campo celular é obrigatório");
            }
            if (modelo.ds_telefone == string.Empty)
            {
                throw new ArgumentException("O campo telefone é obrigatório");
            }
            if (modelo.ds_cpf == string.Empty)
            {
                throw new ArgumentException("O campo CPF é obrigatório");
            }
            if (modelo.ds_email == string.Empty)
            {
                throw new ArgumentException("O campo Email é obrigatório");
            }
            if (modelo.ds_rg == string.Empty)
            {
                throw new ArgumentException("O campo RG é obrigatório");
            }
            if (modelo.nm_cliente == string.Empty)
            {
                throw new ArgumentException("O campo Nome é obrigatório");
            }


            db.AlterarCliente(modelo);

        }
        public void RemoverCliente(int id)
        {

            if (modelo.id_cliente == 0)
            {
                throw new ArgumentException("Id inválido");
            }
            if (modelo.ds_celular == string.Empty)
            {
                throw new ArgumentException("O campo celular é obrigatório");
            }
            if (modelo.ds_telefone == string.Empty)
            {
                throw new ArgumentException("O campo telefone é obrigatório");
            }
            if (modelo.ds_cpf == string.Empty)
            {
                throw new ArgumentException("O campo CPF é obrigatório");
            }
            if (modelo.ds_email == string.Empty)
            {
                throw new ArgumentException("O campo Email é obrigatório");
            }
            if (modelo.ds_rg == string.Empty)
            {
                throw new ArgumentException("O campo RG é obrigatório");
            }
            if (modelo.nm_cliente == string.Empty)
            {
                throw new ArgumentException("O campo Nome é obrigatório");
            }

            db.RemoverCliente(id);
        }
    }
}
