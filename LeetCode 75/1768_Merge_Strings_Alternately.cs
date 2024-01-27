using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _1768_Merge_Strings_Alternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            var resultLine = new StringBuilder();

            var minLenght = Math.Min(word1.Length, word2.Length);

            for (var i = 0; i < minLenght; i++)
            {
                resultLine.Append(word1[i]);
                resultLine.Append(word2[i]);
            }

            if (word1.Length > word2.Length)
            {
                resultLine.Append(word1.Substring(word2.Length));
            }
            else
            {
                resultLine.Append(word2.Substring(word1.Length));
            }

            return resultLine.ToString();
        }
    }
}
