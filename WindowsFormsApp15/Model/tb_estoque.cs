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
    
    public partial class tb_estoque
    {
        public int id_estoque { get; set; }
        public int id_fornecedor { get; set; }
        public int id_produto { get; set; }
        public Nullable<System.DateTime> dt_entrada { get; set; }
        public Nullable<System.DateTime> dt_validade { get; set; }
        public decimal vl_valor { get; set; }
        public int qtd_produto { get; set; }
    
        public virtual tb_produto tb_produto { get; set; }
        public virtual tb_fornecedor tb_fornecedor { get; set; }
    }
}
