# WearableSync API

## 📌 Overview
Smartband Data API is a .NET 9 Web API designed to collect data from wearable devices, starting with the Xiaomi Mi Band 4 using the Zepp Life app to collet data.
 The architecture follows Clean Architecture principles, allowing easy integration of new smartbands in the future.

## 🚀 Features
- Collects health and activity data from smartbands.
- Uses a flexible factory pattern to support multiple wearable devices.
- Follows Clean Architecture for maintainability and scalability.
- Stores data in PostgreSQL using Entity Framework Core.
- RESTful API with Swagger for easy testing.

## 🏗️ Architecture
This project is structured following Clean Architecture principles:

```
📂 Api.Solution
├── 📁 Api.API         # Presentation layer (Controllers, Startup configuration)
├── 📁 Api.Application # Application layer (Interfaces, UseCases)
├── 📁 Api.Domain      # Domain layer (Entities, BaseEntity)
├── 📁 Api.Infrastructure # Infrastructure layer (Database, Services, Factories)
```

## 🛠️ Tech Stack
- **Backend**: .NET 9 (ASP.NET Core Web API)
- **Database**: PostgreSQL with Entity Framework Core
- **Dependency Injection**: Built-in .NET DI
- **API Documentation**: Swagger / OpenAPI / Scalar

## 📦 Installation & Setup
### 🔹 Prerequisites
- .NET 9 SDK installed
- PostgreSQL installed and running

### 🔹 Steps to Run
1. **Clone the repository**
   ```sh
   git clone https://github.com/yourusername/wearablesync-api.git
   cd wearablesync-api
   ```
2. **Configure PostgreSQL Connection String** in `appsettings.json`
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Host=localhost;Database=SmartbandDB;Username=youruser;Password=yourpassword"
   }
   ```
3. **Run Database Migrations**
   ```sh
   dotnet ef database update
   ```
4. **Run the API**
   ```sh
   dotnet run --project MinhaApi.API
   ```


   -- to study and try to use - connect google fit to load data from mi band 4

## 📜 License
This project is open-source and available under the [MIT License](LICENSE).

---
🚀 **Future Integrations**: Fitbit, Garmin, and other smartbands! Stay tuned!

