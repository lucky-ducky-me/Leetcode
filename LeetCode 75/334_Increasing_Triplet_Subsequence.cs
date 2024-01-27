using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _334_Increasing_Triplet_Subsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            var maxes = new int[nums.Length];
            var mins = new int[nums.Length];

            maxes[nums.Length - 1] = nums[nums.Length - 1];
            mins[0] = nums[0];

            var min = nums[0];
            var max = nums[nums.Length - 1];

            for (int i = 1; i < nums.Length; i++)
            {
                mins[i] = min;

                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            for (var i = nums.Length - 1 - 1; i >= 0; i--)
            {
                maxes[i] = max;
                
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > mins[i] && nums[i] < maxes[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
