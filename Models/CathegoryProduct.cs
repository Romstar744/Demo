namespace Sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CathegoryProduct")]
    public partial class CathegoryProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CathegoryProduct()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int IDCathegoryProduct { get; set; }

        [Column("CathegoryProduct")]
        [StringLength(255)]
        public string CathegoryProduct1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
