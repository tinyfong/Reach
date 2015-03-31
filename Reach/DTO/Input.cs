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
        [Required]
        [Display(Name = "用户名")]
        [UIHint("用户名")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        [UIHint("密码")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}