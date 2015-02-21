using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
namespace Reach.AccessYouku.Test
{
    [TestClass]
    public class ThumbnailHandlerTest
    {
        string url = "http://v.youku.com/player/getPlayList/VideoIDS/XODg3ODYwODgw";

        [TestMethod]
        public void TestGetBigThumbnailUrl()
        {

            string expected = "http://g4.ykimg.com/11270F1F4654DAD3ABB00E000000005A574927-F407-8F61-9BB2-D0D42EC06283";


            ThumbnailHandler handler = new ThumbnailHandler();
            string back = handler.GetBigThumbnailUrl(url);

            Assert.AreEqual<string>(back, expected);
        }

        [TestMethod]
        public void TestGetBigThumbnail()
        {
            ThumbnailHandler handler = new ThumbnailHandler();
            var back = handler.GetBigThumbnail(url);
            Assert.IsNotNull(true);
        }
    }
}
