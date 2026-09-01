using CloudMonitor.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudMonitor.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Resource> Resources { get; set; }
}