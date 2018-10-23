/**
 * OddEvenLinkedList
 */
public class OddEvenLinkedList {

    public ListNode oddEvenList(ListNode head) {
        
        if(head == null || head.next == null)
        return head;

        ListNode head2 = head.next;

        ListNode evenListHead = head;
        ListNode oddListHead = head.next;
        

        while(evenListHead.next != null && oddListHead.next != null)
        {
            if(evenListHead.next.next != null)
            {
                ListNode Next = evenListHead.next.next;
                evenListHead.next = Next;
                evenListHead = Next;
            }
            else
            {
                evenListHead.next = null;
            }

            if(oddListHead.next.next != null)
            {
                ListNode Next = oddListHead.next.next;
                oddListHead.next = Next;
                oddListHead = Next;
            }
            else
            {
                oddListHead.next = null;
            }
        }

        evenListHead.next = head2;

        return head;
    }
}