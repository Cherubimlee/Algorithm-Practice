import java.util.HashMap;
import java.util.ArrayList;

class MagicDictionary {

    HashMap<String,ArrayList<String>> mdict;

    /** Initialize your data structure here. */
    public MagicDictionary() {
        mdict = new HashMap<String,ArrayList<String>>();
    }
    
    /** Build a dictionary through a list of words */
    public void buildDict(String[] dict) {
        
        for (String str : dict) {
            String[] strarray =  buildStrArray(str);

            for (String var : strarray) {
              
                if(mdict.keySet().contains(var))
                {
                    ArrayList<String> list = mdict.get(var);
                    list.add(str);
                }
                else
                {
                    ArrayList<String> list = new ArrayList<String>();
                    list.add(str);
                    mdict.put(var,list);
                }
                
            }
        }
    }
    
    /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
    public boolean search(String word) {
        
        String[] strarray =  buildStrArray(word);

            for (String var : strarray) {
                if(mdict.keySet().contains(var))
                {

                    ArrayList<String> list =  mdict.get(var);


                    if(list.size() > 1)
                        return true;

                    if(!list.get(0).equals(word))
                    return true;
                
                }
            }
        
        return false;
    }

    public String[] buildStrArray(String str)
    {
        char[] array =  str.toCharArray();

        String[] r = new String[array.length];

        for(int i = 0; i<array.length;i++)
        {
            char t = array[i];
            array[i] = '?';
            r[i] =  new String(array);
            array[i] = t;

        }

        return r;
    }
}