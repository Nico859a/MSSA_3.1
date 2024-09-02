using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int spaces = 0;

            Console.Write("Please input a string: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaces++;
                }
            }
            Console.WriteLine($"{input}. Contains {spaces} spaces");
        }

        
    }
}
