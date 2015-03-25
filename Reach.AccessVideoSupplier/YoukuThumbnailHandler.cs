using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Reach.AccessVideoSupplier.Model;
using Newtonsoft.Json;

namespace Reach.AccessVideoSupplier
{
    public class YoukuThumbnailHandler
    {
        public Byte[] GetThumbnailByYoukuId(string youkuId)
        {
            string url = GetThumbnailUrl(youkuId);
            return GetImgaeByUrl(url);
        }

        public Byte[] GetBigThumbnailByYoukuId(string youkuId)
        {
            string url = GetBigThumbnailUrl(youkuId);
            return GetImgaeByUrl(url);
        }

        public string GetThumbnailUrl(string youkuId)
        {
            string url = "http://events.youku.com/global/api/video-thumb.php?vid={0}";

            return string.Format(url, youkuId);
        }


        public string GetBigThumbnailUrl(string youkuId)
        {
            string url = string.Format("http://v.youku.com/player/getPlayList/VideoIDS/{0}", youkuId);

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string back = client.DownloadString(url);
                YoukuVideo v = JsonConvert.DeserializeObject<YoukuVideo>(back);
                return v.Data.First()["logo"].ToString();
            }
        }

        public byte[] GetImgaeByUrl(string url)
        {
            using (WebClient client = new WebClient())
            {
                byte[] buffer = client.DownloadData(url);

                return buffer;
            }
        }

    }
}
