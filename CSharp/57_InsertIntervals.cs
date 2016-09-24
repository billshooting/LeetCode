//Things are slightly different that you need keep the result in ascending order,
//so you have to track the merged-interval, insert it before anything else when you find intervals[i].start > merged-interval.end.
/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval) {
        IList<Interval> res = new List<Interval>();
        if(intervals.Count == 0)
        {
            res.Add(newInterval);
            return res;
        }
        int front = newInterval.start, back = newInterval.end;
        bool firstTime = true;
        for(int i = 0; i < intervals.Count; i++)
        {
            if(intervals[i].end < front) res.Add(intervals[i]);
            else front = Math.Min(front, intervals[i].start);
            if(intervals[i].start > back)
            {   
                if(firstTime)
                {
                    res.Add(new Interval(front, back));
                    firstTime = false;
                }
                res.Add(intervals[i]);
            }
            else back = Math.Max(back, intervals[i].end);
        }
        if(firstTime) res.Add(new Interval(front, back));
        return res;
    }
}