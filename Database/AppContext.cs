using app_config_demo.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace app_config_demo.Database
{
    public class AppContext : DbContext
    {
        private readonly Settings _settings;

        public AppContext(DbContextOptions<AppContext> options,
            IOptionsSnapshot<Settings> settingsSnapshot)
            : base(options)
        {
            _settings = settingsSnapshot.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_settings.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
