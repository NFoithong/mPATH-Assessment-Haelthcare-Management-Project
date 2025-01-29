# Setting Up Backend (ASP.NET Core 8) in Visual Studio
## 1. Create the ASP.NET Core 8 Web API Project
1. Open Visual Studio and click on Create a new project.
2. Select ASP.NET Core Web API and click Next.
3. Enter Project Name: HealthcareAPI, choose a location, and click Next.
4. Select .NET 8.0 (Long-Term Support) and click Create.

## 2. Install Required NuGet Packages
Once the project is created, install the following dependencies using the NuGet Package Manager or Package Manager Console.
```Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer
Install-Package Microsoft.Extensions.Configuration.Json
```

## 3. Configure Database & Entity Framework (EF Core)
🔸 3.1. Create appsettings.json for Database Configuration

🔸 3.2. Create AppDbContext.cs
Create a new folder Data and inside it, create AppDbContext.cs

🔸 3.3. Create Models
Inside a new Models folder, create:
✅ Patient Model (Patient.cs)
✅ Recommendation Model (Recommendation.cs)
✅ Role Model (Role.cs):
✅ User Model (User.cs):

## 4. Configure Authentication & Authorization
Modify Program.cs

## 5. Create the Patients API Controller
Inside Controllers, create PatientsController.cs

## 6. Apply Database Migrations
Run these commands in the Package Manager Console
```Add-Migration InitialCreate
Update-Database
```

# Backend API setup includes all the essential features:

✅ Authentication & Authorization using JWT
* Implemented in AuthService.cs
* Uses JWT tokens for secure authentication.
* Role-based access control (Admin, Healthcare Professional).

✅ Patient Management (listing all patients)
* Implemented in PatientsController.cs
* Supports pagination, filtering, and search by name/ID.
* Fetches data from Entity Framework Core (EF Core 8).

✅ Database Setup using Entity Framework Core 8
* Uses Entity Framework Core (EF Core 8) for SQL Server.
* Includes migrations and seeding for initial data.
* Uses ApplicationDbContext.cs to manage database operations.

✅ Service Layer for better separation of concerns
* Service layer handles business logic.
* Repository layer interacts with the database.
* Controller layer handles API requests.