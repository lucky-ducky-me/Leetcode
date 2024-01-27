using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _1071_Greatest_Common_Divisor_of_Strings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            var stringSmaller = new List<string>();
            var stringBigger = new List<string>();

            if (str1.Length < str2.Length)
            {
                stringSmaller = str1.ToList().Select(x => x.ToString()).ToList();
                stringBigger = str2.ToList().Select(x => x.ToString()).ToList();
            }
            else
            {
                stringSmaller = str2.ToList().Select(x => x.ToString()).ToList();
                stringBigger = str1.ToList().Select(x => x.ToString()).ToList();
            }

            var size = 1;

            var divisors = new List<string>
            {
                ""
            };

            while (size <= stringSmaller.Count)
            {
                var index = 0;

                var substr = stringSmaller.GetRange(0, size);

                var cond = true;

                // Проверка меньшей строки
                while (index < stringSmaller.Count && cond)
                {
                    var i = index;

                    var checkedAmount = 0;

                    for (; i < size + index && cond && i < stringSmaller.Count; i++)
                    {
                        cond &= substr[i - index] == stringSmaller[i];
                        checkedAmount++;
                    }

                    index += size;

                    if (checkedAmount < size) 
                    {
                        cond = false;
                    }
                }

                index = 0;

                // Проверка большей строки
                while (index < stringBigger.Count && cond)
                {
                    var i = index;

                    var checkedAmount = 0;

                    for (; i < size + index && cond && i < stringBigger.Count; i++)
                    {
                        cond &= substr[i - index] == stringBigger[i];
                        checkedAmount++;
                    }

                    index += size;

                    if (checkedAmount < size)
                    {
                        cond = false;
                    }
                }

                size += 1;

                if (cond)
                {
                    divisors.Add(String.Join("", substr));
                }
            }

            return divisors[divisors.Count - 1];
        }
    }
}
