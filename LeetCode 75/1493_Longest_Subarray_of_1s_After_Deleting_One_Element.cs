using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
	public class _1493_Longest_Subarray_of_1s_After_Deleting_One_Element
	{
		public int LongestSubarray(int[] nums)
		{
			var n = nums.Length;

			var onesCurrent = 0;
			var onesDict = new List<Tuple<int, int>>();
			var isWasTaken = false;
			var lastTakenIndex = 0;

			for (var i = 0; i < n; i++)
			{
				if (nums[i] == 1)
				{
					onesCurrent++;	

					if (n - 1 == i && isWasTaken)
					{
						onesDict.Add(new Tuple<int, int>(lastTakenIndex, onesCurrent));
					}
				}
				else
				{
					if (i < n - 1 && nums[i + 1] == 1 && !isWasTaken)
					{
						onesCurrent++;
						isWasTaken = true;
						lastTakenIndex = i;
						onesDict.Add(new Tuple<int, int>(i, onesCurrent));
					}
					else if (i < n - 1 && nums[i + 1] == 1)
					{
						onesDict.Add(new Tuple<int, int>(i, onesCurrent));
						onesCurrent = i - lastTakenIndex;	
						lastTakenIndex = i;
					}
					else if (onesCurrent != 0)
					{
						onesDict.Add(new Tuple<int, int>(lastTakenIndex, onesCurrent));
						onesCurrent = 0;
						isWasTaken = false;
					}
				}
			}
			
			var maxVal = 0;
			var cnt = onesDict.Count;

			if (cnt == 0 && onesCurrent != 0)
			{
				return onesCurrent - 1;
			}
			else if (cnt == 1)
			{
				return onesDict[0].Item2;
			}
			else if (cnt == 0)
			{
				return 0;
			}

			for (var i = 0; i < cnt; i++)
			{
				if (onesDict[i].Item2 > maxVal)
				{
					maxVal = onesDict[i].Item2;
				}
			}

			return maxVal - 1;
		}
	}
}
