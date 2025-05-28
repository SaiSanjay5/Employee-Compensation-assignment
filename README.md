
# Employee Compensation Forecasting App (.NET 8.0 - Windows Forms)

This is a traditional C# desktop application built using .NET 8.0 and Windows Forms. It is a Proof of Concept (PoC) for forecasting and analyzing employee compensation, built for Spaulding Ridge’s technical assignment.

---

## Features Implemented

- Filter employees by **Role**, **Location**, and **Active/Inactive** status
- View employee data in a **DataGridView**
- Export filtered data to a **CSV file**
- Code is modular with clean separation between UI and database logic

---

## Technologies Used

- .NET 8.0 (Windows Forms)
- C#
- SQL Server (with stored procedures)
- ADO.NET
- `Microsoft.Data.SqlClient` for database access

---

## Project Structure

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


## Deliverables

- Fully working desktop app
- SQL scripts for database setup
- Filtering, exporting, and compensation simulation features

