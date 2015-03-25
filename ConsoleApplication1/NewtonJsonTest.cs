using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reach.AccessVideoSupplier.Model;
using Newtonsoft.Json;
using System.Net;

namespace ConsoleApplication1
{
    class NewtonJsonTest
    {
        public void Run()
        {
            using (WebClient c = new WebClient())
            {
                string url = "http://v.youku.com/player/getPlayList/VideoIDS/XODg3ODYwODgw";
                string s = c.DownloadString(url);
                YoukuVideo v = JsonConvert.DeserializeObject<YoukuVideo>(s);
                            
            }

        }
    }
}
