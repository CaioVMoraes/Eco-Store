﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ecostoreEntities : DbContext
    {
        public ecostoreEntities()
            : base("name=ecostoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_categoria> tb_categoria { get; set; }
        public virtual DbSet<tb_controledeponto> tb_controledeponto { get; set; }
        public virtual DbSet<tb_despesa> tb_despesa { get; set; }
        public virtual DbSet<tb_estoque> tb_estoque { get; set; }
        public virtual DbSet<tb_folhapagamento> tb_folhapagamento { get; set; }
        public virtual DbSet<tb_fornecedor> tb_fornecedor { get; set; }
        public virtual DbSet<tb_funcionario> tb_funcionario { get; set; }
        public virtual DbSet<tb_log> tb_log { get; set; }
        public virtual DbSet<tb_pedido_compra> tb_pedido_compra { get; set; }
        public virtual DbSet<tb_produto> tb_produto { get; set; }
        public virtual DbSet<tb_produto_venda> tb_produto_venda { get; set; }
        public virtual DbSet<tb_usuario> tb_usuario { get; set; }
        public virtual DbSet<tb_venda> tb_venda { get; set; }
        public virtual DbSet<tb_venda_item> tb_venda_item { get; set; }
    }
}
