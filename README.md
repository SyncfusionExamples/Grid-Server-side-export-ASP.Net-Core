# ASP.NET Core Grid - Server-side Export

## Repository Description
This repository demonstrates server-side Excel and PDF export functionality for Syncfusion EJ2 Grid using ASP.NET Core. It provides a practical example of exporting grid data to multiple formats with toolbar integration.

## Overview
This sample showcases how to implement server-side export capabilities for Syncfusion EJ2 Grid components in an ASP.NET Core application. Users can export grid data to Excel and PDF formats using toolbar buttons with server-side processing.

## Features
- **Excel Export**: Export grid data to Excel format on the server
- **PDF Export**: Export grid data to PDF format on the server
- **Toolbar Integration**: Export buttons integrated in grid toolbar
- **Sample Data**: Pre-populated order dataset for demonstration
- **Server-side Processing**: Export operations handled by ASP.NET Core backend
- **Column Formatting**: Proper formatting for dates, currency, and numeric values

## Prerequisites
- .NET 6.0 or higher
- Visual Studio or VS Code
- ASP.NET Core SDK
- Syncfusion.EJ2
- Syncfusion.EJ2.GridExport
- C# knowledge

## Installation
1. Clone the repository
   ```
   git clone https://github.com/SyncfusionExamples/Grid-Server-side-export-ASP.Net-Core.git
   ```
3. Navigate to the project directory
   ```
   cd Grid-Server-side-export-ASP.Net-Core
   ```
5. Run `dotnet restore` to install dependencies
6. Execute `dotnet build` to build the project
7. Run `dotnet run` to start the application

## Usage
The grid displays sample order data with two export options:
1. Click the **Excel Export** button in the grid toolbar to download data as an Excel file
2. Click the **PDF Export** button in the grid toolbar to download data as a PDF file
3. The server processes the export request and returns the formatted file

## Configuration
- **Data Source**: OrdersDetails model with sample order information
- **Export Formats**: Excel (.xlsx) and PDF (.pdf)
- **Grid Columns**: OrderID, CustomerID, OrderDate, and Freight
- **Endpoints**: `/Home/ExcelExport` and `/Home/PdfExport`

## Documentation
For more information about Syncfusion Grid export capabilities, visit the Syncfusion documentation:

https://ej2.syncfusion.com/aspnetcore/documentation/grid/excel-export/exporting-grid-in-server

https://ej2.syncfusion.com/aspnetcore/documentation/grid/pdf-export/exporting-grid-in-server
