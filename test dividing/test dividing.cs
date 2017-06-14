using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_dividing
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());
            Console.WriteLine($"%10 - {numbers%10}");
            Console.WriteLine($"/10 - {numbers / 10}");
        }
    }
}
