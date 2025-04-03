using DatabaseAmusementParkProject.Data; // Provides access to your application's database
using DatabaseAmusementParkProject.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseAmusementParkProject.Controllers
{
    // 🧭 Marks this class as an API controller
    // Enables automatic model validation, binding, and helpful HTTP responses
    [ApiController]
    // 🛣️ Sets the base route for all endpoints in this controller
    // [controller] becomes the controller name without "Controller" (e.g., "/template")
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        // 🧠 What is a Controller?
        // A controller handles HTTP requests from the frontend or client.
        // It receives data from the client, processes it using services or the DbContext,
        // and returns a response (e.g., JSON data or HTTP status codes).

        // ✅ Fields for dependencies

        // 🔹 This is the application's database context.
        // It lets you query and save data directly to the database.
        private readonly AppDbContext _context;

        // 🔹 This is the interface for the service that contains the business logic.
        // Services help keep your controller clean by moving logic (like validation,
        // calculations, or rule enforcement) out of the controller.
        // You create the interface (e.g., ITemplateService) and its implementation (TemplateService).
        private readonly ITemplateInterface _templateService;

        // 🔧 Constructor injection
        // ASP.NET Core automatically provides these when it creates the controller.
        // This is called "Dependency Injection", and it keeps your code loosely coupled and testable.
        public TemplateController(AppDbContext context, ITemplateInterface templateService)
        {
            _context = context;
            _templateService = templateService;
        }

        // 🚧 Endpoint methods (like GET, POST, PUT, DELETE) will go here
        // These will use _templateService to perform logic,
        // and may use _context for direct database access if needed.
    }
}
