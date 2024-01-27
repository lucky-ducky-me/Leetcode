Console.WriteLine(new Solution().IsPalindrome(10));

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        var str = x.ToString();

        for (var i = 0; i < str.Length / 2; i++) {
            if (str[i] != str[str.Length - i - 1])
                return false;
        }

        return true;
    }
}
