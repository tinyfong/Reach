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
        public string YoukuId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Customer { get; set; }
        public int? Rank { get; set; }

        public virtual byte[] BigThumbnail { get; set; }

        public virtual byte[] Thumbnail { get; set; }
    }
}