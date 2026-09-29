# RONY International Accounting Software

A full-stack, multi-branch Accounting, Payroll, Inventory and Financial Management System built with ASP.NET Core (.NET), React, and SQL Server, designed to handle end-to-end business operations for multi-company, multi-branch, multi-currency organizations.

## Overview

RONY International Accounting is an enterprise-grade ERP/accounting platform covering 14 modules and 89+ entities, from core company setup and double-entry bookkeeping to payables, receivables, banking, fixed assets, inventory, payroll, budgeting, and financial reporting, with role-based security and full audit trails.

## Tech Stack

Backend: ASP.NET Core Web API (.NET), Entity Framework Core, SQL Server, JWT Authentication, Repository/Service layered architecture

Frontend: React (Vite), React Router, Axios, dynamic config-driven CRUD (generic list/form pages), Excel/PDF export

## Modules

| Module | Highlights |
|---|---|
| Core | Companies, Branches, Countries, Currencies, Exchange Rates, Fiscal Years, Accounting Periods, Number Sequences, System Settings |
| Security | Users, Roles, Permissions, Role-Permission Mapping, User-Company Access, Login History, Audit Logs, Approval Workflows |
| Accounting | Chart of Accounts, Account Groups/Types, Journal Entries and Lines, Recurring Journal Templates |
| Dimensions | Cost Centers, Projects, Departments |
| Tax | Tax Codes, Tax Types, Tax Jurisdictions, Tax Transactions, Withholding Tax |
| Payables | Vendors, Purchase Orders, Purchase Invoices, Vendor Payments, Vendor Credit Notes |
| Receivables | Customers, Sales Orders, Sales Invoices, Customer Receipts, Credit Notes, Bad Debt Write-offs |
| Banking | Bank Accounts, Transactions, Reconciliation, Statement Import, Cheque Register, Petty Cash |
| Fixed Assets | Asset Categories, Fixed Assets, Depreciation Schedules, Disposals, Transfers, Maintenance Logs |
| Budgeting | Budget Versions, Budget Lines, Consolidation Mappings |
| Inventory | Item Categories, Items, Warehouses, Stock Levels/Transactions, Stock Valuation |
| Payroll | Employees, Salary Components, Salary Structures, Payroll Runs and Transactions, Employee Loans |
| Reporting | Financial Statement Templates, Lines and Accounts |
| Notifications | Notifications, Email/SMS Queue |

## Key Features

- Multi-company and multi-branch architecture with context switching
- Double-entry bookkeeping with Journal Entries and auto-numbering
- Role-Based Access Control (RBAC) with granular permissions
- JWT authentication with refresh tokens and login history tracking
- Full audit logging across modules
- Dynamic, config-driven CRUD system (one generic engine powers all 89 entities)
- Dashboard with live financial KPIs and recent activity feed
- Print, PDF, and Excel export on every module
- FK-aware relational data across Payables, Receivables, Inventory, and Payroll

## Getting Started

### Backend
```bash
cd backend/InternationalAccountingSystem.API
copy appsettings.json.example appsettings.json
# update ConnectionStrings and Jwt Key in appsettings.json
dotnet restore
dotnet ef database update
dotnet run
```

### Frontend
```bash
cd frontend/client
npm install
npm run dev
```

## Security Note

`appsettings.json` (containing local connection strings and JWT secrets) is excluded from version control. Use `appsettings.json.example` as a template and supply your own values.

## Author

**Mohammed Jamir Uddin**
Full-Stack Software Developer (.NET Core and React)
jamiruddindowlat1@gmail.com