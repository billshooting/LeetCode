public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> temp = new List<int>();
        DFS(nums, res, temp, nums.Length, 0, 0);
        return res;
    }
    
    private void DFS(int[] nums, IList<IList<int>> res, List<int> temp, int n, int step, int pos)
    {
        if(step <= n){
            res.Add(new List<int>(temp));
        }
        for(int i = pos; i < n; i++)
        {
            temp.Add(nums[i]);
            DFS(nums, res, temp, n, step + 1, ++pos);
            temp.Remove(nums[i]);
        }
    }
}