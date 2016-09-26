public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> temp = new List<int>();
        Array.Sort(nums);
        DFS(res, temp, nums, nums.Length, 0);
        return res;
    }
    
    private void DFS(IList<IList<int>> res, IList<int> temp, int[] nums, int n, int step){
        if(step <= n) res.Add(new List<int>(temp));
        for(int i = step; i < n; i++)
        {
            temp.Add(nums[i]);
            DFS(res, temp, nums, n, i+ 1);
            temp.Remove(nums[i]);
            while(i < n - 1 && nums[i] == nums[i + 1]) i++;
        }
    }
}