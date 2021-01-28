using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;
using Syncfusion.EJ2.Grids;
using Syncfusion.EJ2.GridExport;

namespace GridExportCore.Controllers
{
    public class HomeController : Controller
    {
        public static List<OrdersDetails> orddata = new List<OrdersDetails>();
        public IActionResult Index()
        {
            if (orddata.Count == 0)
                BindDataSource();
            ViewBag.dataSource = orddata;
            var emp = EmployeeView.GetAllRecords();
            ViewBag.foreign = emp;
            return View();
        }
        public ActionResult ExcelExport([FromForm] string gridModel)
        {
            GridExcelExport exp = new GridExcelExport();
            Grid gridProperty = ConvertGridObject(gridModel);
            return exp.ExcelExport<OrdersDetails>(gridProperty, orddata);
        }

        public ActionResult PdfExport([FromForm] string gridModel)
        {
            GridPdfExport exp = new GridPdfExport();
            Grid gridProperty = ConvertGridObject(gridModel);
            return exp.PdfExport<OrdersDetails>(gridProperty, orddata);
        }
        private Grid ConvertGridObject(string gridProperty)
        {
            Grid GridModel = (Grid)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(Grid));
            GridColumnModel cols = (GridColumnModel)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(GridColumnModel));
            GridModel.Columns = cols.columns;
            return GridModel;
        }
        public class GridColumnModel
        {
            public List<GridColumn> columns { get; set; }
        }
        private void BindDataSource()
        {
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                orddata.Add(new OrdersDetails(code + 2, new EmployeeData("name1", "name2"), "ANATR", i + 0, 3.3 * i, true, new DateTime(1995, 7, 2, 2, 3, 5), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                orddata.Add(new OrdersDetails(code + 3, new EmployeeData("name3", "name4"), "ANTON", i + 1, 4.3 * i, true, new DateTime(2012, 12, 25, 2, 3, 5), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                orddata.Add(new OrdersDetails(code + 4, new EmployeeData("name5", "name6"), "BLONP", i + 2, 5.3 * i, false, new DateTime(2002, 12, 25, 2, 3, 5), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                orddata.Add(new OrdersDetails(code + 5, new EmployeeData("name7", "name8"), "BOLID", i + 3, 6.3 * i, true, new DateTime(1953, 02, 18, 05, 2, 4), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                code += 5;
            }
        }
        public class OrdersDetails
        {
            public OrdersDetails()
            {

            }
            public OrdersDetails(int OrderID, EmployeeData Employee, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
            {
                this.OrderID = OrderID;
                this.Employee = Employee;
                this.CustomerID = CustomerId;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.ShipCity = ShipCity;
                this.Verified = Verified;
                this.OrderDate = OrderDate;
                this.ShipName = ShipName;
                this.ShipCountry = ShipCountry;
                this.ShippedDate = ShippedDate;
                this.ShipAddress = ShipAddress;
            }

            public int? OrderID { get; set; }

            public EmployeeData Employee { get; set; }
            public string CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public double? Freight { get; set; }
            public string ShipCity { get; set; }
            public bool Verified { get; set; }
            public DateTime OrderDate { get; set; }

            public string ShipName { get; set; }

            public string ShipCountry { get; set; }

            public DateTime ShippedDate { get; set; }
            public string ShipAddress { get; set; }
        }

        public class EmployeeData
        {
            public EmployeeData()
            {

            }
            public EmployeeData(string FirstName, string LastName)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;

            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class EmployeeView
        {
            public EmployeeView()
            {

            }
            public EmployeeView(int EmployeeID, string FirstName, string LastName, string Title, DateTime BirthDate, DateTime HireDate, int ReportsTo, string Address, string PostalCode, string Phone, string City, string Country)
            {
                this.EmployeeID = EmployeeID;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Title = Title;
                this.BirthDate = BirthDate;
                this.HireDate = HireDate;
                this.ReportsTo = ReportsTo;
                this.Address = Address;
                this.PostalCode = PostalCode;
                this.Phone = Phone;
                this.City = City;
                this.Country = Country;

            }
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime BirthDate { get; set; }
            public DateTime HireDate { get; set; }

            public int ReportsTo { get; set; }

            public string Address { get; set; }
            public string PostalCode { get; set; }
            public string Phone { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public static List<EmployeeView> GetAllRecords()
            {
                List<EmployeeView> Emp = new List<EmployeeView>();
                Emp.Add(new EmployeeView(1, "Nancy", "Davolio", "Sales Representative", new DateTime(1948, 12, 08), new DateTime(1992, 05, 01), 2, "507 - 20th Ave. E.Apt. 2A ", " 98122", "(206) 555-9857 ", "Seattle ", "USA"));
                Emp.Add(new EmployeeView(2, "Andrew", "Fuller", "Vice President, Sales", new DateTime(1952, 02, 19), new DateTime(1992, 08, 14), 4, "908 W. Capital Way", "98401 ", "(206) 555-9482 ", "Kirkland ", "USA"));
                Emp.Add(new EmployeeView(3, "Janet", "Leverling", "Sales Representative", new DateTime(1963, 08, 30), new DateTime(1992, 04, 01), 3, " 4110 Old Redmond Rd.", "98052 ", "(206) 555-8122", "Redmond ", "USA "));
                Emp.Add(new EmployeeView(4, "Margaret", "Peacock", "Sales Representative", new DateTime(1937, 09, 19), new DateTime(1993, 05, 03), 6, "14 Garrett Hill ", "SW1 8JR ", "(71) 555-4848 ", "London ", "UK "));
                Emp.Add(new EmployeeView(5, "Steven", "Buchanan", "Sales Manager", new DateTime(1955, 03, 04), new DateTime(1993, 10, 17), 8, "Coventry HouseMiner Rd. ", "EC2 7JR ", " (206) 555-8122", "Tacoma ", " USA"));
                Emp.Add(new EmployeeView(6, "Michael", "Suyama", "Sales Representative", new DateTime(1963, 07, 02), new DateTime(1993, 10, 17), 2, " 7 Houndstooth Rd.", " WG2 7LT", "(71) 555-4444 ", "London ", "UK "));
                Emp.Add(new EmployeeView(7, "Robert", "King", "Sales Representative", new DateTime(1960, 05, 29), new DateTime(1994, 01, 02), 7, "Edgeham HollowWinchester Way ", "RG1 9SP ", "(71) 555-5598 ", "London ", " UK"));
                Emp.Add(new EmployeeView(8, "Laura", "Callahan", "Inside Sales Coordinator", new DateTime(1958, 01, 09), new DateTime(1994, 03, 05), 9, "722 Moss Bay Blvd. ", "98033 ", " (206) 555-3412", "Seattle ", "USA "));
                Emp.Add(new EmployeeView(9, "Anne", "Dodsworth", "Sales Representative", new DateTime(1966, 01, 27), new DateTime(1994, 11, 15), 5, "4726 - 11th Ave. N.E. ", "98105 ", "(71) 555-5598 ", " London", "UK "));
                return Emp;
            }
        }
    }

}
