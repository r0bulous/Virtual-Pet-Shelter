using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee // Class derived from Employee
    {
        string department { get; set; }
    }
}

// NEED TO ADD An override method(How does a Manager do one of the Employee methods differently?).
// DONE  An additional property(for example, Salary, YearsEmployed, or Department).
// NEED TO ADD A method for adopting a pet.
