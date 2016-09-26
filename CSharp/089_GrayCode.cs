public class Solution {
    public IList<int> GrayCode(int n) {
        IList<int> res = new List<int>((int)Math.Pow(2, n));
        res.Add(0);
        for(int i = 0; i < n; i++)
        {
            int incre = 1 << i;
            for(int j = res.Count - 1; j >= 0; j--)
                res.Add(res[j] + incre);
        }
        return res;
    }
}