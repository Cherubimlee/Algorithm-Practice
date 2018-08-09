using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution solution = new Solution();

            //int[] arr = {3,3 };

            //var s = solution.TwoSum(arr,6);

            //if(s!=null)
            //Console.WriteLine(s[0] + " " + s[1]);

            //var s = solution.Reverse(2147483647);

            //if(s!=null)

            ListNode l1 = new ListNode(3){next = new ListNode(5)} ;

            //ListNode l2 = new ListNode(1) { next = new ListNode(2) { next = new ListNode(3){ next = new ListNode(4) { next = new ListNode(5)}} } };
            var s = solution.ReverseBetween(l1, 1, 2);

            while (s.next != null)
            {
                Console.Write(s.val + "=>");
                s = s.next;
            }


            //var num = new int[] { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6};

            //var r = solution.ThreeSum(num);

        }
    }
}
