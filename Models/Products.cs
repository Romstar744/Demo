namespace Sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        [StringLength(255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string IDProductArticulNumber { get; set; }

        [StringLength(255)]
        public string NameProduct { get; set; }

        [StringLength(255)]
        public string UnitOfMeasurement { get; set; }

        public int? Cost { get; set; }

        public int? MaxProbablySaleSize { get; set; }

        public int? ManufacturerID { get; set; }

        public int? SupplierID { get; set; }

        public int? CathegoryProductID { get; set; }

        public int? CurrentSale { get; set; }

        public int? AmountInStock { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        public virtual CathegoryProduct CathegoryProduct { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        public virtual Supplier Supplier { get; set; }

        public bool isNew()
        {
            return string.IsNullOrEmpty(IDProductArticulNumber);
        }
    }
}
