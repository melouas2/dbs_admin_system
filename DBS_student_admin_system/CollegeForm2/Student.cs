using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeForm2
{
    //Student class inherits from Person
    class Student : Person
    {
        public string StudentID { get; set; }
        public string Status { get; set; }

        //Student constructor inheriting four string values from person
        public Student(string FName, string LName, string Phone, string Email, string ID, string status)
            : base(FName, LName, Phone, Email)
        {

            StudentID = ID;
            Status = status;

        }

        //Returns stored string values when requested
        public override string ToString()
        {
            return "Student- " + StudentID + ", " + Status + ", " + FName + ", " + LName + ", " + Phone + ", " + Email;
        }


        public Student()
        {


        }




    }
}
