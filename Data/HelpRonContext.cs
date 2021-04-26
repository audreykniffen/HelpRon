using Microsoft.EntityFrameworkCore;
using HelpRon.Models;

namespace HelpRon.Data
{
    public class HelpRonContext : DbContext
    {
        public HelpRonContext(DbContextOptions<HelpRonContext> options)
            : base(options)
        {
        }

        public DbSet<Need> Need { get; set; }
    }
}