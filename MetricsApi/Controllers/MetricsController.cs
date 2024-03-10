using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MetricsApi.Models;
using System.Diagnostics;

namespace MetricsApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MetricsController : ControllerBase
  {
    private readonly MetricsApiContext _db;

    public MetricsController(MetricsApiContext db)
    {
      _db = db;
    }

    // GET api/metrics
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Metric>>> Get()
    {
      return await _db.Metrics.ToListAsync();
    }

    // GET: api/Metrics/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Metric>> GetMetric(int id)
    {
      Metric metric = await _db.Metrics.FindAsync(id);

      if (metric == null)
      {
        return NotFound();
      }

      return metric;
    }

    // GET api/metrics/date
    [HttpGet("bydate/{date}")]
    public async Task<ActionResult<IEnumerable<Metric>>> GetMetricsByDate(string date)
    {
      

      if(DateOnly.TryParse(date, out var selectedDate) is false)
      {
        BadRequest();
      }

        var metrics = await _db.Metrics.Where(metric => metric.Date == selectedDate).ToListAsync();


        Trace.WriteLine(date.ToString());
      return metrics;
    }

    // POST api/metrics
    [HttpPost]
    public async Task<ActionResult<Metric>> Post(Metric metric)
    {
      _db.Metrics.Add(metric);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetMetric), new { id = metric.MetricId }, metric);
    }

    // PUT: api/Metrics/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Metric metric)
    {
      if (id != metric.MetricId)
      {
        return BadRequest();
      }
      
      var existingMetric = await _db.Metrics.FindAsync(id);

      existingMetric.Value = metric.Value;

      _db.Metrics.Update(existingMetric);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MetricExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool MetricExists(int id)
    {
      return _db.Metrics.Any(e => e.MetricId == id);
    }

    // DELETE: api/Metrics/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMetric(int id)
    {
      Metric metric = await _db.Metrics.FindAsync(id);
      if (metric == null)
      {
        return NotFound();
      }

      _db.Metrics.Remove(metric);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}