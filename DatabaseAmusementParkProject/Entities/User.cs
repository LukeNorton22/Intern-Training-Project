namespace DatabaseAmusementParkProject.Entities
{
    // 👤 This class represents a user in the system — someone who can log in, leave reviews, etc.
    // Entity Framework will map this to a "Users" table in the database.

    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
