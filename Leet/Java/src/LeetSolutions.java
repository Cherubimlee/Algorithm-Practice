import java.util.List;
import java.util.ArrayList;

public class LeetSolutions
{
    public static void main(String[] args) {
       
   // InsertInterval ii =  new InsertInterval();

   // List<Interval> list =  new ArrayList<Interval>();

    //list.add(new Interval(1, 5));
    // list.add(new Interval(3, 5));
    // list.add(new Interval(6, 7));
    // list.add(new Interval(8, 10));
    // list.add(new Interval(12, 16));

    // Interval i3 =  new Interval(0, 0);

    // ii.insert(list, i3);

    //RomanToInteger i =  new RomanToInteger();
    //i.romanToInt("MCMXCIV");

    // int[] stones =  new int[]{0,1,3,5,6,8,12,17};

    // FrogJump fj =  new FrogJump();
    // fj.canCross(stones);

    // int[] nums =  new int[]{0,1,2,2,3,0,4,2};

    // RemoveElement ele = new RemoveElement();
    // ele.removeElement(nums, 2);

    //MaximumSwap x = new MaximumSwap();
    //x.maximumSwap(98368);

    ListNode head =  new ListNode(1);
    head.next =  new ListNode(2);
    head.next.next = new ListNode(3);
    head.next.next.next = new ListNode(4);
    head.next.next.next.next = new ListNode(5);

    ReorderList rl =  new   ReorderList();

    rl.reorderList(head);
   }
}