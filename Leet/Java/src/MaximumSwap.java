import javax.swing.text.html.MinimalHTMLWriter;

/**
 * MaximumSwap
 */
public class MaximumSwap {

    public int maximumSwap(int num) {
        
       char[] ichar = maximumSwap(Integer.toString(num).toCharArray(), 0);

       return Integer.parseInt(new String(ichar));

    }

    public char[] maximumSwap(char[] intarray, int startIndex)
    {

        if(startIndex == intarray.length-1)
            return intarray;

        int maxIndex = startIndex;
        for(int i = startIndex; i<intarray.length;i++){
            if(intarray[i] >= intarray[maxIndex])
                maxIndex = i;   
        }

        if(maxIndex == startIndex || (intarray[maxIndex] == intarray[startIndex]))
            return maximumSwap(intarray, startIndex + 1);
        else
        {
            char temp = intarray[startIndex];
            intarray[startIndex] = intarray[maxIndex];
            intarray[maxIndex] =temp;
            return intarray;
        }
    }
}