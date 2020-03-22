using BeerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerAPI.Entities
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Style> Styles { get; set; }
    }
}
