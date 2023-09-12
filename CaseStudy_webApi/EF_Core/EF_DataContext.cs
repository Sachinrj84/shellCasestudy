using Microsoft.EntityFrameworkCore;

namespace CaseStudy_webApi.EF_Core
{
    public class EF_DataContext:DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Incident> Incidents { get; set; }

    }
}
