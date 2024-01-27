using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _643_Maximum_Average_Subarray_I
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double curSum = 0.0;
            for (var i = 0; i < k; i++)
            {
                curSum += nums[i];
            }

            double maxAvSum = curSum / k;
            for (var i = 1; i < nums.Length - k + 1; i++)
            {
                curSum -= nums[i - 1];
                curSum += nums[i + k - 1];

                if (curSum / k > maxAvSum)
                {
                    maxAvSum = curSum / k;
                }
            }

            return maxAvSum;
        }
    }
}
