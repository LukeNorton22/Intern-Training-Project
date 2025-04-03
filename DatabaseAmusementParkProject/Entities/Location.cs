namespace DatabaseAmusementParkProject.Entities
{
    // 🧱 This class represents a table in the database called "Locations"
    // Entity Framework Core will automatically map this class to a table
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation property for linked ThemePark_Location records
        public List<ThemePark_Location> ThemePark_Locations { get; set; } =
            new List<ThemePark_Location>();
    }
}
