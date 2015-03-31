using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Reach.DTO
{
    class Input
    {
        public int Id { get; set; }
    }

    public class SignInInput
    {
        [Required(ErrorMessageResourceName = "required")]

        public string UserName { get; set; }

        [Required(ErrorMessageResourceName = "required")]
        [UIHint("Password")]

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}