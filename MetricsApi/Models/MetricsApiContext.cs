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
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Metric>()
        .HasData(
          new Metric { MetricId = 1, Value = 2, Date = new DateTime(2024,03,06,3,15,1), UserId = 1, PortalId = 1, InteractionId = 1 },
          new Metric { MetricId = 2, Value = 7, Date = new DateTime(2024,03,06,4,15,0), UserId = 2, PortalId = 2, InteractionId = 2 },
          new Metric { MetricId = 3, Value = 9, Date = new DateTime(2024,03,06,20,15,0), UserId = 3, PortalId = 3, InteractionId = 3 },
          new Metric { MetricId = 4, Value = 23, Date = new DateTime(2024,03,06,6,15,0), UserId = 4, PortalId = 4, InteractionId = 4 },
          new Metric { MetricId = 5, Value = 15, Date = new DateTime(2024,03,06), UserId = 5, PortalId = 5, InteractionId = 5 }
        );

      builder.Entity<User>()
        .HasData(
          new User { UserId = 1, FirstName = "Brad", LastName = "Ross" },
          new User { UserId = 2, FirstName = "John", LastName = "Smith" },
          new User { UserId = 3, FirstName = "Beth", LastName = "Baily" },
          new User { UserId = 4, FirstName = "Steve", LastName = "Nash" },
          new User { UserId = 5, FirstName = "Mark", LastName = "Brown" }
        );
      
      builder.Entity<Portal>()
        .HasData(
          new Portal { PortalId = 1, PortalName = "CAREWare" },
          new Portal { PortalId = 2, PortalName = "AIMS2.0" },
          new Portal { PortalId = 3, PortalName = "CTLS" },
          new Portal { PortalId = 4, PortalName = "HIVD2C" },
          new Portal { PortalId = 5, PortalName = "STARS" }
        );
      
      builder.Entity<Interaction>()
        .HasData(
          new Interaction { InteractionId = 1, InteractionName = "Calls Made" },
          new Interaction { InteractionId = 2, InteractionName = "Calls Received" },
          new Interaction { InteractionId = 3, InteractionName = "Emails Received" },
          new Interaction { InteractionId = 4, InteractionName = "Emails Sent" },
          new Interaction { InteractionId = 5, InteractionName = "Meetings" }
        );
    }
  }
}