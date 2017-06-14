using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            bool isNumberIncorect = ((number > 100) || (number < 1));
            bool isNumberEven = (number % 2 == 0);
            if (isNumberEven)
            {
                while (isNumberEven)
                {
                    Console.WriteLine("Please write an odd number.");
                    number = int.Parse(Console.ReadLine());
                    isNumberEven = (number % 2 == 0);
                }

            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
