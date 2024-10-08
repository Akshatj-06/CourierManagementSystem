using Entities;
using System.Collections.Generic;

namespace Services
{
    public class CourierAdminService : ICourierAdminService
    {
        private List<Employee> employees = new List<Employee>();

        public int AddCourierStaff(Employee obj)
        {
            employees.Add(obj);
            return obj.EmployeeID; // Assuming EmployeeID is unique and assigned externally
        }
    }
}
