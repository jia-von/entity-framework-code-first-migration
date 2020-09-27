# C# ASP.NET Core Practice - Code First Migration

The goal of this assignment is meant for me to master ASP.NET Web Application and using Entity Framework(EF)  to generate and update a database. In this assigment I built my own server and database using C#. 

## Summary

I have succesfully created models `ShelfMaterials.cs`, `Shelves.cs`, and `ShelvesContext.cs` (a class that inherites from `DbContext`) from scratch. Throughout this assignment, I used EF migrations to create and update my database without direct manipulation of the database using SQL.

## Installation

```bash
$ git clone https://github.com/jia-von/entity-framework-code-first-migration.git
$ cd entity-framework-code-first-migration-jia-von
$ cd CodeFirstPractice
$ start devenv CodeFirstPractice.sln
```

Use the NuGet Package Manager to install packages:
- Entity Framework [ASP.NET Core Design](https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli).
- Entity Framework [Pomelo Entity Framework Core](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql). 

```bash
PM> dotnet add package Microsoft.EntityFrameworkCore.Design
PM> dotnet add package Pomelo.EntityFrameworkCore.MySQL
```

Initiate initial migration to create a database with data seeded.

```bash
PM> dotnet ef migrations add InitialCreation
PM> dotnet ef update database
```

The result of successful database migration and update is shown below in [PHPMyAdmin](https://www.phpmyadmin.net/) `localhost` with the database name **code_first_practice**.

![DataBase](/References/CodeFirstMigration.PNG)






