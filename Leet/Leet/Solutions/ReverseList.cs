using System;
namespace Leet
{
    public partial class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode next = head?.next;
            ListNode last = null;

            while(current != null)
            {
                current.next = last;
                last = current;
                current = next;
                next = current?.next;
            }

            return last;
        }


        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode thead, ttile, lhead,ltile;

            thead = findNode(head, m-2);
            lhead = thead == null ? head : thead.next;

            ltile = findNode(lhead, n-m);
            ttile = ltile.next;

            ltile.next = null;

            ReverseList(lhead);

            if(thead != null)
                thead.next = ltile;

            if (lhead != null)
            lhead.next = ttile;

            return head;

        }

        public ListNode findNode(ListNode head, int n)
        {
            if (n < 0)
                return null;

            while(n > 0)
            {
                n--;
                head = head.next;
            }

            return head;
        }

    }
}
