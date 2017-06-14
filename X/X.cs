using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            {
                for (int j = 0; j < n/2; j++)
                {
                    Console.Write(new string(' ',j));
                    Console.Write("x");
                    Console.Write(new string(' ', ((n/2-j)-1)));
                    Console.Write(" ");
                    Console.Write(new string(' ', ((n / 2 - j)-1)));
                    Console.Write("x");
                    Console.WriteLine();

                }
                Console.Write(new string(' ', ((n / 2) )));
                Console.WriteLine("x");

                for (int j = n/2 -1; j >=0; j--)
                {
                    Console.Write(new string(' ', j));
                    Console.Write("x");
                    Console.Write(new string(' ', ((n / 2 - j) - 1)));
                    Console.Write(" ");
                    Console.Write(new string(' ', ((n / 2 - j) - 1)));
                    Console.Write("x");
                    Console.WriteLine();

                }

            }
        }
    }
}
