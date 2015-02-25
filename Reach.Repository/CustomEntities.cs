using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Reach.Repository.Model;

namespace Reach.Repository
{
    [MetadataType(typeof(VideoModel))]
    public partial class Video : IBaseEntity { }
}
