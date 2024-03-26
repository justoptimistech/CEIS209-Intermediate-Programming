using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_CourseProject_part2
{
    public class Employee
    {
        // attributes
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;

        // contructors
        public Employee()
        {
            firstName = "N/A";
            lastName = "N/A";
            ssn ="N/A";
            hireDate =new DateTime();
        }
        public Employee(string firstName, string lastName, string ssn, DateTime hireDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
        }

        // behaviors
        public override string ToString()
        {
            return "fristName=" + firstName
                + ", lastName=" + lastName
                + ", ssn=" + ssn
                + ", hireDate=" + hireDate.ToShortDateString();
        }

        public double CalculatePay()
        {
            return 0;

        }

        // properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; } // employee.FirstName = "Tony";
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }


    }
}
