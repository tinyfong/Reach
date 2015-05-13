using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reach.DTO
{
    public class Input
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

        [Display(Name = "记住我")]
        public bool RememberMe { get; set; }
    }

    public class YoukuVideoInput : Input
    {
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "优酷ID")]
        public string YoukuId { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; }
        [Display(Name = "客户")]
        public string Customer { get; set; }
        [Display(Name = "等级")]
        public Nullable<int> Rank { get; set; }

    }

    public class DeleteInput : Input
    {

    }

    public class WebsiteInfoInput : Input
    {
        [AllowHtml]
        public string HtmlContent { get; set; }
    }
}