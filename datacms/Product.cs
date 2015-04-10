namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(500)]
        public string ProductName { get; set; }

        public bool? Active { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }

        public int? UnitId { get; set; }

        public int? PriceId { get; set; }

        public int? CategoryId { get; set; }

        public int? TrademarkId { get; set; }

        public bool? IsDelete { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}
