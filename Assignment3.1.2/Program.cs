using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 0;

            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }
        }
    }
}
