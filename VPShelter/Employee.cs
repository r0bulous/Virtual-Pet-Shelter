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

        public void ClockIn() // Save for abstract method
        {

        }

        public void ShowID() // Save for abstract method
        {

        }

    }

    }

// The Employee base class MUST include:
// DONE [ ] One property(perhaps EmployeeID) 
// NEED TO FINISH [ ] Two abstract methods(for example, ClockIn() or ShowID()).
