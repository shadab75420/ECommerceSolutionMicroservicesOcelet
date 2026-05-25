# ECommerce Microservices with Ocelot API Gateway

## Project Overview

This project demonstrates Microservices Architecture using ASP.NET Core Web API and Ocelot API Gateway.

The solution contains:

- Product Service
- Order Service
- Ocelot API Gateway

The gateway acts as a single entry point for all client requests and forwards them to the correct microservice.

---

## Project Structure

```text
ECommerceSolution
│
├── ProductService
│
├── OrderService
│
├── APIGateway
│
└── ECommerceSolution.slnx
```

---

## Technologies Used

- ASP.NET Core Web API
- .NET 8
- Ocelot API Gateway
- Swagger / OpenAPI
- Visual Studio 2022

---

## Features

- Independent Microservices
- API Gateway Routing
- Swagger Integration
- Multiple Startup Projects
- Centralized API Access
- Separate API Endpoints
- Ocelot Routing Configuration

---

## Microservices Architecture

```text
Client
   ↓
Ocelot API Gateway
   ↓
-------------------------
| Product Service       |
| Order Service         |
-------------------------
```

---

## Product Service

### Base URL

```text
https://localhost:5001
```

### API Endpoint

```text
GET /api/products
```

### Sample Response

```json
[
  "Laptop",
  "Mobile",
  "Keyboard"
]
```

### Swagger URL

```text
https://localhost:5001/swagger
```

---

## Order Service

### Base URL

```text
https://localhost:5002
```

### API Endpoint

```text
GET /api/orders
```

### Sample Response

```json
[
  "Order 101",
  "Order 102",
  "Order 103"
]
```

### Swagger URL

```text
https://localhost:5002/swagger
```

---

## Ocelot API Gateway

### Base URL

```text
https://localhost:7000
```

### Gateway Endpoints

#### Product API via Gateway

```text
GET /gateway/products
```

#### Order API via Gateway

```text
GET /gateway/orders
```

### Sample Gateway URLs

```text
https://localhost:7000/gateway/products
```

```text
https://localhost:7000/gateway/orders
```

---

## API Gateway Benefits

- Single Entry Point
- Centralized Routing
- Easier Frontend Integration
- Better Security
- Service Abstraction
- Simplified Client Communication
- Easier Monitoring and Logging
- Scalable Architecture

---

## How to Run the Project

### Step 1

Open solution in Visual Studio.

### Step 2

Configure Multiple Startup Projects.

Set these projects to Start:

- ProductService
- OrderService
- APIGateway

### Step 3

Press:

```text
F5
```

### Step 4

Test APIs using Swagger or Gateway URLs.

---

## Direct Service URLs

### Product Service

```text
https://localhost:5001/api/products
```

### Order Service

```text
https://localhost:5002/api/orders
```

---

## Gateway URLs

### Product API

```text
https://localhost:7000/gateway/products
```

### Order API

```text
https://localhost:7000/gateway/orders
```

---

## Conclusion

This project demonstrates how Microservices communicate through an Ocelot API Gateway in ASP.NET Core.

The architecture provides better scalability, maintainability, centralized routing, and simplified client communication.
