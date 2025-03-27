# Hospital Management System in ASP.NET Framework🏥

## Project Overview

This is a comprehensive Hospital Management System built using ASP.NET Core MVC with MySQL as the database engine. The application provides functionality for managing patient and doctor information with CRUD operations.

## 🛠️ Technology Stack

- **Framework**: .NET SDK (ASP.NET Core MVC)
- **Database**: MySQL
- **ORM**: Entity Framework Core
- **IDE**: Visual Studio / VS Code

## 📋 Prerequisites

- .NET SDK (compatible version)
- MySQL Server
- Visual Studio or VS Code

## 🚀 Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/yourusername/HospitalManagementSystem.git
cd HospitalManagementSystem
```

### 2. Install Required Packages
```bash
# MySQL Integration
dotnet add package Pomelo.EntityFrameworkCore.MySql

# EF Core Tools (Global Installation)
dotnet tool install --global dotnet-ef
```

### 3. Configure Database Connection
Update `appsettings.json` with your MySQL connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=hospitaldb;user=root;password=yourpassword;"
}
```

### 4. Create Database Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 📂 Project Structure
```
HospitalManagementSystem/
│
├── Controllers/
│   ├── PatientController.cs
│   └── DoctorController.cs
│
├── Models/
│   ├── Patient.cs
│   ├── Doctor.cs
│   └── Appointment.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Views/
│   ├── Patient/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Details.cshtml
│   └── Doctor/
│       └── ...
│
├── appsettings.json
├── Startup.cs / Program.cs
└── HospitalManagementSystem.csproj
```

## 🔑 Key Features

- 🩺 Doctor Management
  - View list of doctors
  - Create new doctor profiles
  - Edit doctor information

- 👥 Patient Management
  - View patient list
  - Create new patient records
  - Edit patient information
  - Comprehensive patient details

## 📝 Model Descriptions

### Patient Model
- ID
- Name
- Age
- Gender
- Phone Number
- Email
- Address

### Doctor Model
- ID
- Name
- Specialty
- Phone Number
- Email

## 🚧 Development Notes

- Always run `dotnet ef migrations add` after model changes
- Use lowercase table names in MySQL
- Leverage Razor pages' tag helpers for model binding

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

## 📞 Contact

Steve Ongera - steveongera001@gmail.com

Project Link: [https://github.com/steveongera/HospitalManagementSystem](https://github.com/dteveongera/HospitalManagementSystem)