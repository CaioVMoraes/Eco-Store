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
    
    public partial class tb_produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_produto()
        {
            this.tb_estoque = new HashSet<tb_estoque>();
            this.tb_fornecedor = new HashSet<tb_fornecedor>();
            this.tb_venda = new HashSet<tb_venda>();
            this.tb_venda_item = new HashSet<tb_venda_item>();
        }
    
        public int id_produto { get; set; }
        public string nm_produto { get; set; }
        public string ds_categoria { get; set; }
        public decimal vl_valor { get; set; }
        public int id_fornecedor { get; set; }
        public Nullable<int> qtd_disponivel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_estoque> tb_estoque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_fornecedor> tb_fornecedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_venda> tb_venda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_venda_item> tb_venda_item { get; set; }
    }
}
