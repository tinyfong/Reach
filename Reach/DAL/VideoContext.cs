using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Reach.Models;

namespace Reach.DAL
{
    public class VideoContext : DbContext
    {
        public VideoContext()
            : base("VideoContext")
        {

        }

        public DbSet<Video> Videos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           
            base.OnModelCreating(modelBuilder);
        }
    }
}