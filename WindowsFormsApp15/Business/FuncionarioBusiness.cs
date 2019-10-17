﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Business
{
    class FuncionarioBusiness
    {

        Database.FuncionarioDatabase db = new Database.FuncionarioDatabase();
        Model.tb_funcionario model = new Model.tb_funcionario();
        public void CadastrarFuncionario(Model.tb_funcionario funcionario)
        {
            db.CadastrarFuncionario(funcionario);

            //*Dados Pessoais*

            //if (model.nm_funcionario == string.Empty)
            //{
            //    throw new Exception("Nome do Funcionário é obrigatório");
            //}

            //int idade = DateTime.Now.Year - model.dt_nascimento.Year;

            //if (idade < 14)
            //{
            //    throw new Exception("idade inválida");
            //}
            //if (idade > 100)
            //{
            //    throw new Exception("idade inválida");
            //}
            //if (model.ds_rg == string.Empty)
            //{
            //    throw new Exception("Rg do funcionário é obrigatório");
            //}
            //if (model.ds_email == string.Empty)
            //{
            //    throw new Exception("E-mail do funcionário é obrigatório");
            //}
            //if (model.dt_contratacao == null)
            //{
            //    throw new Exception("A data de contrataçao é obrigatória");
            //}

            //if (model.dt_contratacao.Year > DateTime.Now.Year)
            //{
            //    throw new Exception("Data de contratação inválida");
            //}
            //if (model.ds_genero == string.Empty)
            //{
            //    throw new Exception("Genero é obrigatório");
            //}
            //if (model.ds_cargo == string.Empty)
            //{
            //    throw new Exception("O Cargo é obrigatório");
            //}
            //if (model.ds_celular == string.Empty)
            //{
            //    throw new Exception("Numero de celular é obrigatório");
            //}
            //if (model.ds_telefone == string.Empty)
            //{
            //    throw new Exception("Numero de celular é obrigatório");
            //}
            //if (model.vl_salario == 0)
            //{
            //    throw new Exception("Salário é obrigatório");
            //}

            ////*Endereço*

            //if (model.ds_endereco == string.Empty)
            //{
            //    throw new Exception("Endereço é obrigatório");
            //}
            //if (model.ds_cep == string.Empty)
            //{
            //    throw new Exception("CEP é obrigatório");
            //}
            //if (model.ds_cidade == string.Empty)
            //{
            //    throw new Exception("Cidade é obrigatório");
            //}
            //if (model.ds_UF == string.Empty)
            //{
            //    throw new Exception("Estado é obrigatório");
            //}
            //if (model.ds_UF == string.Empty)
            //{
            //    throw new Exception("NumeroEnder é obrigatório");
            //}

        }
        public List<Model.tb_funcionario> ConsultarFuncionarioNome(string nome)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioNome(nome);

            return lista;
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioRg(string Rg)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioRg(Rg);

            return lista;
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioCpf(string cpf)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioCpf(cpf);

            return lista;
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioCargo(string cargo)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioCargo(cargo);

            return lista;
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioContratacao(DateTime contrat)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioContracao(contrat);

            return lista;
        }
        public Model.tb_funcionario Listar(int id)
        {
            Model.tb_funcionario modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarFuncionario(Model.tb_funcionario funcionario)
        {
            
            //*Dados Pessoais*

            if (model.nm_funcionario == string.Empty)
            {
                throw new Exception("Nome do Funcionário é obrigatório");
            }

            int idade = DateTime.Now.Year - model.dt_nascimento.Year;

            if (idade < 14)
            {
                throw new Exception("idade inválida");
            }
            if (idade > 100)
            {
                throw new Exception("idade inválida");
            }
            if (model.ds_rg == string.Empty)
            {
                throw new Exception("Rg do funcionário é obrigatório");
            }
            if (model.ds_email == string.Empty)
            {
                throw new Exception("E-mail do funcionário é obrigatório");
            }
            if (model.dt_contratacao == null)
            {
                throw new Exception("A data de contrataçao é obrigatória");
            }

            //if (model.dt_contratacao.Year > DateTime.Now.Year)
            //{
            //    throw new Exception("Data de contratação inválida");
            //}
            if (model.ds_genero == string.Empty)
            {
                throw new Exception("Genero é obrigatório");
            }
            if (model.ds_cargo == string.Empty)
            {
                throw new Exception("O Cargo é obrigatório");
            }
            if (model.ds_celular == string.Empty)
            {
                throw new Exception("Numero de celular é obrigatório");
            }
            if (model.ds_telefone == string.Empty)
            {
                throw new Exception("Numero de celular é obrigatório");
            }
            if (model.vl_salario == 0)
            {
                throw new Exception("Salário é obrigatório");
            }

            //*Endereço*

            if (model.ds_endereco == string.Empty)
            {
                throw new Exception("Endereço é obrigatório");
            }
            if (model.ds_cep == string.Empty)
            {
                throw new Exception("CEP é obrigatório");
            }
            if (model.ds_cidade == string.Empty)
            {
                throw new Exception("Cidade é obrigatório");
            }
            if (model.ds_UF == string.Empty)
            {
                throw new Exception("Estado é obrigatório");
            }
            if (model.ds_UF == string.Empty)
            {
                throw new Exception("NumeroEnder é obrigatório");
            }

            db.AlterarFuncionario(funcionario);
        }
        public void RemoverFuncionario( int id)
        {
            //*Dados Pessoais*

            if (model.nm_funcionario == string.Empty)
            {
                throw new Exception("Nome do Funcionário é obrigatório");
            }

            int idade = DateTime.Now.Year - model.dt_nascimento.Year;

            if (idade < 14)
            {
                throw new Exception("idade inválida");
            }
            if (idade > 100)
            {
                throw new Exception("idade inválida");
            }
            if (model.ds_rg == string.Empty)
            {
                throw new Exception("Rg do funcionário é obrigatório");
            }
            if (model.ds_email == string.Empty)
            {
                throw new Exception("E-mail do funcionário é obrigatório");
            }
            if (model.dt_contratacao == null)
            {
                throw new Exception("A data de contrataçao é obrigatória");
            }

            //if (model.dt_contratacao.Year > DateTime.Now.Year)
            //{
            //    throw new Exception("Data de contratação inválida");
            //}
            if (model.ds_genero == string.Empty)
            {
                throw new Exception("Genero é obrigatório");
            }
            if (model.ds_cargo == string.Empty)
            {
                throw new Exception("O Cargo é obrigatório");
            }
            if (model.ds_celular == string.Empty)
            {
                throw new Exception("Numero de celular é obrigatório");
            }
            if (model.ds_telefone == string.Empty)
            {
                throw new Exception("Numero de celular é obrigatório");
            }
            if (model.vl_salario == 0)
            {
                throw new Exception("Salário é obrigatório");
            }

            //*Endereço*

            if (model.ds_endereco == string.Empty)
            {
                throw new Exception("Endereço é obrigatório");
            }
            if (model.ds_cep == string.Empty)
            {
                throw new Exception("CEP é obrigatório");
            }
            if (model.ds_cidade == string.Empty)
            {
                throw new Exception("Cidade é obrigatório");
            }
            if (model.ds_UF == string.Empty)
            {
                throw new Exception("Estado é obrigatório");
            }
            if (model.ds_UF == string.Empty)
            {
                throw new Exception("NumeroEnder é obrigatório");
            }

            db.RemoverFuncionario(id);
        }
    }
}
