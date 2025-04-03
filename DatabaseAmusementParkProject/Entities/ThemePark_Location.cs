namespace DatabaseAmusementParkProject.Entities
{
    // 🔗 This class represents a join table (also called a linking or bridge table)
    // between ThemeParks and Locations — a many-to-many relationship.
    // For example: a theme park can exist in multiple locations,
    // and a location can host multiple theme parks.

    public class ThemePark_Location
    {
        public Guid Id { get; set; }

        // Foreign Keys
        public Guid ThemeParkId { get; set; }
        public Guid LocationId { get; set; }

        // Navigation Properties
        public ThemePark ThemePark { get; set; } = new ThemePark();
        public Location Location { get; set; } = new Location();
    }
}
