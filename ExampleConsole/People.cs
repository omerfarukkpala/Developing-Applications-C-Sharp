using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsole
{
    internal class People
    {
        //public void personList()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i + ". Person");
        //    }
        //}

        //public void personList(string name)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i + name);
        //    }
        //}

        //public void personList(string fullName)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(fullName);
        //    }
        //}

        public void personList(string firstName, string lastName, 
        int age, string occupation)
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(occupation);
        }


    }
}
