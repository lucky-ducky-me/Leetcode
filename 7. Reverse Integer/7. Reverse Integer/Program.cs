Console.WriteLine(new Solution().Reverse(int.Parse(Console.ReadLine())));

public class Solution
{
    public int Reverse(int x)
    {
        if (x == 0)
            return 0;

        if (x == Int32.MaxValue || x == Int32.MinValue)
        {
            return 0;
        }

        var sign = 1;

        if (x < 0)
        {
            sign = -1;
            x *= -1;
        }

        //delete last zeros
        while (x % 10 == 0)
        {
            x /= 10;
        }

        long newNumber = 0;

        newNumber = x % 10;
        x /= 10;

        while (x != 0) {
            newNumber *= 10;
            newNumber += x % 10;

            if (newNumber > Int32.MaxValue || newNumber * -1 < Int32.MinValue) 
            {
                return 0;
            }

            x /= 10;
        }

        return Convert.ToInt32(newNumber) * sign;
    }
}
