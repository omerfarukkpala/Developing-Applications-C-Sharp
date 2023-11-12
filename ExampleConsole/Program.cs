using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Console.Write("World");

            //string word;
            //word = "October 6th";
            //Console.WriteLine(word);

            //int number = 5;
            //Console.Write(number);

            //Message msg = new Message();
            //msg.text();

            //Persons person = new Persons();
            //person.personList("hello");

            //Persons person = new Persons();
            //person.personList("Ömer Faruk PALA");
            //person.personList("SAMET CAN");
            //string name;
            //Console.Write("Enter a name: ");
            //name = Console.ReadLine();
            //person.personList(name);

            //Persons person = new Persons();
            //string firstName, lastName, occupation;
            //int age;
            //Console.Write("Enter your first name: ");
            //firstName = Console.ReadLine();
            //Console.Write("Enter your last name: ");
            //lastName = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter your occupation: ");
            //occupation = Console.ReadLine();
            //person.personList(firstName, lastName, age, occupation);

            //Operation operation = new Operation();
            //operation.sum(7, 6);
            //operation.sum(4, 5);

            //Console.WriteLine("\n\n\n");
            //operation.square(6);

            //Operation operation = new Operation();
            //Console.Write("Enter the first number: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sum: " + operation.Addition(number1, number2));
            //Console.WriteLine("Difference: " + operation.Subtraction(number1, number2));
            //Console.WriteLine("Product: " + operation.Multiplication(number1, number2));
            //Console.WriteLine("Division: " + operation.Division(number1, number2));

            //string info;
            //Console.Write("Name - Club: ");
            //info = Console.ReadLine();
            //Student student = new Student(info);

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your last name: ");
            //string lastName = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter your occupation: ");
            //string occupation = Console.ReadLine();
            //Student student = new Student(name, lastName, age, occupation);
            Identity personInfo = new Identity();
            personInfo.FirstName = "Ömer Faruk";
            personInfo.LastName = "Pala";
            personInfo.Hometown = "Bursa";
            personInfo.Age = 99;
            personInfo.Gender = 'M';

            Console.WriteLine(personInfo.FirstName);
            Console.WriteLine(personInfo.LastName);
            Console.WriteLine(personInfo.Hometown);
            Console.WriteLine(personInfo.Age);
            Console.WriteLine(personInfo.Gender);

            Console.Read();

        }
    }
}
