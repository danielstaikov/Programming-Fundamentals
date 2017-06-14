using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photsNum = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            string grade = null;
            double humanReadable = 0;
            if (size<1000)
            {
                humanReadable = size;
                grade = "B";
            }
            else if (size < 1000000)
            {
                humanReadable = Math.Round((double)size/1000,0);
                grade = "KB";
            }
            else
            {

                humanReadable = Math.Round((double)size / 1000000, 1);
                grade = "MB";
            }

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string landscape = null;
            if (width == height)
            {
                landscape = "square";
            }
            else if (width> height)
            {
                landscape = "landscape";
            }
            else
            {
                landscape = "portrait";
            }

            Console.WriteLine($"Name: DSC_{photsNum:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");//Date Taken: 25 / 12 / 2003 12:03
            Console.WriteLine($"Size: {humanReadable}{grade}");//Size: 1.5MB
            Console.WriteLine($"Resolution: {width}x{height} ({landscape})"); //Resolution: 5334x3006(landscape)
        }
    }
}
