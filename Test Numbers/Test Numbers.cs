using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int moves = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    moves++;
                    sum = i * j * 3 + sum;

                    if (sum >= controlNumber)
                    {
                        break;
                    }
                    
                }
                if (sum >= controlNumber)
                {
                    break;
                }

            }

            if (sum < controlNumber)
            {
                Console.WriteLine($"{moves} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"{moves} combinations");
                Console.WriteLine($"Sum: {sum} >= {controlNumber}");
            }
        }
    }
}
