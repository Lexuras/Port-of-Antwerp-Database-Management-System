# Port-of-Antwerp-Database-Management-System
A C# application, built with object-oriented programming principles, integrated with a MySQL database to manage and display critical operations and logistics data for the Port of Antwerp.

This project is a comprehensive database management system designed to handle various operations for the Port of Antwerp. Initially developed as a high school programming final project, the application integrates a MySQL database and a C# interface to showcase essential port activities. Key features include:

Displaying shipping routes and schedules.
Tracking arriving and departing vessels.
Managing cargo information and logistics.
Providing an intuitive interface for users to interact with the database.

---

## Getting Started

### Prerequisites
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/)
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
- [MySQL Server 8.x](https://dev.mysql.com/downloads/mysql/)

### 1. Set up the database

Import the database schema and sample data into MySQL:

```bash
mysql -u root -p < database/LXZAM_HAVEN30.04.sql
```

Or open `database/LXZAM_HAVEN30.04.sql` in MySQL Workbench and execute it.

### 2. Configure the connection string

Open `LXZAM_Haven-Domain/Persistence/Persistence.cs` and update the connection string in the constructor with your MySQL credentials:

```csharp
_connectionstring = "server=localhost;database=LXZAM_Haven;user id=root;password=YOUR_PASSWORD";
```

### 3. Restore NuGet packages & build

1. Open `LXZAM_Haven.sln` in Visual Studio
2. Right-click the solution → **Restore NuGet Packages**
3. Press **Ctrl+Shift+B** to build

### 4. Run

Press **F5** or click **Start** — the main menu will open.

---

## Project Structure

```
LXZAM_Haven.sln              Solution file
LXZAM_Haven-Domain/          Business logic & database access layer
  Business/                  Entity classes (Haven, Schip, Product, Route, ...)
  Persistence/               MySQL data access (Persistence.cs)
LXZAM_Haven-Forms/           WinForms UI
  Hoofdforum/                Main menu form
  Hoofdtabellen/             CRUD forms for ports, vessels, products
  Koppeltabellen/            Junction table forms (routes, cargo per route)
  Resources/                 Images
database/                    MySQL schema and Workbench model
```
