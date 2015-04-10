namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleDetail")]
    public partial class SaleDetail
    {
        public int Id { get; set; }

        public int? SaleId { get; set; }

        public int? ProductId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        public DateTime? SaleDate { get; set; }

        public bool? IsPosted { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountPrice { get; set; }
    }
}
