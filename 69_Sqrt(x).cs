public class Solution {
    public int MySqrt(int x) {
        if(x == 0 || x == 1) return x;
        long cur = 0, step = 1, backStep = step;
        while(!(cur * cur <= x && (cur + 1) * (cur + 1) > x))
        {
            if(cur * cur < x)
            {
                backStep = step;
                cur += step;
                step *= 2;
            }
            else if(cur * cur == x) { return (int)cur; }
            else
            {
                backStep /= 2;
                cur -= Math.Max(1, backStep);
            }
        }
        return (int)cur;
    }
}