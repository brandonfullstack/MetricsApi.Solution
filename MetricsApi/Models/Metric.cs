namespace MetricsApi.Models
{
  public class Metric
  {
    public int MetricId { get; set; }
    public int Value { get; set; }
    public DateTime Date { get; set; }
    public int? UserId { get; set; }
    public int PortalId { get; set; }
    public int InteractionId { get; set; }
  }
}