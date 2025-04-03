# 🧑‍💻 Intern Assignment: Park & Review API Feature Tasks

This document outlines the step-by-step tasks for building out the backend API functionality for parks and reviews. You’ll work in **two controllers**: `ParkController` and `ReviewController`.

---

## ✅ Stage 1: `ParkController` — Parks and Locations Only

All of these endpoints should go inside `ParkController.cs`.

### 1. Get All Parks
- **Route:** `GET api/park/parks`
- **DTO Returned:** `ParkDTO`
- **Description:** Return all parks, each with:
  - Park name
  - Location name
  - Park ID
  - Park-location ID
- **Details:** Use a combination of `ThemePark`, `Location`, and `ThemePark_Location`.

---

### 2. Get All Locations
- **Route:** `GET api/park/locations`
- **DTO Returned:** None (you can return the `Location` entity directly)
- **Description:** Return all location records from the database.

---

### 3. Get Parks by Location
- **Route:** `GET api/park/parks/location/{locationId}`
- **DTO Returned:** `ParkDTO`
- **Description:** Return all parks that are located in the specified location ID.
- **Input** `locationId` Endpoint should take in a location id.

---

### 4. Search Parks by Name
- **Route:** `GET api/park/GetParksBySearch?searchTerm=YourSearchTerm`
- **DTO Returned:** `ParkDTO`
- **Description:** Search parks by name (case-insensitive), and return matches with location info.
- **Input** Should take in a string of the park name.

---
