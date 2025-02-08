using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TurboKanban.Models;

namespace TurboKanban.Data
{
    public class TurboKanbanContext : DbContext
    {
        public TurboKanbanContext (DbContextOptions<TurboKanbanContext> options)
            : base(options)
        {
        }

        public DbSet<TurboKanban.Models.Parts> Parts { get; set; } = default!;
    }
}
