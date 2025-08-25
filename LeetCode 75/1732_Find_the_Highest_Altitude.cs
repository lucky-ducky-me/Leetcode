using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
	internal class _1732_Find_the_Highest_Altitude
	{
		public int LargestAltitude(int[] gain)
		{
			if (gain.Length == 1)
				return 0;

			var curMaxSum = gain[0];
			var curSum = gain[0];

			for (int i = 1; i < gain.Length; i++)
			{
				curSum += gain[i];

				curMaxSum = curMaxSum > curSum
					? curMaxSum
					: curSum;	
			}

			return curMaxSum > 0 ? curMaxSum : 0;
		}
	}
}
