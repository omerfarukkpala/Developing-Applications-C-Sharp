using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsole
{
    internal class Operation
    {
        public int Sum(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Result: " + result);
            return result;
        }

        public int Square(int value)
        {
            int result = value * value;
            Console.WriteLine("Result: " + result);
            return result;
        }

        public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public double Division(double number1, double number2)
        {
            return number1 / number2;
        }
``

    }
}
