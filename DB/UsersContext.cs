using Microsoft.EntityFrameworkCore;
using Users.Models;

namespace UsersContext.DB
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}