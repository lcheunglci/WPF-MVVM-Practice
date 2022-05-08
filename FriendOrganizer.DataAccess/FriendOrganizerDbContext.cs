using FriendOrganizer.Model;
using Microsoft.EntityFrameworkCore;

namespace FriendOrganizer.DataAccess
{
    class FriendOrganizerDbContext : DbContext
    {
        public DbSet<Friend> Friend { set; get; }
    }
}
