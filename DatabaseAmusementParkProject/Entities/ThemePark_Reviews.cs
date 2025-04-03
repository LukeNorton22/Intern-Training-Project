namespace DatabaseAmusementParkProject.Entities
{
    // 📝 This class represents a review left by a user for a specific theme park at a specific location.
    // It will map to a table in the database, likely named "ThemePark_Reviews".

    public class ThemePark_Reviews
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public Guid ThemeParkLocationId { get; set; }

        // Navigation properties
        public User User { get; set; } = new User();
        public ThemePark_Location ThemeParkLocation { get; set; } = new ThemePark_Location();
    }
}
