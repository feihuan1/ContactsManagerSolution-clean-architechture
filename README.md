# Customer Management System (Clean Architecture)

A modular, testable, and maintainable Customer Management System built using Clean Architecture principles with ASP.NET Core. This solution demonstrates best practices in separation of concerns, domain-driven design, and layered architecture.

## Table of Contents

- [Features](#features)
- [Solution Structure](#solution-structure)
- [Getting Started](#getting-started)
- [Running the Application](#running-the-application)
- [Testing](#testing)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

---

## Features

- Manage customers (persons) and countries
- CRUD operations for persons and countries
- Upload countries from Excel
- Role-based authorization
- Exception handling and logging
- Clean separation of concerns (Core, Infrastructure, UI)
- Unit and integration tests

---

## Solution Structure

```
Customer-management-system-CleanArchitechture/
│
├── ContactsManager.Core/           # Domain entities, DTOs, service contracts, business logic
│   ├── Domain/
│   ├── DTO/
│   ├── Enums/
│   ├── Exceptions/
│   ├── Helpers/
│   ├── ServiceContracts/
│   └── Services/
│
├── ContactsManager.Infrastructure/ # Data access, repositories, EF Core DbContext, migrations
│   ├── DbContext/
│   ├── Migrations/
│   └── Repositories/
│
├── ContactsManager.UI/             # ASP.NET Core MVC application (controllers, views, filters, middleware)
│   ├── Controllers/
│   ├── Filters/
│   ├── Middleware/
│   ├── StartupExtensions/
│   ├── Views/
│   └── wwwroot/
│
├── ContactsManager.ServiceTests/   # Unit tests for services
├── ContactsManager.ControllerTests/# Unit tests for controllers
├── ContactsManager.IntegrationTests# Integration tests for end-to-end scenarios
└── ContactsManagerSolution.sln     # Solution file
```

---

## Getting Started

### Prerequisites

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or update connection string for your DB)
- (Optional) Visual Studio 2022+ or VS Code

### Setup

1. **Clone the repository:**
   ```bash
   git clone <repository-url>
   cd Customer-management-system-CleanArchitechture
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Apply database migrations:**
   ```bash
   cd ContactsManager.Infrastructure
   dotnet ef database update
   ```

---

## Running the Application

1. **Start the application:**
   ```bash
   cd ../ContactsManager.UI
   dotnet run
   ```
2. Open your browser and navigate to `https://localhost:5001` (or the port shown in the console).

---

## Testing

- **Unit Tests:**
  ```bash
  dotnet test ContactsManager.ServiceTests
  dotnet test ContactsManager.ControllerTests
  ```

- **Integration Tests:**
  ```bash
  dotnet test ContactsManager.IntegrationTests
  ```

---

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- xUnit (for testing)
- Clean Architecture principles

---

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

---

## License

This project is licensed under the MIT License. 