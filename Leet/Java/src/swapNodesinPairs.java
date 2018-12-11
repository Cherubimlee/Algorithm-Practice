import com.sun.xml.internal.bind.v2.schemagen.xmlschema.List;

/**
 * swapNodesinPairs
 */
public class swapNodesinPairs {

    public ListNode swapPairs(ListNode head) {
     

        if(head == null)
            return null;
        if(head.next == null)
            return null;
        
        
        ListNode r = head.next;
        ListNode movingHead = null;
        ListNode movingTile = head;

       
       while(movingTile != null && movingTile.next != null)
       {

            ListNode t = movingTile.next.next;

            movingTile.next.next = movingTile;
            movingTile.next = t;

            movingTile = movingTile.next;
            
            if(movingHead == null)
                movingHead =  movingTile;
            else
            {
                movingHead.next = movingTile;
            }

            
       }
       
       
        return r;

    }
}