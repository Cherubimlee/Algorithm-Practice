import java.util.HashMap;
import java.util.HashSet;


/**
 * MostCommonWord
 */
public class MostCommonWord {

    public String mostCommonWord(String paragraph, String[] banned) {
        

        HashMap<String, Integer> wordsmap = new HashMap<String, Integer>();
        HashSet<String> bannedlist =  new HashSet<String>();
  
  for (String s : banned) {
  bannedlist.add(s);
  }
  
  String[] list = paragraph.toLowerCase().replaceAll("[^a-z]", " ").split(" +");

  String maxStr = null;
  int maxCount =0;

  for (String str : list) {

      
      if(wordsmap.containsKey(str))
      {
        
        Integer v = wordsmap.get(str);
        Integer newV = v+1;
        wordsmap.replace(str, v, newV);

         if(newV > maxCount)
              {
                  maxCount = newV;
                  maxStr = str;
              }
      }
      else
      {
          if(!bannedlist.contains(str))
          {
              wordsmap.put(str, new Integer(1));

              if(maxStr == null)
              {
                  maxStr = str;
                  maxCount = 1;
              }
              
          }
      }
  }

  return maxStr; 

    }
}