using Microsoft.EntityFrameworkCore;

namespace HartWebApi
{
    public class SettingsContext : DbContext
    {
        public SettingsContext(DbContextOptions<SettingsContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<SettingsEntry> Settings { get; set; }
    }
}
