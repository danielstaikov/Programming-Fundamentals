using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            //all the possible nucleic acid sequences (A, C, G and T), in the range [AAA…TTT]
            //Print a new line every 4 sequences.
            //Each nucleotide has a corresponding numeric value – A  1, C  2, G  3, T  4.
            int sum = 0;
            string first = null;
            string second = null;
            string tirth = null;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        sum = i + j + k;
                        switch (i)
                        {
                            case 1:
                                first = "A";
                                break;
                            case 2:
                                first = "C";
                                break;
                            case 3:
                                first = "G";
                                break;
                            case 4:
                                first = "T";
                                break;
                        }
                        switch (j)
                        {
                            case 1:
                                second = "A";
                                break;
                            case 2:
                                second = "C";
                                break;
                            case 3:
                                second = "G";
                                break;
                            case 4:
                                second = "T";
                                break;
                        }
                        switch (k)
                        {
                            case 1:
                                tirth = "A";
                                break;
                            case 2:
                                tirth = "C";
                                break;
                            case 3:
                                tirth = "G";
                                break;
                            case 4:
                                tirth = "T";
                                break;
                        }



                        if (sum>= matchSum)
                        {
                            if (k==4)
                            {
                                Console.WriteLine($"O{first}{second}{tirth}O");
                            }
                            else
                            {
                                Console.Write($"O{first}{second}{tirth}O ");
                            }
                            
                        }
                        else
                        {
                            if (k == 4)
                            {
                                Console.WriteLine($"X{first}{second}{tirth}X");
                            }
                            else
                            {
                                Console.Write($"X{first}{second}{tirth}X ");
                            }                          
                        }
                    }
                }
            }
        }
    }
}