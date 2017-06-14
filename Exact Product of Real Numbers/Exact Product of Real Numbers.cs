using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal result = 1;
            for (int i = 0; i < numbers; i++)
            {
                decimal product = decimal.Parse(Console.ReadLine());
                result = result * product;

            }
            Console.WriteLine($"{result}");
        }
    }
}
