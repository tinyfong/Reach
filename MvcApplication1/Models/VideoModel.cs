using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class VideoModel
    {
        public int Id { get; set; }
        public string YoukuId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string UpdateTime { get; set; }
        public string Customer { get; set; }
        public Nullable<int> Rank { get; set; }
    }
}