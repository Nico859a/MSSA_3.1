using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsecOnes(new int[] { 0, 2, 1, 1, 9, 1, 1 });
            Console.ReadLine();
        }

        static int[] ConsecOnes(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 1 && nums[i + 1] == 1)
                {
                    nums[i] = 0;
                    nums[i + 1] = 0;
                    break;
                }
            }
            nums.ToList().ForEach(num => Console.Write(num.ToString() + ", "));
            return nums;
        }
    }
}
