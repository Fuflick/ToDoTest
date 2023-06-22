using System;
using Microsoft.EntityFrameworkCore;

namespace ToDoTest.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Task> Tasks { get; set; } 
    }
}

