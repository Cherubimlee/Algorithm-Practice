using System;
namespace Leet
{
    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode c1 = l1;
            ListNode c2 = l2;

            int value = l1.val + l2.val;
            int carrier = 0;

            if (value >= 10)
            {
                carrier = 1;
                value -= 10;
            }

            ListNode r = new ListNode(value);
            ListNode cr = r;


            while (c1.next != null || c2.next != null)
            {
                if (c1.next == null)
                {
                    c2 = c2.next;
                    value = c2.val + carrier;

                }
                else if (c2.next == null)
                {
                    c1 = c1.next;
                    value = c1.val + carrier;
                }
                else
                {
                    c1 = c1.next;
                    c2 = c2.next;

                    value = c1.val + c2.val + carrier;
                }


                if (value >= 10)
                {
                    value -= 10;
                    carrier = 1;
                }
                else
                    carrier = 0;

                cr.next = new ListNode(value);

                cr = cr.next;
            }

            if (carrier == 1)
                cr.next = new ListNode(1);

            return r;


        }

    }
}
