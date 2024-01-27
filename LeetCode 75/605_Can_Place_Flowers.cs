using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _605_Can_Place_Flowers
    {
        //0 0 1 0 0 0 0 1 0 1 0 0 0 1 0 0 1 0 1 0 1 0 0 0 1 0 1 0 1 0 0 1 0 0 0 0 0 1 0 1 0 0 0 1 0 0 1 0 0 0 1 0 0 1 0 0 1 0 0 0 1 0 0 0 0 1 0 0 1 0 0 0 0 1 0 0 0 1 0 1 0 0 0 0 0 0
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var countFree = 0;

            if (flowerbed.Length == 1) 
            {
                if (n > 1)
                {
                    return false;
                }
                
                if (n == 0)
                {
                    return true;
                }

                if (flowerbed[0] == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (var i = 0; i < flowerbed.Length; i++)
            {
                if (i == flowerbed.Length - 1)
                {
                    if (flowerbed[i - 1] == 0 && flowerbed[i] == 0)
                    {
                        countFree++;
                        flowerbed[i] = 1;
                    }
                }
                else if (i == 0)
                {
                    if (flowerbed[i + 1] == 0 && flowerbed[i] == 0)
                    {
                        countFree++;
                        flowerbed[i] = 1;
                    }
                }
                else if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0 && flowerbed[i] == 0)
                {
                    flowerbed[i] = 1;
                    countFree++;
                }
            }

            return countFree >= n;
        }
    }
}
