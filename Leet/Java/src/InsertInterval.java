import java.util.ArrayList;
import java.util.List;

import javax.lang.model.util.ElementScanner6;

import com.sun.org.apache.regexp.internal.recompile;
import com.sun.xml.internal.bind.v2.runtime.reflect.ListIterator;

public class InsertInterval 
{
    public List<Interval> insert(List<Interval> intervals, Interval newInterval) {

        int beginDeleteindex = -1;
        int removeCount = 0;

        for (int i = 0; i < intervals.size(); i++) {
            
           Interval orig = intervals.get(i);
    
            if(newInterval.start > orig.end) //b after a
                continue;
            

            if (newInterval.start >  orig.start && newInterval.end <orig.end) //b inner a
            {
                return intervals;
            }

            if(beginDeleteindex == -1)
                    beginDeleteindex = i;

            if(newInterval.end < orig.start) //  b before a
                    break;

                removeCount++;

            newInterval.start = Integer.min(orig.start, newInterval.start);
            newInterval.end = Integer.max(orig.end, newInterval.end);
                       
        }
   
          if(beginDeleteindex == -1)
                    intervals.add(newInterval);
            else
            {
                if(removeCount != 0)
                intervals.subList(beginDeleteindex, beginDeleteindex + removeCount).clear();

                intervals.add(beginDeleteindex, newInterval);
            }
        
            return intervals;
    }



}