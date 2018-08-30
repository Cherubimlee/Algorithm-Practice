public class RemoveElement{
    
    
    public int removeElement(int[] nums, int val) {
    
        int last = nums.length - 1;

        int start = 0;

        while(last > start)
        {
            if(nums[last] == val)
            {
                last--;
            }
            else
            {
                if(nums[start] == val)
                {
                    int temp = nums[start];
                    nums[start] = nums[last];
                    nums[last] = temp;
                }

                start ++;
            }
 
        }

        return nums.length - last + 1;

    }
}