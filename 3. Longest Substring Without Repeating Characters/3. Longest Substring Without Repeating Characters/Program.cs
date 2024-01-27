using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            Console.WriteLine(LengthOfLongestSubstring(str));
        }

        static public int LengthOfLongestSubstring(string s)
        {

            var queue = new Queue<int>();

            var maxLen = 0;
            var l = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (!queue.Contains(s[i]))
                {
                    queue.Enqueue(s[i]);

                    if (maxLen <= i - l + 1)
                        maxLen = i - l + 1;
                }
                else { 
                    while (queue.Contains(s[i]))
                    {
                        queue.Dequeue();
                        l++;
                    }

                    queue.Enqueue(s[i]);
                }
            }

            return maxLen;
        }
    }
}
