namespace Sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderProduct")]
    public partial class OrderProduct
    {
        [Key]
        public int IDOrderProduct { get; set; }

        public int? IDOrder { get; set; }

        [StringLength(255)]
        public string ProductArticulNumberID { get; set; }

        public virtual Order Order { get; set; }

        public virtual Products Products { get; set; }
    }
}
