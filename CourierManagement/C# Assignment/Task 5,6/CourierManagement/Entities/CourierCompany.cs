using System;
using System.Collections.Generic;

namespace Entities
{
    public class CourierCompany
    {
        private string companyName;
        private List<Courier> courierDetails;
        private List<Employee> employeeDetails;
        private List<Location> locationDetails;

        // Default constructor
        public CourierCompany()
        {
            courierDetails = new List<Courier>();
            employeeDetails = new List<Employee>();
            locationDetails = new List<Location>();
        }

        // Parameterized constructor
        public CourierCompany(string companyName)
        {
            this.companyName = companyName;
            courierDetails = new List<Courier>();
            employeeDetails = new List<Employee>();
            locationDetails = new List<Location>();
        }

        // Properties
        public string CompanyName { get => companyName; set => companyName = value; }
        public List<Courier> CourierDetails => courierDetails;

        public void AddCourier(Courier courier)
        {
            courierDetails.Add(courier);
        }

        public List<Employee> EmployeeDetails => employeeDetails;

        public void AddEmployee(Employee employee)
        {
            employeeDetails.Add(employee);
        }

        public List<Location> LocationDetails => locationDetails;

        public void AddLocation(Location location)
        {
            locationDetails.Add(location);
        }

        public override string ToString()
        {
            return $"CourierCompany {{ companyName='{companyName}', courierDetails={courierDetails.Count}, " +
                   $"employeeDetails={employeeDetails.Count}, locationDetails={locationDetails.Count} }}";
        }
    }
}
