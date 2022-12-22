using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace HartWebApi
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<InventoryEntry> Entries { get; set; }
        public DbSet<InventoryItem> Items { get; set; }
    }
}
