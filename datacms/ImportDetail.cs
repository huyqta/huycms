namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportDetail")]
    public partial class ImportDetail
    {
        public int Id { get; set; }

        public int? ImportId { get; set; }

        public int? ProductId { get; set; }

        [StringLength(500)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        public DateTime? ImportDate { get; set; }

        public bool? IsPosted { get; set; }

        public int? UnitId { get; set; }

        public int? CategoryId { get; set; }

        public int? TrademarkId { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }
    }
}
