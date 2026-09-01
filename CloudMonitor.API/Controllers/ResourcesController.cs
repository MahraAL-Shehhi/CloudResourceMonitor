using CloudMonitor.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudMonitor.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResourcesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetResources()
    {
        var resources = new List<Resource>
        {
            new Resource
            {
                Id = 1,
                Name = "VM-01",
                Type = "Virtual Machine",
                Status = "Running",
                CPUUsage = 15,
                MemoryUsage = 30,
                MonthlyCost = 12
            },

            new Resource
            {
                Id = 2,
                Name = "Database-01",
                Type = "PostgreSQL",
                Status = "Running",
                CPUUsage = 10,
                MemoryUsage = 20,
                MonthlyCost = 8
            }
        };

        return Ok(resources);
    }
}