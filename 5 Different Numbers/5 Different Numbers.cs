using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());


            if (min<max-4)
            {
                Console.WriteLine("No");
            }
            else
            {
               for (int firstNum = min; firstNum <= max; firstNum++)
                    {
                    for (int secondNum = min; secondNum <= max; secondNum++)
                    {
                        for (int thirdhNum = min; thirdhNum <= max; thirdhNum++)
                        {
                            for (int fourthNum = min; fourthNum <= max; fourthNum++)
                            {
                                for (int fifthNum = min; fifthNum <= max; fifthNum++)
                                {


                                }

                            }

                        }

                    }

                }
             }

               
                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                }
            }
        }
    }
}
