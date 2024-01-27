using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        }

        static public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var sortedStr = String.Concat(str.OrderBy(c => c));

                if (!dict.ContainsKey(sortedStr))
                {
                    dict.Add(sortedStr, new List<string>() { str });
                }
                else
                {
                    dict[sortedStr].Add(str);
                }
            }

            IList<int> test = new List<int>();

            IList<IList<string>> ans = new List<IList<string>>();

            foreach (var key in dict.Keys)
            {
                ans.Add((IList<string>)dict[key]);
            }

            return ans;
        }
    }
}
