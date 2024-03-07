using Microsoft.EntityFrameworkCore;

namespace MetricsApi.Models
{
  public class MetricsApiContext : DbContext
  {
    public DbSet<Metric> Metrics { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Portal> Portals { get; set; }
    public DbSet<Interaction> Interactions { get; set; }

    public MetricsApiContext(DbContextOptions<MetricsApiContext> options) : base(options)
    {
    }
  }
}