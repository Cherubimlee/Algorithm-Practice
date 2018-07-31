using System;
namespace Leet
{
    public partial class Solution
    {
        public int Reverse(int x)
        {

            if (x > Int32.MaxValue || x < Int32.MinValue)
                return 0;

            if (x == 0)
                return 0;

            int m = x > 0 ? x : x * -1;

            char[] ch = m.ToString().ToCharArray();

            var len = ch.Length;
            int result = 0;
            for (int i = 0; i < len; i++)
            {

                int num = ch[i] - '0';

                result += num * (int)Math.Pow(10, i);

            }

            if (result < 0)
                return 0;

            var next = result.ToString().ToCharArray();
            var orig = m.ToString().Trim('0').ToCharArray();

            for (int i = 0; i < next.Length; i++)
            {
                if (next[i] != orig[next.Length - i - 1])
                    return 0;
            }

            if (x < 0)
                result *= -1;




            return result;

        }

    }
}
