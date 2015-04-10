namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Balance")]
    public partial class Balance
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public DateTime? BalanceDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpeningQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? OpeningBalance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InwardQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? InwardAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OutwardQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? OutwardAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AdjustQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdjustAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ClosingQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ClosingBalance { get; set; }
    }
}
