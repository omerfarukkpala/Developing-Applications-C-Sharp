using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsole
{
    internal class Identity
    {

        string firstName;
        string lastName;
        string hometown;
        int age;
        char gender;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value.ToLower(); }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value.ToUpper(); }
        }
        public string Hometown
        {
            get { return hometown; }
            set { hometown = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Identity()
        {
            firstName = "";
            lastName = "";
            age = 18;
            gender = 'F';
            hometown = "Bursa";
        }

    }
}
