// binary divided, O(logn)
public class Solution {
    public double MyPow(double x, int n) {
        if(x == 1) return 1;
        if(x == -1) return n % 2 == 0 ? 1 : -1;
        if(n == int.MinValue) return 0;
        if(n == 0) return 1;
        if(n == 1) return x;
        if(n < 0)
        {
            n = -n;
            x = 1 / x;
        }
        if(n % 2 == 0)
        {
            double temp = MyPow(x, n / 2);
            if(temp == double.NaN) return 0;
            return temp * temp;
        }
        else
        {
            double temp = MyPow(x, n / 2);
            if(temp == double.NaN) return 0;
            return x * temp * temp;
        }
    }
}