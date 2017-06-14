using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNUmber = true;
            int count = 0;
            while (isNUmber)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    count++;
                }
                catch
                {
                    isNUmber = false;
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}
