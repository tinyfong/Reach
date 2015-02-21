using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Reach.AccessYouku.Model;
using System.Drawing;
using System.IO;

namespace Reach.AccessYouku
{
    public class ThumbnailHandler
    {
        public string GetBigThumbnailUrl(string url)
        {
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string back = client.DownloadString(url);
                Video v = JsonConvert.DeserializeObject<Video>(back);
                return v.Data.First()["logo"].ToString();
            }
        }

        public Image GetBigThumbnail(string url)
        {
            string imgUrl = this.GetBigThumbnailUrl(url);

            using (WebClient client = new WebClient())
            {
                byte[] buffer = client.DownloadData(imgUrl);
                MemoryStream ms = new MemoryStream(buffer);
                Image img = Image.FromStream(ms);
                return img;
            }

        }
    }
}
