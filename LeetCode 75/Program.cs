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

            var task = new _1493_Longest_Subarray_of_1s_After_Deleting_One_Element();
            var nums = new int[] { 1, 1, 1 };
            var k = 2;
            var result = task.LongestSubarray(nums);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(result);

        }
    }
}
