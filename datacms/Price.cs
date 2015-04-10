namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Price")]
    public partial class Price
    {
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [Column("Price", TypeName = "money")]
        public decimal? Price1 { get; set; }

        public DateTime? DateUpdate { get; set; }

        public bool? Active { get; set; }
    }
}
