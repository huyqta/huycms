namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public DateTime? SaleDate { get; set; }

        public int? AccountId { get; set; }

        public int? PartnerId { get; set; }

        [StringLength(500)]
        public string Note { get; set; }
    }
}
