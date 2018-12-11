/**
 * PermutationInString
 */
public class PermutationInString {

    public boolean checkInclusion(String s1, String s2) {
     
        int[] count = new int[26];
        char[] char1 = s1.toCharArray();

        for (char ch : char1) {
            count[ch-'a']++;
        }

        int index = 0;

        int startIndex = Integer.MIN_VALUE;
        int endIndex = Integer.MAX_VALUE;

        while(index != s2.length())
        {
            int i = s2.charAt(index) - 'a';

            if(count[i] > 0)
            {
                count[i]--;
                if(startIndex == Integer.MIN_VALUE)
                    startIndex = index;
            }
            else
            {
                if(startIndex != Integer.MIN_VALUE)
                    {
                        endIndex = index -1;
                        break;
                    }
            }

            index++;
        }

        return (s1.length() == (endIndex - startIndex +1));

    }
}