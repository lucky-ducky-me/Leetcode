using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _1004_Max_Consecutive_Ones_III
    {
        public int LongestOnes(int[] nums, int k)
        {
            var curCount = 0;

            var maxCount = 0;

            var curAmountK = k;

            var q = new Queue<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    curCount++;
                }
                else
                {
                    if (curAmountK > 0)
                    {
                        q.Enqueue(i);
                        curAmountK--;
                        curCount++;
                    }
                    else
                    {
                        curCount = i - q.Dequeue();
                        q.Enqueue(i);
                    }
                }

                if (curCount > maxCount)
                {
                    maxCount = curCount;
                }
            }

            return maxCount;
        }
    }
}
