using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        string EmployeeID { get; set; } // field/property for employee ID

        // Abstract methods as required by project description
        public abstract void ClockIn();
        public abstract void CheckID();
    }
}