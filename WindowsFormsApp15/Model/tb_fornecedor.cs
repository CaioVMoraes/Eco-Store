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
    
    public partial class tb_fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_fornecedor()
        {
            this.tb_estoque = new HashSet<tb_estoque>();
            this.tb_produto = new HashSet<tb_produto>();
        }
    
        public int id_fornecedor { get; set; }
        public string nm_fornecedor { get; set; }
        public string nm_empresa { get; set; }
        public string ds_telefone { get; set; }
        public string ds_celular { get; set; }
        public string ds_endereco { get; set; }
        public string ds_cnpj { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_estoque> tb_estoque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_produto> tb_produto { get; set; }
    }
}
