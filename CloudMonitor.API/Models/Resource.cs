namespace CloudMonitor.API.Models;

public class Resource
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

        public double CPUUsage { get; set; }

    public double MemoryUsage { get; set; }

    public decimal MonthlyCost { get; set; }
}
