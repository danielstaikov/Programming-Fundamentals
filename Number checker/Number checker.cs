﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
 

        }
    }
}
