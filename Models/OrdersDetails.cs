using System;

namespace GridExportCore.Models
{
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
}
