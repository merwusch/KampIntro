using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class FourOperatıons
    {
        public void Add(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Result : " + result);
        }

        public void Subtract(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine("Result : " + result);
        }

        public void Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Result : " + result);
        }

        public void Divide(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine("Result : " + result);
        }
    }
}
