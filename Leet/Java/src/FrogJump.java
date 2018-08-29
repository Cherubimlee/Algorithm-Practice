public class FrogJump {
    public boolean canCross(int[] stones) {
        boolean r = canCross(stones, 0, 1);
        return r;
    }

    public boolean canCross(int[] stones, int startIndex, int steps)
    {
        if(steps<1)
        return false;

        if(stones.length-1 ==  startIndex)
            return true;
        
        int start = stones[startIndex];
        

       int nextStartIndex = searchStone(stones, startIndex, start+steps);

       if(nextStartIndex == -1)
            return false;

        return 
            
            canCross(stones, nextStartIndex, steps) ||
            canCross(stones, nextStartIndex, steps+1)||
            canCross(stones, nextStartIndex, steps-1);
    }

    public int searchStone(int[] stones, int initIndex, int target)
    {
        for(int i = initIndex; i<stones.length ;i++)
        {
            if(stones[i] == target)
                return i;

            if(stones[i] > target)
                return -1;
        }
        return -1;
    }
}