using Microsoft.EntityFrameworkCore;
using SQLLite.Models;

namespace SQLlite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Dummy> Peaks => Set<Dummy>();

    }
}