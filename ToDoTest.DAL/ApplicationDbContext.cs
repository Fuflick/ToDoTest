using Microsoft.EntityFrameworkCore;

namespace ToDoTest.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasKey(t => t.Id);

            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Task>? Tasks { get; set; }
    }
}

