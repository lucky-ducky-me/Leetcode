using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _1431_Kids_With_the_Greatest_Number_of_Candies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var max = int.MinValue;
            var maxI = -1;

            for (var i = 0; i < candies.Length; i++)
            {
                var cand = candies[i];

                if (cand > max)
                {
                    max = cand;
                    maxI = i;
                }
            }

            var result = new List<bool>();

            for (var i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    result.Add(true);
                }
                else if (i == maxI)
                {
                    result.Add(true) ;
                }
                else
                {
                    result.Add(false);
                }
            }

            return result;
        }
    }
}
