using Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace NetCoreGNG.Data
{
    public class DatabaseContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Post> Posts { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=NetCoreApplication;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id=1,
                    CreateDate= DateTime.Now,
                    IsActive= true,
                    Name="Admin",
                    Surname="esg",
                    Password="1234",
                    Username="Admin",
                    Eposta="admin@gmail.com",
                    Phone="5555200979"
                }
                );
            base.OnModelCreating(modelBuilder); 
        }

    }
}
