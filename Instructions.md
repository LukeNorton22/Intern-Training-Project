# 🧑‍💻 Intern Assignment: Park & Review API Feature Tasks

This document outlines the step-by-step tasks for building out the backend API functionality for parks and reviews. You’ll work in **two controllers**: `ParkController` and `ReviewController`.

---

## ✅ Stage 1: `ParkController` — Parks and Locations Only

1. Create a service interface called `IParkServiceInterface`.

2. Create a controller called `ParkController`, and inject the `IParkServiceInterface` inside of it.

3. Create a service class called `ParkService`, and make sure it inherits from `IParkServiceInterface`.

---

## ✅ Stage 2: Implement Park & Location Endpoints

- Implement the following endpoints in the `ParkController`.
- Implement business logic in the `ParkService`
- Make sure to define your methods in `IParkServiceInterface` so you can use them in the `ParkService`

---

### 1. Get All Parks
- **Route:** `GET api/park/parks`
- **Input:** None
- **Returns:** `List<ParkDTO>`
- **Description:** Return all theme parks with their names, locations, IDs, and park-location IDs.

---

### 2. Get Park by ID
- **Route:** `GET api/park/parks/{parkId}`
- **Input:** `parkId` (GUID) as route parameter
- **Returns:** `ParkDTO`
- **Description:** Return a single park with location info by its unique ID.

---

### 3. Create a New Park
- **Route:** `POST api/park/parks`
- **Input:** `ParkDTO` (in request body)
- **Returns:** Confirmation message or created object
- **Description:** Create a new theme park and associate it with a location.

---

### 4. Update an Existing Park
- **Route:** `PUT api/park/parks/{parkId}`
- **Input:** `parkId` (GUID) as route parameter + `ParkDTO` (body)
- **Returns:** Confirmation message
- **Description:** Update the name or location of an existing park.

---

### 5. Delete a Park
- **Route:** `DELETE api/park/parks/{parkId}`
- **Input:** `parkId` (GUID) as route parameter
- **Returns:** Success or error message
- **Description:** Delete a park and its park-location relationship.

---

### 6. Get All Locations
- **Route:** `GET api/park/locations`
- **Input:** None
- **Returns:** List of `Location` entities or `LocationDTO`
- **Description:** Return all location records in the database.

---

### 7. Get Location by ID
- **Route:** `GET api/park/locations/{locationId}`
- **Input:** `locationId` (GUID) as route parameter
- **Returns:** Single `Location` or `LocationDTO`
- **Description:** Return one location based on its ID.

---

### 8. Create a New Location
- **Route:** `POST api/park/locations`
- **Input:** `LocationDTO` (in request body)
- **Returns:** Success message or new location
- **Description:** Add a new location to the database.

---

### 9. Update a Location
- **Route:** `PUT api/park/locations/{locationId}`
- **Input:** `locationId` (GUID) as route parameter + `LocationDTO` (body)
- **Returns:** Success or error message
- **Description:** Update the name of an existing location.

---

### 10. Delete a Location
- **Route:** `DELETE api/park/locations/{locationId}`
- **Input:** `locationId` (GUID) as route parameter
- **Returns:** Success or error message
- **Description:** Delete a location (only allowed if not in use by a park).

---

### 11. Get Parks by Location
- **Route:** `GET api/park/parks/location/{locationId}`
- **Input:** `locationId` (GUID) as route parameter
- **Returns:** List of `ParkDTO`
- **Description:** Return all parks that exist in a specific location.

---

### 12. Search Parks by Name
- **Route:** `GET api/park/GetParksBySearch?searchTerm=YourSearchTerm`
- **Input:** `searchTerm` (query string)
- **Returns:** List of `ParkDTO`
- **Description:** Search for parks using a case-insensitive string match on the park name.

---

# ✅ Stage 3: ReviewController — ThemePark Reviews

In this stage, you’ll create functionality for managing theme park reviews. This includes:

- A new entity (ThemePark_Review)  
- DTOs (ReviewDTO, ReviewRequest)  
- A service interface and implementation  
- A controller with endpoints to create, retrieve, and delete reviews

---

## 1. Create the ThemePark_Review Entity

**File:** Models/ThemePark_Review.cs

public class ThemePark_Review  
{  
  public Guid Id { get; set; }  
  public Guid UserId { get; set; }  
  public int Rating { get; set; }  
  public string? Comment { get; set; }  
  public Guid ThemeParkLocationId { get; set; }  

  // Navigation property  
  public ThemeParkLocation ThemeParkLocation { get; set; }  
}

**Description:**  
This entity stores user reviews for a specific park location. Set up the correct navigation property to ThemeParkLocation and configure EF relationships as needed by creating a migration. 

---

## 2. Create Review DTOs

### ReviewDTO.cs

public class ReviewDTO  
{  
  public Guid ReviewId { get; set; }  
  public Guid UserId { get; set; }  
  public string Comment { get; set; }  
  public int Rating { get; set; }  
  public Guid ThemeParkId { get; set; }  
  public Guid ThemeParkLocationId { get; set; }  
  public string ThemeParkName { get; set; }  
}

### ReviewRequestDTO.cs

public class ReviewRequestDTO  
{  
  public Guid? Id { get; set; }  
  public string Review { get; set; }  
  public Guid UserId { get; set; }  
  public int RatingScore { get; set; }  
  public Guid ThemeParkId { get; set; }  
  public Guid ThemeParkLocationId { get; set; }  
}

---

## 3. Create Review Service

- Interface: IReviewServiceInterface  
- Implementation: ReviewService  

### Register the service

Add this to your DI container (Startup.cs or Program.cs):

services.AddScoped<IReviewServiceInterface, ReviewService>();

---

## 🧪 Implement Review Endpoints

### 1. Get All Reviews

- Route: GET api/review  
- Input: None  
- Returns: List<ReviewDTO>  
- Description: Return all reviews with full park and location info, including park name, rating, and comment.

---

### 2. Get Review by ID

- Route: GET api/review/{id}  
- Input: id (GUID) as route parameter  
- Returns: ReviewDTO  
- Description: Get a single review with park name and location info by its unique ID.

---

### 3. Create a New Review

- Route: POST api/review  
- Input: ReviewRequest in the request body  
- Returns: Created ReviewDTO with park name and IDs  
- Description: Create a new review for a theme park at a specific location.

---

### 4. Delete a Review

- Route: DELETE api/review/{id}  
- Input: id (GUID) as route parameter  
- Returns: 204 No Content if deleted, 404 Not Found if not  
- Description: Delete a review by its unique ID.

---


