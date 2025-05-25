# RoadTripRentals

RoadTripRentals is a comprehensive desktop application designed to streamline the management of car rental businesses. It provides tools for managing suppliers, customers, rental costs, car models, and payments. The application also includes features for generating reports and maintaining a robust database structure.

---

## Table of Contents

1. [Project Overview](#project-overview)
2. [Features](#features)
3. [Project Structure](#project-structure)
4. [Database Design](#database-design)
5. [Forms and Functionality](#forms-and-functionality)
6. [Reports](#reports)
7. [Getting Started](#getting-started)
8. [Contributing](#contributing)
9. [License](#license)

---

## Project Overview

RoadTripRentals is built using **C#** and **Windows Forms** for the frontend, with a **SQL Server** database backend. It is designed to handle the following key operations:
- Supplier management
- Customer management
- Rental cost tracking
- Car model and details management
- Payment processing
- Report generation

The application ensures data integrity through constraints and validations at both the database and application levels.

---

## Features

- **Supplier Management**: Add, edit, delete, and display supplier details.
- **Customer Management**: Manage customer data and rental history.
- **Rental Costs**: Track and manage rental costs associated with cars.
- **Car Models**: Maintain a catalog of car models and their details.
- **Payments**: Process and manage payment types.
- **Reports**: Generate detailed reports, including customer rentals and car details.
- **Validation**: Enforce data integrity through database constraints and application-level checks.

---


---

## Database Design

The database is structured to ensure data integrity and support the application's functionality. Key tables include:

### `Model`
- **Columns**: `ModelID`, `ModelDesc`, `Make`
- **Constraints**: 
  - Primary Key: `ModelID`
  - Unique: `ModelDesc`

### `RentalCost`
- **Columns**: `RentalCostID`, `RentalCost`
- **Constraints**: 
  - Primary Key: `RentalCostID`
  - Check: `RentalCost > 0`

### `PaymentType`
- **Columns**: `PaymentID`, `PaymentType`
- **Constraints**: 
  - Primary Key: `PaymentID`

### `CarDetails`
- **Columns**: `CarID`, `ModelID`, `RentalCostID`, `FuelType`, `NoSeats`, `Year`
- **Relationships**: 
  - Foreign Key: `ModelID` references `Model`
  - Foreign Key: `RentalCostID` references `RentalCost`

### Constraints
- **Validation**: 
  - `chkTelNo` ensures valid telephone numbers.
  - `chkEmail` ensures valid email addresses.

---

## Forms and Functionality

### `frmMainRentalCost`
- **Purpose**: Manage rental costs.
- **Key Features**:
  - Delete rental costs with validation to ensure no associated cars exist.
  - Confirmation dialogs for deletion.

### `frmMainPayments`
- **Purpose**: Manage payment types.
- **Key Features**:
  - Delete payment types and update the database.
  - Validation to ensure a payment type is selected before deletion.

### `frmMainModel`
- **Purpose**: Manage car models.
- **Key Features**:
  - Delete models with validation to ensure no associated cars exist.
  - Confirmation dialogs for deletion.

### `frmEditCar`
- **Purpose**: Edit car details.
- **Key Features**:
  - Update car details, including fuel type, number of seats, and rental cost.
  - Populate dropdowns for car attributes like color.

---

## Reports

The application includes pre-defined reports for business insights:
- **Customer Rentals**: Overview of customer rental history.
- **Customer List**: Detailed list of customers.
- **Car Details**: Information on cars and their associated models.

Reports are generated using `.rpt` templates and exported as `.pdf` files.

---

## Getting Started

### Prerequisites
- **.NET Framework**: Ensure the required version is installed.
- **SQL Server**: Set up the database using the provided `roadtripMerged.sql` script.
- **Visual Studio**: Use for development and debugging.