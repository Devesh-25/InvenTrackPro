# InvenTrack Pro - Advanced E-commerce Inventory Management API

[![Status](https://img.shields.io/badge/Status-Under%20Development-orange.svg)](https://github.com/Devesh-25/InvenTrackPro)
[![.NET Version](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen.svg)](#)

> **🚧 Project Status: Currently Under Active Development**
> 
> This project is being actively developed and is **not yet production-ready**. Features are being implemented in phases as part of a comprehensive learning and portfolio project.

## 📋 Table of Contents

- [About The Project](#about-the-project)
- [Development Progress](#development-progress)
- [Technology Stack](#technology-stack)
- [Architecture](#architecture)
- [Features](#features)
- [Getting Started](#getting-started)
- [API Documentation](#api-documentation)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## 🎯 About The Project

**InvenTrack Pro** is a sophisticated, enterprise-grade E-commerce Inventory Management System built with **.NET 8 Web API**. This project demonstrates advanced software engineering patterns and practices suitable for a mid-level developer portfolio.

The system provides comprehensive inventory tracking, multi-location management, real-time notifications, and advanced order processing capabilities, all built using modern architectural patterns and industry best practices.

### 🎨 Key Highlights

- **Clean Architecture** with proper separation of concerns
- **CQRS Pattern** with MediatR for scalable command/query operations  
- **JWT Authentication** with refresh token rotation
- **Role-based Authorization** (Admin, Manager, Customer)
- **Real-time Communication** using SignalR
- **Comprehensive Audit Logging** for all operations
- **Advanced Caching** with Redis
- **Background Services** for automated processes

## 🚀 Development Progress

### ✅ Completed Phases

#### Phase 1: Foundation Setup *(Completed)*
- [x] Clean Architecture project structure
- [x] Entity Framework Core with SQL Server
- [x] Domain entities with relationships
- [x] Global exception handling
- [x] Structured logging with Serilog
- [x] Swagger/OpenAPI documentation

#### Phase 2: Authentication & Security *(Completed)*
- [x] JWT authentication with refresh tokens
- [x] BCrypt password hashing
- [x] Role-based authorization policies
- [x] Token rotation and revocation
- [x] User management endpoints
- [x] Security middleware implementation

#### Phase 3: Core Business Logic *(Completed)*
- [x] CQRS with MediatR implementation
- [x] FluentValidation pipeline behavior
- [x] AutoMapper configuration
- [x] Product management (CRUD operations)
- [x] Category hierarchy management
- [x] Supplier management system
- [x] Advanced filtering and pagination

### 🔄 Current Phase

#### Phase 4: Advanced Features *(In Progress)*
- [x] Inventory management system
- [ ] Background services for stock alerts
- [ ] Comprehensive audit logging
- [ ] Redis caching implementation
- [ ] Advanced search functionality

### 📅 Upcoming Phases

#### Phase 5: Real-time Features *(Planned)*
- [ ] SignalR for real-time updates
- [ ] Inventory notification system
- [ ] Order status notifications
- [ ] Real-time dashboard updates

#### Phase 6: Testing & Performance *(Planned)*
- [ ] Unit tests for domain logic
- [ ] Integration tests for APIs
- [ ] Performance monitoring
- [ ] API rate limiting
- [ ] Performance optimization

#### Phase 7: Documentation & Deployment *(Planned)*
- [ ] Complete API documentation
- [ ] Docker containerization
- [ ] CI/CD pipeline setup
- [ ] Cloud deployment
- [ ] Production configuration

## 🛠️ Technology Stack

### Backend Framework
- **.NET 8** - Latest LTS version
- **ASP.NET Core Web API** - RESTful API framework
- **Entity Framework Core 8** - ORM for database operations
- **SQL Server** - Primary database

### Architecture & Patterns
- **Clean Architecture** - Dependency inversion and separation of concerns
- **CQRS** with **MediatR** - Command Query Responsibility Segregation
- **Repository Pattern** - Data access abstraction
- **Unit of Work Pattern** - Transaction management

### Security & Authentication
- **JWT (JSON Web Tokens)** - Stateless authentication
- **BCrypt.NET** - Password hashing
- **Role-based Authorization** - Fine-grained access control
- **Refresh Token Rotation** - Enhanced security

### Validation & Mapping
- **FluentValidation** - Declarative validation rules
- **AutoMapper** - Object-to-object mapping
- **Pipeline Behaviors** - Cross-cutting concerns

### Logging & Documentation
- **Serilog** - Structured logging
- **Swagger/OpenAPI** - API documentation
- **JSON Console Logging** - Development debugging

### Planned Integrations
- **SignalR** - Real-time communication
- **Redis** - Caching and session management
- **Docker** - Containerization
- **Azure/AWS** - Cloud deployment

## 🏗️ Architecture

The project follows **Clean Architecture** principles with clear separation of concerns:

```
📁 InvenTrack.API          # Presentation Layer
├── Controllers            # API Controllers
├── Middleware            # Custom middleware
└── Configuration         # Startup configuration

📁 InvenTrack.Application  # Application Layer
├── Features              # CQRS Commands & Queries
│   ├── Products         # Product management
│   ├── Categories       # Category operations
│   ├── Suppliers        # Supplier management
│   └── Orders           # Order processing
├── DTOs                 # Data Transfer Objects
├── Behaviors            # MediatR pipeline behaviors
├── Mappings             # AutoMapper profiles
└── Interfaces           # Service contracts

📁 InvenTrack.Domain       # Domain Layer (Core)
├── Entities             # Domain entities
├── Common               # Base classes
└── Enums               # Domain enumerations

📁 InvenTrack.Infrastructure # Infrastructure Layer
├── Persistence          # Database context & migrations
├── Services            # External service implementations
└── Repositories        # Data access implementations
```

## 🌟 Features

### Currently Implemented

#### 🔐 Authentication & Authorization
- User registration and login
- JWT token generation with claims
- Refresh token mechanism with rotation
- Role-based access control (Admin, Manager, Customer)
- Secure password hashing with BCrypt

#### 📦 Product Management
- CRUD operations with validation
- Advanced filtering and search
- Pagination and sorting
- Category association
- Supplier relationships
- SKU uniqueness validation

#### 🏷️ Category Management  
- Hierarchical category structure
- Parent-child relationships
- Category tree navigation
- Recursive category operations

#### 🏢 Supplier Management
- Supplier information management
- Product-supplier relationships
- Contact information tracking

#### 📊 Advanced Querying
- CQRS pattern implementation
- Complex filtering capabilities
- Pagination with metadata
- Sorting by multiple fields
- Search across multiple properties

### Planned Features

#### 📋 Inventory Management
- Multi-location stock tracking
- Automated reorder alerts
- Stock reservation system
- Inventory transfers between locations

#### 🔔 Real-time Notifications
- Live inventory updates
- Order status changes
- Low stock alerts
- User activity notifications

#### 📈 Reporting & Analytics
- Sales reports
- Inventory reports  
- Audit trail tracking
- Performance metrics

## 🚀 Getting Started

### Prerequisites

- **.NET 8 SDK** or later
- **SQL Server** (LocalDB, Express, or Full)
- **Visual Studio 2022** or **VS Code** with C# extension
- **Git** for version control

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Devesh-25/InvenTrackPro.git
   cd inventrackpro
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Update database connection string**
   
   Edit `appsettings.json` in `InvenTrack.API`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=InvenTrackProDB;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```

4. **Apply database migrations**
   ```bash
   dotnet ef database update --project InvenTrack.Infrastructure --startup-project InvenTrack.API
   ```

5. **Run the application**
   ```bash
   dotnet run --project InvenTrack.API
   ```

6. **Access the API**
   - **Swagger UI**: `https://localhost:7xxx/swagger`
   - **API Base URL**: `https://localhost:7xxx/api`

## 📚 API Documentation

### Authentication Endpoints

```http
POST /api/auth/register     # Register new user
POST /api/auth/login        # User login
POST /api/auth/refresh      # Refresh access token
POST /api/auth/logout       # User logout
GET  /api/auth/me          # Get current user info
```

### Product Management

```http
GET    /api/products              # Get products (with filtering, pagination)
GET    /api/products/{id}         # Get product by ID
POST   /api/products              # Create new product (Manager/Admin)
PUT    /api/products/{id}         # Update product (Manager/Admin)
DELETE /api/products/{id}         # Delete product (Admin only)
```

### Category Management

```http
GET    /api/categories            # Get category hierarchy
GET    /api/categories/{id}       # Get category by ID
POST   /api/categories           # Create category (Admin)
PUT    /api/categories/{id}      # Update category (Admin)
DELETE /api/categories/{id}      # Delete category (Admin)
```

### Sample Requests

#### Register User
```json
POST /api/auth/register
{
  "name": "John Doe",
  "email": "john@example.com",
  "password": "SecurePassword123!",
  "confirmPassword": "SecurePassword123!",
  "role": "Customer"
}
```

#### Create Product
```json
POST /api/products
Authorization: Bearer {jwt_token}
{
  "name": "Wireless Mouse",
  "description": "Ergonomic wireless mouse with USB receiver",
  "price": 29.99,
  "sku": "WM-001",
  "categoryId": 1,
  "supplierId": 1
}
```

## 📁 Project Structure

```
InvenTrackPro/
├── src/
│   ├── InvenTrack.API/
│   │   ├── Controllers/
│   │   ├── Middleware/
│   │   └── Program.cs
│   ├── InvenTrack.Application/
│   │   ├── Features/
│   │   │   ├── Products/
│   │   │   ├── Categories/
│   │   │   ├── Suppliers/
│   │   │   └── Orders/
│   │   ├── DTOs/
│   │   ├── Behaviors/
│   │   ├── Mappings/
│   │   └── Interfaces/
│   ├── InvenTrack.Domain/
│   │   ├── Entities/
│   │   ├── Common/
│   │   └── Enums/
│   └── InvenTrack.Infrastructure/
│       ├── Persistence/
│       ├── Services/
│       └── Repositories/
├── tests/ (Planned)
├── docs/
├── README.md
└── .gitignore
```

## 🤝 Contributing

This is currently a **personal portfolio project** under active development. However, feedback and suggestions are welcome!

### Development Guidelines

1. **Follow Clean Architecture principles**
2. **Use CQRS pattern for new features**
3. **Add validation for all commands**
4. **Include comprehensive logging**
5. **Write unit tests** (when testing phase begins)
6. **Document API endpoints** in Swagger

### Git Workflow

```bash
# Create feature branch
git checkout -b feature/inventory-management

# Make changes and commit
git add .
git commit -m "feat: implement inventory tracking system"

# Push to repository  
git push origin feature/inventory-management
```

## 📝 Development Log

### Recent Updates

**September 2024**
- ✅ Completed Phase 3: Core Business Logic with CQRS
- ✅ Implemented Product Management with full CRUD operations
- ✅ Added Category Hierarchy with recursive relationships
- ✅ Integrated FluentValidation with MediatR pipeline
- 🔄 Started Phase 4: Advanced Features development

**August 2024**
- ✅ Completed JWT Authentication with refresh tokens
- ✅ Implemented Role-based authorization
- ✅ Added BCrypt password hashing
- ✅ Created comprehensive user management system

**July 2024**
- ✅ Established Clean Architecture foundation
- ✅ Set up Entity Framework with SQL Server
- ✅ Implemented global exception handling
- ✅ Configured structured logging with Serilog

## 🚧 Known Issues & Limitations

### Current Limitations
- **No UI Implementation** - API-only project
- **Basic Error Responses** - Will be enhanced in future phases
- **No Caching Yet** - Redis implementation planned
- **Limited Test Coverage** - Comprehensive testing planned
- **No Docker Support** - Containerization in final phase

### Planned Improvements
- Enhanced error handling and responses
- Comprehensive unit and integration tests
- Performance optimization and monitoring
- Docker containerization
- CI/CD pipeline implementation
- Cloud deployment configuration


## 📞 Contact

**Developer**: Devesh Baria
**Email**: devesh.baria.in@gmail.com
**LinkedIn**: [Devesh Baria]([https://linkedin.com/in/yourprofile](https://www.linkedin.com/in/deveshbaria2503/))

## 🙏 Acknowledgments

- **Clean Architecture** concepts by Robert C. Martin
- **.NET Community** for excellent documentation and examples
- **MediatR** library for CQRS implementation
- **FluentValidation** for elegant validation patterns
- **Serilog** for structured logging capabilities

---

**⭐ Star this repository if you find it helpful for learning advanced .NET development patterns!**

---

> **Note**: This project is actively being developed as part of a learning journey and portfolio building. The codebase evolves regularly with new features and improvements. Check the [commit history](../../commits/main) for the latest updates!
