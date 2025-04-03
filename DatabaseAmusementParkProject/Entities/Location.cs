namespace DatabaseAmusementParkProject.Entities
{
    // 🧱 This class represents a table in the database called "Locations"
    // Entity Framework Core will automatically map this class to a table
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
