# Restaurant Management System

## Overview

The Restaurant Management System is designed to manage the complete operational workflow inside a restaurant, starting from the moment a customer is seated until the order is prepared, served, paid for, and archived.

The system improves communication between waiters, kitchen staff, cashiers, and management while minimizing manual work, reducing errors, and providing real-time updates across all departments.

---

# Objectives

- Digitize the restaurant workflow.
- Reduce communication delays between departments.
- Track order status in real time.
- Simplify table and menu management.
- Generate invoices and process payments.
- Monitor inventory automatically (optional feature).
- Provide managers with reports and sales statistics.

---

# User Roles

## Waiter

Responsible for customer service inside the restaurant.

### Permissions

- View restaurant tables.
- Open a table.
- Create a new order.
- Add/Edit/Delete order items.
- Send orders to the kitchen.
- Receive notification when food is ready.
- Mark food as Served.
- Close completed orders.

---

## Chef / Kitchen Staff

Responsible for preparing food.

### Permissions

- View incoming kitchen orders.
- Start preparing an order.
- Change order status:
  - Pending
  - Preparing
  - Ready
- Notify waiters when an order is ready.

---

## Cashier

Responsible for payment processing.

### Permissions

- View completed orders.
- Calculate bill.
- Select payment method.
- Receive payment.
- Print receipt.
- Close financial transaction.

Payment methods may include:

- Cash
- Credit Card
- Visa
- Mobile Wallet

---

## Inventory Manager

Responsible for stock management.

### Permissions

- Manage ingredients.
- Add stock.
- Update quantities.
- View low-stock alerts.
- Review inventory reports.

Optional Feature:

When an item is sold, its ingredients are automatically deducted from inventory.

Example:

Selling one Burger decreases:

- Bread ×1
- Beef Patty ×1
- Cheese ×1
- Lettuce ×1

---

## Manager

Has full access to the system.

### Permissions

- Dashboard
- Sales Reports
- Employee Management
- Inventory Reports
- Table Statistics
- Order Analytics
- Menu Management
- User Management

---

# Main Workflow

## Step 1 — Customer Arrives

- Customer enters the restaurant.
- Waiter assigns an available table.
- Table status changes:

Available → Occupied

---

## Step 2 — Create Order

The waiter:

- Opens an order.
- Selects menu items.
- Adds notes if necessary.
- Saves the order.

Order Status:

Pending

---

## Step 3 — Send Order to Kitchen

Immediately after saving:

- Order is sent to the Kitchen Display System (KDS) or Kitchen Tablets.
- Kitchen staff can instantly see the new order.

---

## Step 4 — Kitchen Processing

Chef starts preparing the order.

Order Status:

Pending → Preparing

After cooking is completed:

Preparing → Ready

---

## Step 5 — Waiter Notification

When the order becomes Ready:

- Notification is sent to all available waiters.
- Waiter picks up the food.
- Waiter serves the customer.

Order Status:

Ready → Served

---

## Step 6 — Cashier Processing

At the same time the order is created:

The Cashier receives:

- Order Number
- Table Number
- Ordered Items
- Total Amount

When customer requests payment:

Cashier:

- Selects payment method.
- Confirms payment.
- Prints receipt.

Payment Status:

Pending → Paid

---

## Step 7 — Close Order

After successful payment:

- Order is closed.
- Table becomes available again.

Table Status:

Occupied → Available

Order Status:

Completed

---

# Inventory Workflow (Optional)

Whenever an order is completed:

For each menu item:

- Retrieve its recipe.
- Deduct required ingredients.
- Update stock quantities.
- Generate Low Stock Alert if needed.

Example:

Burger Recipe

- Bread
- Cheese
- Beef
- Tomato
- Lettuce

Selling 5 Burgers automatically deducts all corresponding ingredients.

---

# Table Management

Each table can have one of the following states:

- Available
- Occupied
- Reserved
- Cleaning (Optional)
- Out of Service (Optional)

---

# Order Status Lifecycle

Pending
↓
Preparing
↓
Ready
↓
Served
↓
Completed

---

# Payment Status

Pending
↓
Paid

---

# Notification Flow

Kitchen → Waiters

- Order Ready

Cashier → Waiter (Optional)

- Payment Completed

Inventory → Manager

- Low Stock Alert

Manager → Employees (Optional)

- Announcements

---

# Modules

- Authentication & Authorization
- User Management
- Role Management
- Table Management
- Menu Management
- Category Management
- Order Management
- Kitchen Module
- Cashier Module
- Inventory Module (Optional)
- Reports & Dashboard
- Notifications
- Receipt Printing

---

# Technologies (Example)

Backend

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server

Frontend

- Angular / React / Blazor

Real-Time Communication

- SignalR

Authentication

- JWT
- ASP.NET Identity

Architecture

- Clean Architecture
- Repository Pattern
- Unit of Work
- SOLID Principles

---

# Future Enhancements

- QR Code Menu
- Online Reservations
- Customer Loyalty Program
- Discount & Coupons
- Kitchen Performance Analytics
- Multi-Branch Support
- Mobile Waiter Application
- Kitchen Tablet Application
- Delivery Integration
- Online Ordering
- AI Sales Forecasting

---

# Complete System Flow

Customer Arrives -> Waiter Assigns Table -> Create Order -> Order Sent to Kitchen -> Chef Starts Preparing -> Order Ready -> Waiter Receives Notification -> Food Served -> Cashier Receives Payment -> Receipt Printed -> Inventory Updated (Optional) -> Order Closed -> Table Available Again
