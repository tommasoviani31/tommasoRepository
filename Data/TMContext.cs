using Microsoft.EntityFrameworkCore;
using TMmvc.Models;

namespace TMmvc.Data
{
    public class TMContext : DbContext
    {
        public TMContext (DbContextOptions<TMContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityType>().HasData(new ActivityType() { Id=1, IsExternal = false, Name = "Generico" });
            modelBuilder.Entity<ActivityType>().HasData(new ActivityType() { Id=2, IsExternal = false, Name = "Sport" });
            modelBuilder.Entity<ActivityType>().HasData(new ActivityType() { Id=3,IsExternal = false, Name = "Consulenza" });
            modelBuilder.Entity<ActivityType>().HasData(new ActivityType() { Id =4,IsExternal = false, Name = "Studio" });
            modelBuilder.Entity<ActivityType>().HasData(new ActivityType() { Id=5, IsExternal = false, Name = "Casa" });                
        }
        
        public DbSet<ActivityType> ActivityType { get; set; }
        public DbSet<Activity> Activity { get; set; }
    }
}