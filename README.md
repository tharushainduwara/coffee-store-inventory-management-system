# ☕ CoffeStore Inventory Management System

> A desktop-based inventory and billing management system for retail stores — built with C# and .NET Framework.

![Platform](https://img.shields.io/badge/Platform-Windows-blue)
![Language](https://img.shields.io/badge/Language-C%23-purple)
![Framework](https://img.shields.io/badge/Framework-.NET-blueviolet)
![Database](https://img.shields.io/badge/Database-SQL%20Server-red)
![IDE](https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen)

---

## 📖 Overview

**CoffeStore** is a Windows desktop application developed to streamline daily retail store operations. It replaces error-prone manual record-keeping (paper ledgers and spreadsheets) with a centralized, automated digital system that handles inventory tracking, sales processing, billing, and reporting.

Developed as a group project for the **MIT 22033 Visual Programming** course at the **South Eastern University of Sri Lanka** (Academic Year 2021/2022), under the supervision of **Prof. S. Sabraz Nawaz**.

---

## 🚩 Problem Statement

Manual inventory and billing systems commonly suffer from:

- **Data Redundancy** — Duplicate records from repeated manual entry
- **Calculation Errors** — Human mistakes in computing totals, discounts, and VAT
- **Stock Mismatches** — No real-time visibility into current inventory levels
- **Security Risks** — No user authentication to protect sensitive sales data

---

## ✅ Features

| Feature | Description |
|---|---|
| 🔐 Secure Login | Credential-based authentication with Role-Based Access Control |
| 👤 User Management | Admin and standard User roles with distinct permissions |
| 📦 Inventory Control | Add, update, and delete product categories and stock levels |
| 🧾 Sales Processing | Record sales with auto-calculated Sub-Total, VAT, Discount, and Grand Total |
| 🛒 Purchase Management | Record stock purchases from dealers with full billing support |
| 👥 Dealer & Customer Management | Unified module to manage both suppliers and customers |
| 📊 Transaction History | View and filter all past sales and purchase records |
| 🖨️ Bill Generation | Generate and print professional receipts at point of sale |

---

## 🏗️ Architecture

The system follows a standard **Client-Server (Desktop Application)** architecture:

```
┌──────────────────────────────────────────────┐
│              Frontend (Client)                │
│         Windows Forms (WinForms) UI           │
└───────────────────┬──────────────────────────┘
                    │
┌───────────────────▼──────────────────────────┐
│              Logic Layer                      │
│    C# Classes — Business Logic, OOP Methods   │
│    Database Connectivity, Calculations        │
└───────────────────┬──────────────────────────┘
                    │
┌───────────────────▼──────────────────────────┐
│              Backend (Server)                 │
│     Microsoft SQL Server Express (RDBMS)      │
└──────────────────────────────────────────────┘
```

---

## 🗄️ Database Design

The system uses a normalized **Relational Database** with the following key tables:

| Table | Description |
|---|---|
| `tbl_users` | Stores user ID, name, username, password, and role (Admin/User) |
| `tbl_categories` | Manages product categories to organize inventory |
| `tbl_products` | Stores product name, rate, quantity, and category link |
| `tbl_dea_cust` | Unified table for Dealers (suppliers) and Customers |
| `tbl_transactions` | Header details of each sale or purchase (type, date, grand total, tax, discount) |
| `tbl_transaction_detail` | Line items — links products to a specific transaction |

---

## 🖥️ Tech Stack

| Component | Technology |
|---|---|
| Programming Language | C# (C Sharp) |
| Framework | .NET Framework |
| IDE | Microsoft Visual Studio 2022 |
| Database Engine | Microsoft SQL Server Express |
| Database Tool | SQL Server Management Studio (SSMS) |
| UI Layer | Windows Forms (WinForms) |

---

## 📐 Interface Overview

The application features a clean dashboard-style UI with the following screens:

- **Login Form** — Authenticates users and assigns role-based access
- **Admin Dashboard** — Full access to Users, Categories, Products, Inventory, and Transactions
- **User Dashboard** — Simplified view focused on Sales, Purchases, and Inventory
- **Sales / Purchase Module** — Select dealer/customer, add products, view live-calculated totals, and save the transaction
- **Dealer & Customer Module** — Add, update, or delete contact records
- **Transactions Dashboard** — View all historical transactions filterable by type

---

## 🎯 Project Objectives

1. Implement a **secure login system** with role-based permissions
2. Enable efficient **inventory management** (add, update, delete products and categories)
3. Maintain a **centralized relational database** for all dealers, customers, and transactions
4. **Automate billing calculations** — Sub-Total, VAT, Discount, and Grand Total
5. **Save all transaction records** to SQL Server for future reference
6. **Generate and print receipts** immediately after completing a sale

---

## 🏆 Achievements

- ✔️ Successful database connectivity — C# app reads and writes to SQL Server seamlessly
- ✔️ Real-time inventory updates — stock decreases automatically upon each sale
- ✔️ Accurate billing logic — Gross Total minus Discount plus VAT computed instantly
- ✔️ Role enforcement — Admin can manage master data; standard Users are restricted to transactions only

---

## 👨‍💻 Team

**Group 50**  
Department of Management and Information Technology  
Faculty of Management and Commerce  
South Eastern University of Sri Lanka

---

## 📄 License

This project was developed for academic purposes as part of the MIT 22033 Visual Programming course. All rights reserved by Group 50, South Eastern University of Sri Lanka.
