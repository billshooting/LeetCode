public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> res = new List<IList<int>>();
        if(k > n) return res;
        List<int> temp = new List<int>();
        DFS(res, temp, n, k, 0, 0);
        return res;
    }
    
    private void DFS(IList<IList<int>> res, List<int> temp, int n, int k, int step, int pos)
    {
        if(step == k)
        {
            res.Add(new List<int>(temp));
            return;
        }
        for(int i = pos; i < n; i++)
        {
            temp.Add(i + 1);
            pos++;
            DFS(res, temp, n, k, step + 1, pos);
            temp.Remove(i + 1);
        }
    }
}