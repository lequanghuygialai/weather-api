using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WeatherApp.Models;

namespace WeatherApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<WeatherSummary> WeatherSummaries { get; set; }
    }
}
