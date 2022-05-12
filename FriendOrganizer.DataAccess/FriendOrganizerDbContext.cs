using FriendOrganizer.Model;
using Microsoft.EntityFrameworkCore;

namespace FriendOrganizer.DataAccess
{
    public class FriendOrganizerDbContext : DbContext
    {
        public DbSet<Friend> Friends { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=FriendOrganizerDb;Initial Catalog=FriendOrganizer;Integrated Security=true;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Friend>().HasData(
                new Friend { Id = 1, FirstName = "Thomas", LastName = "Anderson", Email = "thomasa@testfriendapp.com" },
                new Friend { Id = 2, FirstName = "Chuck", LastName = "Norris", Email = "chuckn@testfriendapp.com" },
                new Friend { Id = 3, FirstName = "Bruce", LastName = "Lee", Email = "brucel@testfriendapp.com" },
                new Friend { Id = 4, FirstName = "Jackie", LastName = "Chan", Email = "jackiec@testfriendapp.com" },
                new Friend { Id = 5, FirstName = "Jet", LastName = "Li", Email = "jetl@testfriendapp.com" }
                );
        }
    }
}
