using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int multipllier = int.Parse(Console.ReadLine());
            if (multipllier>10)
            {
                Console.WriteLine($"{theInteger} X {multipllier} = {theInteger * multipllier}");
            }
            else
            {
             for (int i = multipllier; i <= 10; i++)
             {
                 Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
             }
            }

        }
    }
}
