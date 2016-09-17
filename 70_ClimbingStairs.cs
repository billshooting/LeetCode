//result = C(n, 0) + C(n - 1, 1) + C(n -2, 2) + ... + C(n - n / 2, n / 2)
//when calculate C(), value may overflow, use long instead of int.
public class Solution {
    public int ClimbStairs(int n) {
        long res = 0;
        for(int i = 0; i <= n / 2; i++) res += Combine(n - i, i);
        return (int)res;
    }
    
    private long Combine(int n, int m)
    {
        if(m == 0) return 1;
        long a = 1;
        for(int i = 0; i < m; i++)
        {
            a = (a * (n - i)) / (1 + i);
        }
        return a;
    }
}