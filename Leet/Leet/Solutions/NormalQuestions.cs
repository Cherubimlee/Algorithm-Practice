using System;
namespace Leet
{
    public partial class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var strs = s.Trim(' ').Split(' ');
            return strs[strs.Length - 1].Length;
        }

        public int[] PlusOne(int[] digits)
        {
            int c = 0;


            digits[digits.Length - 1]++;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var r = digits[i] + c;
                c = 0;

                if (r == 10)
                {
                    digits[i] = 0;
                    c = 1;
                }
                else
                {
                    digits[i] = r;
                    return digits;
                }
            }

            if (c == 1)
            {
                int[] r = new int[digits.Length + 1];
                r[0] = 1;
                return r;
            }
            else


                return digits;
        }
    }
}
