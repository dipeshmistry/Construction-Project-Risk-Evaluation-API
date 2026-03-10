# Construction Project Risk Evaluation API

A **.NET Web API** that evaluates the health of a construction project based on its **progress and budget utilization**.

The API calculates completion metrics and determines the project risk status using predefined business rules.

---

# 📌 Features

- REST API built with **ASP.NET Core**
- **Controller + Service architecture**
- **Dependency Injection**
- **Async/Await implementation**
- **Input validation using Data Annotations**
- **Swagger API documentation**
- **Global exception handling middleware**
- **Simulated external service integration**
- Clean and maintainable project structure

---

# 🏗 Project Structure

```
ConstructionApi
│
├── Controllers
│     └── ProjectProgressController.cs
│
├── Models
│     ├── ProjectProgressRequest.cs
│     └── ProjectProgressResponse.cs
│
├── Services
│     ├── IProjectEvaluationService.cs
│     ├── ProjectEvaluationService.cs
│     ├── IExternalRiskService.cs
│     └── ExternalRiskService.cs
│
├── Middleware
│     └── GlobalExceptionMiddleware.cs
│
├── Program.cs
└── README.md
```

---

# 🚀 API Endpoint

## Evaluate Project Progress

**POST**

```
/api/project/progress
```

### Request Body

```json
{
  "projectName": "Skyline Towers",
  "siteEngineerName": "Raj Patel",
  "totalFloorsPlanned": 20,
  "floorsCompleted": 9,
  "totalBudget": 5000000,
  "amountSpent": 3000000
}
```

---

# 📊 Business Logic

### 1️⃣ Completion Percentage

```
Completion % = (Floors Completed / Total Floors Planned) × 100
```

### 2️⃣ Budget Utilization

```
Budget Utilization % = (Amount Spent / Total Budget) × 100
```

---

# 📈 Project Health Status Logic

| Condition | Status |
|--------|--------|
| Completion ≥ Budget Utilization | On Track |
| Budget Utilization exceeds Completion by >15% | Over Budget Risk |
| Completion <30% AND Budget Utilization >50% | Critical Delay |
| Otherwise | Needs Monitoring |

---

# 📤 Example Response

```json
{
  "completionPercentage": 45,
  "budgetUtilizationPercentage": 60,
  "projectHealthStatus": "Over Budget Risk",
  "evaluationDate": "2026-03-10T13:30:00Z"
}
```

---

# ⚙️ Validation Rules

The API validates the following:

- All fields are required
- Total Floors Planned must be **greater than 0**
- Floors Completed cannot exceed **Total Floors Planned**
- Total Budget must be **greater than 0**
- Amount Spent cannot exceed **Total Budget**
- Numeric values must be **positive**

If validation fails, the API returns:

```
HTTP 400 - Bad Request
```

---

# 🧠 Technical Highlights

The project demonstrates:

- Clean **separation of concerns**
- **Dependency Injection**
- **Async external service simulation**
- **Global exception handling**
- **Structured JSON responses**
- **RESTful API design**
- **Swagger documentation**

---

# 🧪 Running the Project

### 1️⃣ Clone the repository

```
git clone <repository-url>
```

---

### 2️⃣ Navigate to project

```
cd ConstructionApi
```

---

### 3️⃣ Restore dependencies

```
dotnet restore
```

---

### 4️⃣ Run the API

```
dotnet run
```

---

# 📚 Swagger Documentation

After running the project open:

```
https://localhost:5001/swagger
```

Swagger provides an interactive UI to test the API.

---

# 🔧 Technology Stack

- .NET 9
- ASP.NET Core Web API
- Swashbuckle Swagger
- Dependency Injection
- Middleware

---

# 👨‍💻 Author

Dipesh Mistry  
Software Engineer
