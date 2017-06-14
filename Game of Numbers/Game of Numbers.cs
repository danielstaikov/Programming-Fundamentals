using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
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
                int endNumOne = 0;
                int endNumTwo = 0;

                for (int i = n; i <= m; i++)
                {
                    for (int j = n; j <= m; j++)
                    {

                        sum = i + j;
                        moves++;
                        if (sum == controlNumber)
                        {
                            endNumOne = i;
                            endNumTwo = j;

                        }

                    }


                }

                if ((endNumOne + endNumTwo)==controlNumber)
                {
                    Console.WriteLine($"Number found! {endNumOne} + {endNumTwo} = {controlNumber}");

                }
                else
                {
                    Console.WriteLine($"{moves} combinations - neither equals {controlNumber}");

                }
            }
        }
    } 
