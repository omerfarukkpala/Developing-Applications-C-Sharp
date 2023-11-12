using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsole
{
    internal class Student
    {

        //public Student(string info)
        //{
        //    //Console.WriteLine("Name: Ömer Faruk");
        //    //Console.WriteLine("Surname: PALA");
        //    //Console.WriteLine("Occupation: Software Developer");
        //    Console.WriteLine("Status: " + info);
        //}

        public Student(string name, string surname, int age, string occupation)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Occupation: " + occupation);
        }

    }
}
