/**
 * Base7Int
 */
public class Base7Int {

    public String convertToBase7(int num) {
        
    if(num == 0)
        return "0";
    
    boolean negtive = num <0;

    int anum = Math.abs(num);

    StringBuilder sb =  new StringBuilder();

    while(anum >= 1){
        
        int r = anum % 7;

        anum = (anum-r)/7;

        sb.insert(0,String.valueOf(r));
    }

    if(negtive)
        sb.insert(0, '-');

    return sb.toString(); 
    }
}