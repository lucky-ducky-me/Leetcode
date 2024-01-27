using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _443_String_Compression
    {
        public int Compress(char[] chars)
        {
            var s = new StringBuilder();

            for (var i = 0; i < chars.Length;)
            {
                var curChar = chars[i];

                var count = 1;
                
                s.Append(curChar);

                for (var j = i + 1; j < chars.Length; j++)
                {
                    if (curChar != chars[j])
                        break;

                    count++; 
                }

                if (count != 1) 
                {
                    s.Append(count.ToString());
                }

                i += count;
            }

            for (var i = 0; i < s.Length; i++)
            {
                chars[i] = s[i];
            }

            return s.Length;
        }
    }
}
