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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_estoque()
        {
            this.tb_venda_item = new HashSet<tb_venda_item>();
        }
    
        public int id_estoque { get; set; }
        public int id_produto { get; set; }
        public System.DateTime dt_entrada { get; set; }
        public decimal vl_valor { get; set; }
        public Nullable<bool> bt_vendido { get; set; }
    
        public virtual tb_produto tb_produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_venda_item> tb_venda_item { get; set; }
    }
}
