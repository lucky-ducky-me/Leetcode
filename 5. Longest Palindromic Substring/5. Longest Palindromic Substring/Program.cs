Console.WriteLine(new Solution().LongestPalindrome("aaaa"));

public class Solution
{
    public string LongestPalindrome(string s)
    {
        var longestSubstr = "";
        var longestSubstrLen = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var l = i;
            var r = i;

            for (var j = i; j < s.Length; j++)
            {
                if (l < 0 || r >= s.Length)
                    break;

                if (s[l] != s[r])
                    break;

                if (r - l + 1 > longestSubstrLen)
                {
                    longestSubstr = s.Substring(l, r - l + 1);
                    longestSubstrLen = r - l + 1;
                }


                l -= 1;
                r += 1;
            }

            l = i;
            r = i + 1;

            for (var j = i; j < s.Length; j++)
            {
                if (l < 0 || r >= s.Length)
                    break;

                if (s[l] != s[r])
                    break;

                if (r - l + 1 > longestSubstrLen)
                {
                    longestSubstr = s.Substring(l, r - l + 1);
                    longestSubstrLen = r - l + 1;
                }

                l -= 1;
                r += 1;
            }
        }

         return longestSubstr;
    }
}

