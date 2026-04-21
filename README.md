# 📘 BasicDotNetApi

A simple and beginner-friendly **ASP.NET Core Web API** project built using .NET 8. This project demonstrates how to create RESTful APIs with a clean structure, basic CRUD operations, and service-based architecture.

---

## 🚀 Features

- RESTful API using ASP.NET Core  
- Clean folder structure (Controllers, Models, Services)  
- Dependency Injection (DI)  
- In-memory data storage (no database required)  
- Beginner-friendly and easy to understand  
- Easily extendable (Database, Authentication, etc.)  

---

## 🏗️ Project Structure

BasicDotNetApi/
│
├── Controllers/
│   └── ProductsController.cs
│
├── Models/
│   └── Product.cs
│
├── Services/
│   └── ProductService.cs
│
├── Program.cs
├── BasicDotNetApi.csproj
└── README.md

---

## 🧠 Tech Stack

- .NET 8  
- ASP.NET Core Web API  
- C#  
- Dependency Injection  

---

## ⚙️ Getting Started

### 🔧 Prerequisites

- .NET SDK 8.0 or later  
- Visual Studio / VS Code  

---

### 📥 Installation

```
git clone https://github.com/your-username/BasicDotNetApi.git
cd BasicDotNetApi
dotnet restore
```
## Run the Application
```
dotnet run
```
Application will run on:
```
http://localhost:5000

```

## API Endpoints

🔹 Get All Products
GET /api/products
🔹 Get Product by ID
GET /api/products/{id}
🔹 Add New Product
POST /api/products

## Request Body
```
{
  "name": "Tablet",
  "price": 15000
}
```
## Sample Response
```
[
  {
    "id": 1,
    "name": "Laptop",
    "price": 50000
  },
  {
    "id": 2,
    "name": "Phone",
    "price": 20000
  }
]

```
