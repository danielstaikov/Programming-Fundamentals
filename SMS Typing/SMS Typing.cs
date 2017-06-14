using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int length = 0;
            int mainDigit = 0;
            int offset = 0;
            int letterIndex = 0;
            string firstNum = null;
            string cases = null;
            string sms = null;
            for (int i = 0; i < number; i++)
            {
                int digit = int.Parse(Console.ReadLine());

                if (digit!=0)
                {
                    length = digit.ToString().Length;
                    cases = Convert.ToString(digit);
                    firstNum = cases[0].ToString();
                    mainDigit = int.Parse(firstNum);
                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset = (mainDigit - 2) * 3 + 1;
                    }
                    else
                    {
                        offset = (mainDigit - 2) * 3;
                    }
                    letterIndex = offset + length - 1;
                    sms = (sms + (char)(letterIndex + 97));
                }
                else
                {

                    sms = (sms + (char)(32));
                }
            }
            Console.WriteLine(sms);
        }
    }
}