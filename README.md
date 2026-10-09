# BethanysPieShop

## Overview

BethanysPieShop is an introductory ASP.NET Core 10 project designed to practice and learn the fundamentals of ASP.NET Core development. This project serves as a hands-on learning experience to understand core concepts and best practices in building modern web applications with .NET.

## Course

This project is being developed while following the **"Getting Started with ASP.NET Core 10"** course by **Gill Cleeren**, which is part of the **ASP.NET Core 10 path** on Pluralsight.

## Implemented concepts

- ASP.NET Core 10 web project using the minimal hosting model (Program.cs).
- ASP.NET Core MVC: Controllers and Views (PieController, Views/Pie/*.cshtml).
- Routing with a default controller route configured (default: Pie/List).
- Passing models to views and model binding (Pie model and @model directive in views).
- Using ViewBag for simple view data (e.g., CurrentCategory).
- In-memory/static data store (Models/StaticPieData) to provide sample data.
- Serving static assets from wwwroot (CSS, images, Bootstrap via libman).
- Environment-specific behavior (Developer Exception Page enabled in Development).
- Entity Framework Core with InMemory provider configured via AddDbContext<AppDbContext> and UseInMemoryDatabase (configured in Program.cs).
- AppDbContext implementing DbSet<Pie> (Models/AppDbContext.cs) and constructor accepting DbContextOptions.
- Data seeding service (Models/DataSeeder.cs) that ensures the database is created and seeds sample pies on application startup via DataSeeder.Initialize(app.Services).
- Controller updated to use constructor injection for AppDbContext to query pies from the in-memory database (Controllers/PieController.cs).
- Basic Razor view usage and Bootstrap-based layout in views.