using BUYList.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BUYList.Infra.Data
{
    public class DataContext :
    DbContext
    {
        public DataContext
        (DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
