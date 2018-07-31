using System;
using System.Collections.Generic;

namespace Leet
{
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {

            if (string.IsNullOrEmpty(s))
                return 0;

            int r = 0;

            int startIndex=0;
            int endIndex=0;

            Dictionary<char, int> dict = new Dictionary<char, int>();
          
            char[] str = s.ToCharArray();

            for (int i = 0; i < s.Length;i++)
            {
                
                if(dict.ContainsKey(str[i]))
                {
                    
                    var index = dict[str[i]];

                    if (index >= startIndex)
                    {
                        int lent = endIndex - startIndex + 1;
                        r = r > lent ? r : lent;

                        startIndex = index + 1;
                    }

                }

                dict[str[i]] = i;
                    endIndex = i;

            }

            int len = endIndex - startIndex + 1;
            r = r > len ? r : len;

            return r;
        }
    }
}
