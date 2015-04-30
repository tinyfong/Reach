using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Drawing;
using Reach.AccessVideoSupplier;
using Reach.Core;

namespace Reach.Models
{
    public class Video : Entity
    {
        [Display(Name = "优酷ID")]
        public string YoukuId { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "Url")]
        public string Url { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; }
        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "客户")]
        public string Customer { get; set; }
        [Display(Name = "等级")]
        public int? Rank { get; set; }

        public byte[] BigThumbnail { get; set; }

        public byte[] Thumbnail { get; set; }

    }
}