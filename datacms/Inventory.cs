namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        public long Id { get; set; }

        public int? RefId { get; set; }

        [StringLength(50)]
        public string RefCode { get; set; }

        public DateTime? RefDate { get; set; }

        public int? RefType { get; set; }

        public int? ProductId { get; set; }

        [StringLength(500)]
        public string ProductName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        public int? AccountId { get; set; }

        public int? PartnerId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }
    }
}
