# 🏥 Hospital Management System

> A comprehensive desktop-based Hospital Management System built with **C# .NET** and **SQL Server** — designed to streamline patient management, doctor scheduling, appointments, billing, and hospital administration in one unified platform.

---

## 🌟 Features

### 👤 Patient Management
- Register new patients with full medical history
- Search, update, and view patient records
- Track admission, discharge, and ward assignments

### 👨‍⚕️ Doctor & Staff Management
- Manage doctor profiles, specializations, and schedules
- Assign doctors to departments
- Track staff roles and attendance

### 📅 Appointment Scheduling
- Book, reschedule, and cancel appointments
- Real-time availability check for doctors
- Appointment history per patient

### 🏨 Ward & Room Management
- View and assign available beds and wards
- Track room occupancy in real time
- Manage ICU, general, and private ward allocations

### 💊 Pharmacy & Inventory
- Manage medicine stock and inventory
- Issue prescriptions linked to patient records
- Low-stock alerts and restocking management

### 🧪 Laboratory & Reports
- Register lab test requests
- Record and view diagnostic results
- Generate and print lab reports

### 💰 Billing & Payments
- Auto-generate bills based on services, tests, and medicines
- Track pending and completed payments
- Print invoices and receipts

### 🔐 Authentication & Roles
- Role-based access control (Admin, Doctor, Nurse, Receptionist, Pharmacist, Lab Technician)
- Secure login with hashed passwords
- Audit logs for system activity

---

## ⚙️ Prerequisites

| Tool | Version |
|------|---------|
| Visual Studio | 2019 or 2022 |
| .NET Framework | 4.7.2+ or .NET 6/7 |
| SQL Server | 2017, 2019, or 2022 |
| SQL Server Management Studio (SSMS) | 18+ |

---

## 🗄️ Step 1 — Set Up the Database

### 1. Open SQL Server Management Studio (SSMS)

Connect to your SQL Server instance using:
- **Server name:** `localhost` or `.\SQLEXPRESS`
- **Authentication:** Windows Authentication or SQL Server Authentication

### 2. Create the Database

Run the following in a new query window:

```sql
CREATE DATABASE HospitalManagementSystem;
```

### 3. Run the SQL Script

- Navigate to the project folder and find the file **`HospitalManagementSystem.sql`** (or `database/schema.sql`)
- Open it in SSMS
- Make sure **`HospitalManagementSystem`** is selected as the active database
- Click **Execute (F5)** to create all tables, stored procedures, and seed data

---

## 🔧 Step 2 — Configure the Database Connection

Open the project in **Visual Studio** and locate the connection string in:

- `App.config` or `appsettings.json`

Update the connection string to match your SQL Server setup:

**App.config:**
```xml
<connectionStrings>
  <add name="HospitalDB"
       connectionString="Data Source=localhost;Initial Catalog=HospitalManagementSystem;Integrated Security=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

**For SQL Server Authentication (username/password):**
```xml
<connectionStrings>
  <add name="HospitalDB"
       connectionString="Data Source=localhost;Initial Catalog=HospitalManagementSystem;User ID=sa;Password=your_password;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

---

## 🚀 Step 3 — Run the Application

1. Open the solution file **`.sln`** in **Visual Studio**
2. Right-click the solution in **Solution Explorer** → **Restore NuGet Packages**
3. Set the startup project if not already set
4. Press **`F5`** or click **▶ Start** to build and run the application

> ✅ The Hospital Management System should now launch.

---

## 🔐 Default Login Credentials

| Role | Username | Password |
|------|----------|----------|
| Admin | `admin` | `admin123` |
| Doctor | `doctor` | `doctor123` |
| Receptionist | `reception` | `reception123` |

> ⚠️ Change all default passwords immediately after the first login.

---

## 🗃️ Database Schema Overview

| Table | Description |
|-------|-------------|
| `Patients` | Patient personal and medical information |
| `Doctors` | Doctor profiles, specializations, schedules |
| `Staff` | Non-doctor staff and roles |
| `Appointments` | Scheduled appointments between patients and doctors |
| `Admissions` | Patient admission and discharge records |
| `Wards` | Ward and bed management |
| `Prescriptions` | Medicine prescriptions linked to patients |
| `Medicines` | Pharmacy inventory and stock levels |
| `LabTests` | Lab test requests and results |
| `Bills` | Patient billing and payment records |
| `Users` | System user accounts and roles |
| `AuditLogs` | System activity and change tracking |

---

## 🛠️ Built With

| Technology | Purpose |
|------------|---------|
| C# | Primary programming language |
| .NET Framework / .NET 6+ | Application framework |
| Windows Forms / WPF | Desktop UI |
| SQL Server | Relational database |
| ADO.NET / Entity Framework | Database connectivity and ORM |
| SSMS | Database management and scripting |
| Crystal Reports / RDLC | Report and invoice generation |

---

## 👥 User Roles & Permissions

| Role | Permissions |
|------|-------------|
| **Admin** | Full access — manage users, settings, reports, all modules |
| **Doctor** | View/manage own appointments, write prescriptions, view patient records |
| **Nurse** | View patient admissions, update vitals, manage ward assignments |
| **Receptionist** | Register patients, book appointments, generate bills |
| **Pharmacist** | Manage medicine inventory, issue prescriptions |
| **Lab Technician** | Register lab tests, enter and view test results |

---

## 🛠️ Troubleshooting

**Cannot connect to SQL Server?**
- Ensure SQL Server service is running: open **Services** → check `SQL Server (MSSQLSERVER)` or `SQL Server (SQLEXPRESS)`
- Verify the server name in the connection string matches your instance (e.g. `localhost`, `.\SQLEXPRESS`, `DESKTOP-XXXX\SQLEXPRESS`)
- Enable **TCP/IP** in SQL Server Configuration Manager

**NuGet packages not restoring?**
- Go to **Tools → NuGet Package Manager → Manage NuGet Packages for Solution**
- Click **Restore**
- Or run in Package Manager Console:
  ```
  Update-Package -reinstall
  ```

**Build errors after opening the solution?**
- Ensure the correct **.NET version** is installed for the target framework
- Check **Project Properties → Application → Target Framework** and install if missing via Visual Studio Installer

**Login not working?**
- Confirm the `Users` table has been seeded by the SQL script
- Re-run the seed section of `HospitalManagementSystem.sql` if the table is empty

**Reports not generating?**
- Ensure **Crystal Reports** or **RDLC Report Viewer** runtime is installed
- Download Crystal Reports runtime from SAP's official website if missing
