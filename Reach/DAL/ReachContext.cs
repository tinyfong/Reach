﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Reach.Models;

namespace Reach.DAL
{
    public class ReachContext : DbContext
    {
        public ReachContext()
            : base("ReachContext")
        {

        }

        public DbSet<Video> Videos { get; set; }

        public DbSet<User> UserProfiles { get; set; }

        public DbSet<WebsiteInfo> WebsiteInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}