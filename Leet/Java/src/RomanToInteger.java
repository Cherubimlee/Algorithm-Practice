import java.lang.annotation.Retention;

import sun.security.util.Length;

/**
 * RomanToInteger
 */
public class RomanToInteger {

    public int romanToInt(String s) {
        char[] chars = s.toCharArray();
        int len = s.length();

        int r = 0;

        for(int i =0 ;i<len;i++)
        {

        boolean isrecall =  i+1 == len ? false :  recall(chars[i], chars[i+1]);

        if(isrecall)
            r-= chartoint(chars[i]);
        else
            r+= chartoint(chars[i]);
        }

        return r; 

    }

    public boolean recall(char before, char current)
    {
            if(before == 'I' && (current == 'V' || current == 'X'))
            return true;
        
            if(before == 'X' && (current == 'L' || current == 'C'))
            return true;
            
            if(before == 'C' && (current == 'D' || current == 'M'))
            return true;  
       
            return false;
    }

    public int chartoint(char c)
    {
        switch(c)
        {
            case 'I':
            return 1;
            case 'V':
            return 5;
            case 'X':
            return 10;
            case 'L':
            return 50;
            case 'C':
            return 100;
            case 'D':
            return 500;
            case 'M':
            return 1000;
            default:
            return 0;

        }
    }
}

