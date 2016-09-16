//Sort the list with Interval.start, then merge the intervals one by one.
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
    public IList<Interval> Merge(IList<Interval> intervals) {
        IList<Interval> res = new List<Interval>();
        if(intervals.Count == 0) return res;
        List<Interval> list = new List<Interval>(intervals);
        list.Sort((a, b) => a.start - b.start);
        int back = list[0].start, front = list[0].start;
        for(int i = 0; i < list.Count; i++)
        {
            if(list[i].start > back) 
            {
                res.Add(new Interval(front, back));
                front = list[i].start;
                back = list[i].end;
            }
            else
            {
                back = Math.Max(list[i].end, back);
            }
        }
        res.Add(new Interval(front, back));
        return res;
    }
}