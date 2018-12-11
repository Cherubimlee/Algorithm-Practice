import javax.lang.model.util.ElementScanner6;

import com.sun.xml.internal.bind.v2.schemagen.xmlschema.List;

/**
 * PartitionList
 */
public class PartitionList {

    public ListNode partition(ListNode head, int x) {

        if(head == null)
            return head;

        ListNode movingHead = head;

        ListNode leftNode = null;
        ListNode leftNodeHead = null;

      
        ListNode rightNode = null;
        ListNode rightNodeHead = null;

        while(movingHead != null)
        {
            if(movingHead.val >= x)
            {
                if(rightNode != null){
                    rightNode.next = movingHead;
                    rightNode = rightNode.next;
                }else
                {
                    rightNode = movingHead;
                    rightNodeHead = movingHead;
                }
            }
            else 
            {
                if(leftNode != null){
                    leftNode.next = movingHead;
                    leftNode = leftNode.next;
                }else
                {
                    leftNode = movingHead;
                    leftNodeHead = movingHead;
                }
            } 
 
             movingHead = movingHead.next;
        }


        if(leftNode != null)
            leftNode.next = null;
        
     
        if(rightNode != null)
            rightNode.next = null;

       
       
        if(leftNode != null)
        {
            leftNode.next = rightNodeHead;

            leftNode = rightNode;
        }
        else
        {
            leftNodeHead = rightNodeHead;
            leftNode = rightNode;
        }


        return leftNode;
        }

        

    }
    
