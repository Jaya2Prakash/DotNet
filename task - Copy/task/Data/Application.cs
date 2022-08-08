using Microsoft.EntityFrameworkCore;
using task.Models;

namespace task.Data
{
    public class Application : DbContext
    {
        public Application(DbContextOptions<Application> options) : base(options)
        {

        }


        public DbSet<Property> properties { get; set; }
    }
}
