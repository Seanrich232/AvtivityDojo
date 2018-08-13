using Microsoft.EntityFrameworkCore;
using AvtivityDojo.Models;

namespace AvtivityDojo
{
    public class DojoContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DojoContext(DbContextOptions<DojoContext> options) : base(options) { }
			//table name
        public DbSet<User> user { get; set; }
        public DbSet<Events> events { get; set; }
        public DbSet<DojoAct> dojoact { get; set; }
    }
}