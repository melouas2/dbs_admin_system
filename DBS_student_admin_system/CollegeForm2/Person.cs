using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeForm2
{
    class Person
    {
        /*get set accessors initialised for public strings
         in order for other classes to inherit them*/
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Person constructor used to store string values
        public Person(string FName, string LName, string Phone, string Email)
        {


        }

        //Returns stored string values when requested
        public override string ToString()
        {
            return FName + ", " + LName + ", " + Phone + ", " + Email;
        }

        //Constructor that takes 0 arguments
        public Person()
        {


        }
    }
}
