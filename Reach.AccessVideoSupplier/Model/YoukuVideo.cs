using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reach.AccessVideoSupplier.Model
{
   public class YoukuVideo
    {
        public Dictionary<string, object>[] Data { get; set; }
        public Dictionary<string, string> User { get; set; }
        public Dictionary<string, string> Controller { get; set; }
    }
}
