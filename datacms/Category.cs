namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? ParentId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Note { get; set; }

        public bool? Active { get; set; }

        public int? Level { get; set; }

        public bool? IsDelete { get; set; }
    }
}
