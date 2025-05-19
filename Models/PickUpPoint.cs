namespace Sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PickUpPoint")]
    public partial class PickUpPoint
    {
        [Key]
        public int IDPickUpPoint { get; set; }

        public int? Index { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(255)]
        public string Street { get; set; }

        public int? HouseNumber { get; set; }
    }
}
