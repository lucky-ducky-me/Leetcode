using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            var task = new _1004_Max_Consecutive_Ones_III();
            var nums = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            var k = 2;
            var result = task.LongestOnes(nums, k);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(result);

        }
    }
}
