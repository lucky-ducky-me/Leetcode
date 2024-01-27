using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _238_Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var productNonZero = 1;
            var containsZero = false;
            var countZeros = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    productNonZero *= nums[i];
                }
                else
                {
                    containsZero = true;
                    countZeros++;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (containsZero)
                    {
                        nums[i] = 0;
                    }
                    else
                    {
                        nums[i] = productNonZero / nums[i];
                    }
                }
                else
                {
                    if (countZeros >= 2)
                    {
                        nums[i] = 0;
                    }
                    else
                    {
                        nums[i] = productNonZero;
                    }
                }
            }

            return nums;
        }
    }
}
