using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter XY coordinates to determine their quadrant");
            Console.Write("Enter X coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0) 
            {
                Console.WriteLine("Your coordinates are in quadrant 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Your coordinates are in quadrant 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Your coordinates are in quadrant 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Your coordinates are in quadrant 4");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Your coordinates are at the orgin");
            }

        }
    }
}
