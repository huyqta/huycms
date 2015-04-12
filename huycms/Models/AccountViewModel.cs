using datacms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace huycms.Models
{
    public class AccountViewModel : BaseViewModel
    {
        public List<Account> ListAccount { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        public bool IsAdmin { get; set; }

        public bool Active { get; set; }

        [Required]
        public string Fullname { get; set; }

        public ActionState ActionState { get; set; }
    }
}