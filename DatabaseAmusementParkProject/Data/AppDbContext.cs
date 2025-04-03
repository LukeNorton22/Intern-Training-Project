using DatabaseAmusementParkProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAmusementParkProject.Data
{
    // 🧠 This class represents your connection to the database.
    // It inherits from DbContext, which is the main class in Entity Framework Core
    // used to query and save data from/to the database.

    public class AppDbContext : DbContext
    {
        // 🔐 IConfiguration is used to access values from appsettings.json
        // We use it here to retrieve the database connection string.
        protected readonly IConfiguration _configuration;

        // 📦 Constructor that receives configuration via dependency injection
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // ⚙️ This method is called when the DbContext is being set up.
        // We tell it which database provider to use and pass the connection string.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // In this case, we’re using PostgreSQL via the Npgsql provider.
            options.UseNpgsql(_configuration.GetConnectionString("WebApiDatabase"));
        }

        // 🧱 These properties represent the database tables.
        // Each DbSet<T> corresponds to a table where T is an entity class.

        public DbSet<ThemePark> ThemeParks { get; set; } // Table for theme parks
        public DbSet<Location> Locations { get; set; } // Table for locations
        public DbSet<ThemePark_Location> ThemeParks_Locations { get; set; } // Many-to-many linking table
        public DbSet<User> Users { get; set; } // Table for users

        // ✅ When you run migrations, EF Core will use these properties to generate database tables
        // based on the structure defined in each corresponding entity class.
    }
}
