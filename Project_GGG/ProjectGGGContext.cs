using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project_GGG.Models;

namespace Project_GGG
{
    public class ProjectGGGContext : DbContext
    {
        public ProjectGGGContext
            (DbContextOptions<ProjectGGGContext> options) 
            :base(options) 
        {
            
        }
        public DbSet<Pricing> Pricing { get; set; }
    }
}
