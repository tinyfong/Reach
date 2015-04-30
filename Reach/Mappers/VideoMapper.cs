using Reach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.DTO;
using Reach.AccessVideoSupplier;
using System.Web.Configuration;

namespace Reach.Mappers
{
    public class VideoMapper : Mapper<Video, YoukuVideoInput>
    {
        public override Video MapToEntity(YoukuVideoInput input, Video entity)
        {
            var foo = base.MapToEntity(input, entity);

            var handler = new YoukuThumbnailHandler();
            foo.BigThumbnail = handler.GetBigThumbnailByYoukuId(foo.YoukuId);
            foo.Thumbnail = handler.GetThumbnailByYoukuId(foo.YoukuId);
            foo.Url = handler.GetVideoUrlByYoukuId(foo.YoukuId);


            return foo;
        }
    }
}