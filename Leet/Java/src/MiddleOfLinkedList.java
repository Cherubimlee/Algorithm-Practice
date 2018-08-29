public class MiddleOfLinkedList
{
    public ListNode middleNode(ListNode head) {
        ListNode r = head;
        ListNode move = head;

        if(r == null || r.next == null)
        return r;

        while(true)
        {
            move = move.next;
           
           
            if(move == null)
            {
                return r;
            }
            else
            {
                move = move.next;

                if(move == null)
                    return r.next;
            }
           
            r = r.next;
        }

       
    }
}