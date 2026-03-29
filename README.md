# Start an API Project  (Using vscode)

## 1. Create API project 
open the intergrated terminal
```bash
dotnet new web -0 ApiName
```

## 2. Certificate HTTP 
Trust your machine runs http method running .net api

```bash
dotnet dev-certs https --trust
```

## 3. Install Microsoft.Entity.Core ORM
.NET orm to connect in your project
```bash
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.7 
dotnet add package Microsoft.EntityFrameworkCore.Core --version 7.0.7 
dotnet add package Pomelo.EntityFrameworkCore.Mysql --version 7.0.0 
```

## 4. Set global databse migrations
follow this steps

```bash
dotnet tool install --global dotnet-ef --version 10.*
```
note: Check your dotnet version using
```bash
dotnet --version
```

## 5. Migrations
Just two command lines

```bash
donet ef migrations add Inicial
dotnet ef database update
```
obs: "Incial" Is my migration name and you be able to change it

