// 📦 What is a DTO?
// DTO stands for Data Transfer Object.
// It is a simple class used to transfer data between layers of an application,
// especially between the backend and frontend (or API consumers).
//
// 🔒 Why use a DTO instead of returning entities directly?
// - It protects your database structure by hiding unnecessary or sensitive fields
// - It shapes the data exactly how the frontend needs it (e.g., combining or renaming fields)
// - It improves performance by sending only what’s needed
// - It helps enforce separation of concerns and keeps your app maintainable
//
// 📍 Where are DTOs used?
// - In the Service layer: to convert Entity data into a clean format
// - In the Controller layer: to return responses (or accept requests)
// - In the API client or frontend: to consume structured data

namespace DatabaseAmusementParkProject.DTOs
{
    public class ParkDTO
    {
        public string ParkName { get; set; } = string.Empty;
        public string ParkLocation { get; set; } = string.Empty;
        public Guid ParkId { get; set; }
        public Guid ParkLocationId { get; set; }
    }
}
