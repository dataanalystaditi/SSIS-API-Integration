# SSIS API Integration (Portfolio Project)

## 📌 Overview
This project demonstrates how to integrate **SSIS (SQL Server Integration Services)** with a **.NET Core Web API**.  

The solution has two key parts:
1. **SSIS Package** – ETL pipeline to process customer data (dummy configs included, no sensitive data).  
2. **Dummy Customer API** – A lightweight API built in ASP.NET Core with **in-memory data**.  
   - Provides `GET` and `POST` endpoints for customer records.  
   - Fully documented with **Swagger UI**.  
   - Runs locally without requiring a database.  

👉 This project is designed for **portfolio showcase** purposes. All real credentials have been replaced with safe dummy values.

---

## 🚀 Run the Dummy API

### Requirements
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

### Steps
1. Clone this repository:
   ```bash
   git clone https://github.com/YOUR_USERNAME/SSIS_API_Integration.git

2. Navigate to the API project:
   ```bash
   cd SSIS_API_Integration/API/DummyCustomerApi

3. Run the API:
   ```bash
   dotnet run --urls "http://localhost:5055"

4. Open in your browser:
   Swagger UI → http://localhost:5055/swagger
   GET Customers → http://localhost:5055/api/samplecustomers

---
## 🛠️ Tech Stack
ETL: SSIS (SQL Server Integration Services)
Backend: ASP.NET Core Web API
Language: C#
Database: In-memory store (no real DB required)
Documentation/UI: Swagger

---
## 📷 Screenshots
### SSIS Part (shows ETL flow)
1. Control Flow 
<img width="1919" height="1130" alt="ssis_control_flow" src="https://github.com/user-attachments/assets/90c80070-41f5-4c13-a68b-5790c4cee8c2" />

2. Data Flow
<img width="1915" height="1084" alt="ssis_data_flow" src="https://github.com/user-attachments/assets/db62476a-33c4-45cb-854c-5dc9e4b690de" />

### API Part (shows endpoints working)
3. Swagger UI Overview
<img width="1891" height="1073" alt="api_swagger" src="https://github.com/user-attachments/assets/356f2655-7b0b-4691-aa9b-504cc8a7f977" />

4. GET Customers (Response)
<img width="1919" height="1063" alt="api_response" src="https://github.com/user-attachments/assets/b9b5dbfa-85f2-4458-80c4-4af164b7af91" />

5. POST Request (Before Execute)
<img width="1887" height="1000" alt="api_post" src="https://github.com/user-attachments/assets/7f55010c-9060-43b6-8234-6bc83bbb1aa7" />

6. POST Response (After Execute)
<img width="1886" height="1029" alt="api_post_response" src="https://github.com/user-attachments/assets/ee25b40e-3666-4131-a22b-99c5003a2adf" />

---
## 🔒 Security Note
Files like appsettings.json and SSIS config files (.dtsConfig) contain dummy values only.
Real database credentials, API keys, or sensitive information are not included.

---
## ✨ Author
👩‍💻 Aditi Agarwal
GitHub: [dataanalystaditi](https://github.com/dataanalystaditi)
LinkedIn: [Aditi Agarwal](https://www.linkedin.com/in/aditiagarwal9/)
