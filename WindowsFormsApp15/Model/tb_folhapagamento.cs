//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp15.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_folhapagamento
    {
        public int id_folhaPagamento { get; set; }
        public int id_funcionario { get; set; }
        public int id_controleDePonto { get; set; }
        public System.DateTime dt_pagamento { get; set; }
        public decimal vl_gratificacoes { get; set; }
        public decimal vl_plr { get; set; }
        public decimal vl_salarioFamilia { get; set; }
        public decimal vl_valeAlimentacao { get; set; }
        public decimal vl_valeRefeicao { get; set; }
        public decimal vl_valeTransporte { get; set; }
        public decimal vl_inss { get; set; }
        public decimal vl_ir { get; set; }
        public decimal vl_fgts { get; set; }
        public decimal vl_planoSaude { get; set; }
        public decimal vl_planoOdonto { get; set; }
        public decimal vl_faltas { get; set; }
        public decimal vl_liquido { get; set; }
    
        public virtual tb_controledeponto tb_controledeponto { get; set; }
        public virtual tb_funcionario tb_funcionario { get; set; }
    }
}
