namespace Sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        public int IDOrder { get; set; }

        public DateTime? DateOrder { get; set; }

        public DateTime? DateDelivery { get; set; }

        public int? PickUpPoint { get; set; }

        [StringLength(255)]
        public string FIOClient { get; set; }

        public int? CodeRecieve { get; set; }

        public int? StatusOrderID { get; set; }

        public virtual StatusOrder StatusOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
