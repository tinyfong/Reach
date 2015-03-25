using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reach.AccessVideoSupplier.Test
{
    [TestClass]
    public class ThumbnailHandlerTest
    {
        //string url = "http://v.youku.com/player/getPlayList/VideoIDS/XODg3ODYwODgw";
        string youkuId = "XODg3ODYwODgw";

        [TestMethod]
        public void TestGetBigThumbnailUrl()
        {

            string expected = "http://g4.ykimg.com/11270F1F4654DAD3ABB00E000000005A574927-F407-8F61-9BB2-D0D42EC06283";


            YoukuThumbnailHandler handler = new YoukuThumbnailHandler();
            string back = handler.GetBigThumbnailUrl(youkuId);

            Assert.AreEqual<string>(back, expected);
        }

        [TestMethod]
        public void TestGetBigThumbnail()
        {
            YoukuThumbnailHandler handler = new YoukuThumbnailHandler();
            var back = handler.GetBigThumbnailByYoukuId(youkuId);
            Assert.IsNotNull(back);
        }

        [TestMethod]
        public void TestGetThumbnail()
        {
            YoukuThumbnailHandler handler = new YoukuThumbnailHandler();
            var back = handler.GetThumbnailByYoukuId(youkuId);
            Assert.IsNotNull(back);
        }
    }
}
