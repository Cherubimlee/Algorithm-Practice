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


        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null)
                return null;
            
            ListNode endNode = findNode(head, k-1);
            ListNode previousStartNode = null;
            ListNode startNode = head;

            ListNode R = head;

            while(endNode != null)
            {
                var newStart = ReverseBetween(startNode, 1, k);

                if (previousStartNode == null)
                    R = newStart;
                else
                    previousStartNode.next = newStart;

                previousStartNode = startNode;

                startNode = startNode.next;

                endNode = startNode == null ? null: findNode(startNode, k-1);
                    
            }

            return R;
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

            if (thead != null)
                thead.next = ltile;
            else
                head = ltile;

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

                if (head == null)
                    return null;
                else
                    head = head.next;
            }

            return head;
        }

    }
}
