using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Employee
    {
        string EmployeeID { get; set; } // field/property for employee ID

        public Employee()
        {
            // Default Constructor
        }

        public Employee(string employeeID) // Constructor for employee ID
        {
            this.EmployeeID = employeeID;
        }



        // Abstract methods as required by project description
        // public abstract void ClockIn();
        // public abstract void CheckID();
    }
}