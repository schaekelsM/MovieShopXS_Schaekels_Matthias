using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopXS.Models
{
    public class MovieBaseContext : DbContext
    {
        private IConfigurationRoot _config;

        public MovieBaseContext(DbContextOptions options, IConfigurationRoot config) :base(options)
        {
            _config = config;
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<MovieActor> MovieActor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //needs to change
            optionsBuilder.UseSqlServer(_config["ConnectionString"]);
        }

    }
}
