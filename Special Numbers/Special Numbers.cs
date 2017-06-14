using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                if (i<10)
                {
                    if (i == 5 || i == 7 || i == 11) //sum of digits is 5, 7 or 11
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }
                else
                {
                    int ten = i / 10;
                    int tenth = i % 10;
                    sum = ten + tenth;
                    if (sum == 5 || sum == 7 || sum == 11) //sum of digits is 5, 7 or 11
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }
            }
        }
    }
}
