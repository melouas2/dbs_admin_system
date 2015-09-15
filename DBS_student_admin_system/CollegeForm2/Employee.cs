using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeForm2
{
    //Employee class inheriting from Person
    class Employee : Person
    {
        //Employee class inheriting from Person
        public decimal salary { get; set; }

        //Employee constructor inherits four string values from Person
        public Employee(string FName, string LName, string Email, string Phone, decimal wage)
            : base(FName, LName, Phone, Email)
        {

            salary = wage;

        }

        // Returns decimal salary
        public decimal ToDecimal()
        {
            return salary;
        }

        public Employee()
        {
        }



    }
}
