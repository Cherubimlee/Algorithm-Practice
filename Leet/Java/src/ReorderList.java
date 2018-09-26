/**
 * ReorderList
 */
public class ReorderList {

    public void reorderList(ListNode head) {
        if(head.next ==null)
            return;

        ListNode head2 = middleNode(head);

        ListNode revised = reviseList(head2);

        mergeList(head, revised);
    }



    public void mergeList(ListNode head1, ListNode head2){
        ListNode c1 = head1;
        ListNode c2 = head2;

        while(c1 != null && c2!=null){
            ListNode temp = c1.next;
            c1.next = c2;
            c1 = c2;
            c2 = temp; 
        }

    }

    public ListNode middleNode(ListNode head) {
        ListNode r = head;
        ListNode move = head;
        ListNode lastR = null;

        if(r == null || r.next == null)
        return r;

        while(true)
        {
            move = move.next;
                     
            if(move == null)
            {
                lastR.next = null;
                return r;
            }
            else
            {
                move = move.next;

                if(move == null)
                {
                    ListNode result = r.next;
                    r.next = null;
                    return result;
                }
            }
            lastR = r;
            r = r.next;
        }

       
    }

    public ListNode reviseList(ListNode head){

        ListNode c1 = head;
        ListNode c2 = head.next;
        c1.next = null;
        
        while(c2 != null){

            ListNode t = c2;
            c2 = c2.next;
            t.next = c1;
            c1 = t;
        }
        return c1;
    }

}