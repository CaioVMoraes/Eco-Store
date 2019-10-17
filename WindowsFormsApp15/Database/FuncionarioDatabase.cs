using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class FuncionarioDatabase
    {
        Model.ecostoreEntities db = new Model.ecostoreEntities();

        public void CadastrarFuncionario(tb_funcionario funcionario)
        {
            db.tb_funcionario.Add(funcionario);
            db.SaveChanges(); 

        }
        public List<tb_funcionario> ConsultarFuncionarioNome(string Nome)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.nm_funcionario == Nome).ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionarioRg(string Rg)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.ds_rg == Rg).ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionarioCpf(string cpf)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.ds_cpf == cpf).ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionarioCargo(string Cargo)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.ds_cargo == Cargo).ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionarioContracao(DateTime Contrat)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.dt_contratacao == Contrat).ToList();

            return lista;
        }

        public tb_funcionario Listar(int id)
        {
            tb_funcionario modelo = db.tb_funcionario.FirstOrDefault(x => x.id_funcionario == id);

            return modelo;
        }

        public void AlterarFuncionario(tb_funcionario modelo)
        {
            tb_funcionario alterar = db.tb_funcionario.FirstOrDefault(x => x.nm_funcionario == x.nm_funcionario);

            modelo.nm_funcionario = alterar.nm_funcionario;
            modelo.vl_salario = alterar.vl_salario;
            modelo.ds_cargo = alterar.ds_cargo;
            modelo.ds_celular = alterar.ds_celular;
            modelo.ds_cep = alterar.ds_cep;
            modelo.ds_cidade = alterar.ds_cidade;
            modelo.ds_complemento = alterar.ds_complemento;
            modelo.ds_cpf = alterar.ds_cpf;
            modelo.ds_email = alterar.ds_email;
            modelo.ds_endereco = alterar.ds_endereco;
            modelo.ds_genero = alterar.ds_genero;
            modelo.ds_numeroCasa = alterar.ds_numeroCasa;
            modelo.ds_rg = alterar.ds_rg;
            modelo.ds_telefone = alterar.ds_telefone;
            modelo.ds_UF = alterar.ds_UF;
            modelo.dt_contratacao = alterar.dt_contratacao;
            modelo.dt_nascimento = alterar.dt_nascimento;

            db.SaveChanges();

        }

        public void RemoverFuncionario(int id)
        {
            tb_funcionario modelo = db.tb_funcionario.FirstOrDefault(x => x.id_funcionario == id);
            db.tb_funcionario.Remove(modelo);

            db.SaveChanges();
        }
    }
}
