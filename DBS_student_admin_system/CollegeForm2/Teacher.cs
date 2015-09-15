using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeForm2
{
    //Teacher class inherits from Employee
    class Teacher : Employee
    {
        public string subjectTaught { get; set; }

        //Teacher constructor inherits from Employee
        public Teacher(string FName, string LName, string Email, string Phone, decimal wage, string subject)
            : base(FName, LName, Email, Phone, wage)
        {

            subjectTaught = subject;

        }

        //Returns stored string values when requested
        public override string ToString()
        {
            return "Teacher- " + FName + ", " + LName + ", " + subjectTaught + ", " + salary + " euro, " + Phone + ", " + Email;
        }

        public Teacher()
        {

        }





    }
}
