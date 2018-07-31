using System;
namespace Leet
{
    public partial class Solution
    {
        public bool IsPalindrome(int x)
        {
            //if (x < 0) return false;

            //var chs = x.ToString().ToCharArray();

            //var len = chs.Length -1;

            //for (int i = 0; i < len;i++)
            //{
            //    if (chs[i] != chs[len - i])
            //        return false;

            //    if (i > (len - i))
            //        break;
                    
            //}

            //return true;

            if (x < 10) return (x >= 0);
            int y = 0;
            for (int x2 = x; x2 > 0; y = y * 10 + (x2 % 10), x2 /= 10) { }
            return x == y;

        }
    }
}
