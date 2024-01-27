using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_75
{
    internal class _345_Reverse_Vowels_of_a_String
    {
        public string ReverseVowels(string s)
        {
            var resList = s.ToList();

            var vowels = new Stack<char>();
            var indexes = new Queue<int>();

            List<char> VOWELS = new List<char>{ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (var i = 0; i < resList.Count; i++)
            {
                if (VOWELS.Contains(resList[i]))
                {
                    vowels.Push(resList[i]);
                    indexes.Enqueue(i);
                }
            }

            while (vowels.Count > 0)
            {
                var vowel = vowels.Pop();
                var index = indexes.Dequeue();

                resList[index] = vowel;
            }

            return String.Join("", resList.Select(x => x.ToString()));

        }
    }
}
