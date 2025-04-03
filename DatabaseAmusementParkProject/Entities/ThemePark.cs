using Microsoft.EntityFrameworkCore;

namespace DatabaseAmusementParkProject.Entities
{
    // 🧱 This class represents the "ThemeParks" table in the database.
    // Entity Framework uses this class to create the table and manage data for theme parks.
    public class ThemePark
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation property to related ThemePark_Location rows
        public List<ThemePark_Location> ThemePark_Locations { get; set; } =
            new List<ThemePark_Location>();
    }
}
