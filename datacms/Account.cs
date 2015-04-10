namespace datacms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? Active { get; set; }

        [StringLength(500)]
        public string Fullname { get; set; }

        public bool? IsDelete { get; set; }
    }
}
