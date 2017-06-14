using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int oddNumber = -1;
            int sum = 0;

            for (int i = 1; i <= number; i ++)
            {
                oddNumber = oddNumber + 2;
                Console.WriteLine(oddNumber);

                sum = sum + oddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
