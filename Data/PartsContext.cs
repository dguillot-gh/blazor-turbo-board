using Microsoft.EntityFrameworkCore;
namespace TurboKanban.Data;

public class PartsContext : DbContext
{
    public PartsContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Parts> Parts { get; set; }
}