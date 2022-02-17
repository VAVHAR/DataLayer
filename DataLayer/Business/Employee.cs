using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataAccess;


namespace DataLayer.Business
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void SaveEmployee(Employee emp)
        {
            // after data layer
        }

        public Employee SearchEmployee(int id)
        {
            return new Employee();
        }
    }
}
