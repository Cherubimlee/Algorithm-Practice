using System;
namespace Leet
{
    public partial class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {

            if (l1 == null && l2 == null)
                return null;

            if (l2 == null)
                return l1;

            if (l1 == null)
                return l2;
            
            ListNode r = null;

            if(l1.val < l2.val)
            {
                r = l1;
                r.next = MergeTwoLists(l1.next, l2);
            }
            else
            {
                r = l2;
                r.next = MergeTwoLists(l1, l2.next);
            }
               
            return r;
            }




            public ListNode MergeKLists(ListNode[] lists)
            {
            if (lists.Length == 0)
                return null;
            if (lists.Length == 1)
                return lists[0];

            if (lists.Length == 2)
                return MergeTwoLists(lists[0], lists[1]);

            int mid = lists.Length / 2;

            ListNode[] left =  new ListNode[mid];
            ListNode[] right =  new ListNode [lists.Length - mid];

            for (int i = 0; i < lists.Length;i++)
            {
                if (i < mid)
                    left[i] = lists[i];
                else
                    right[i - mid] = lists[i];
            }

            ListNode l1 = MergeKLists(left);
            ListNode l2 = MergeKLists(right);

            return MergeTwoLists(l1, l2);

            }
       


    }
}
