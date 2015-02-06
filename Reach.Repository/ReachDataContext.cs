namespace Reach.Repository
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ReachDataContext : DbContext
    {
        // Your context has been configured to use a 'ReachDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Reach.Repository.ReachDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ReachDataContext' 
        // connection string in the application configuration file.
        public ReachDataContext()
            : base("name=Reach")
        {
        }        

        public virtual DbSet<Movie> Movies { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        //public string Remark { get; set; }
    }
}