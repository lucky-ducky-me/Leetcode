using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _151_Reverse_Words_in_a_String
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return String.Join(" ", words.Reverse());
        }
    }
}
