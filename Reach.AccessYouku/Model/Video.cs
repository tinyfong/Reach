using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reach.AccessYouku.Model
{
    public class Video
    {
        public Dictionary<string,object>[] Data { get; set; }
        public Dictionary<string, string> User { get; set; }
        public Dictionary<string, string> Controller { get; set; }
    }
}
