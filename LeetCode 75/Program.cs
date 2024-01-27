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

            var task = new _643_Maximum_Average_Subarray_I();
            var nums = new int[] { 0, 1, 1, 3, 3 };
            var k = 4;
            var result = task.FindMaxAverage(nums, k);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(result);

        }
    }
}
