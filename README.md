
# 💼 Employee Compensation Forecasting App (.NET 8.0 - Windows Forms)

This is a traditional C# desktop application built using .NET 8.0 and Windows Forms. It is a Proof of Concept (PoC) for forecasting and analyzing employee compensation, built for Spaulding Ridge’s technical assignment.

---

## 🚀 Features Implemented

- Filter employees by **Role**, **Location**, and **Active/Inactive** status
- View employee data in a **DataGridView**
- Export filtered data to a **CSV file**
- Code is modular with clean separation between UI and database logic

---

## 🛠️ Technologies Used

- .NET 8.0 (Windows Forms)
- C#
- SQL Server (with stored procedures)
- ADO.NET
- `Microsoft.Data.SqlClient` for database access

---

## 📁 Project Structure

```
EmployeeCompensationApp/
├── MainForm.cs              # UI logic
├── MainForm.Designer.cs    # Control layout
├── DatabaseHelper.cs       # SQL access layer
├── README.md               # Project overview
├── sql_scripts/
│   ├── create_tables.sql
│   ├── insert_sample_data.sql
│   └── stored_procedures.sql
```

---

## 🧪 How to Run

### 1. Setup SQL Server

- Create a database (e.g., `EmployeeDB`)
- Run `create_tables.sql`, `insert_sample_data.sql`, and `stored_procedures.sql`

### 2. Update Connection String

Edit `DatabaseHelper.cs`:
```csharp
private readonly string connectionString = "Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;TrustServerCertificate=True;";
```

### 3. Open and Run the App

- Open `EmployeeCompensationApp.sln` in Visual Studio 2022+
- Build the solution
- Run the application

---

## 📤 Deliverables

- Fully working desktop app
- SQL scripts for database setup
- Filtering, exporting, and compensation simulation features
- Ready-to-submit GitHub repository structure

---

## 📬 Submission

Email your GitHub repo link to:
- pbhatia@spauldingridge.com
- pkumari@spauldingridge.com

**Deadline:** May 18, 2025, 7:00 PM IST
