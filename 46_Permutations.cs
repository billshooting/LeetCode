public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        int[] used = new int[nums.Length];
        if(nums.Length == 0) return res;
        Solve(nums, res, new List<int>(), 0, used);
        return res;
        
    }
    
    private bool Solve(int[] nums, List<IList<int>> res, List<int> temp, int times, int[] used)
    {
        if(times == nums.Length) return true;
        for(int i = 0; i < nums.Length; i++)
        {
            if(used[i] == 0)
            {
                used[i]++;
                temp.Add(nums[i]);
                if(Solve(nums, res, temp, times + 1, used)) res.Add(new List<int>(temp));
                temp.Remove(nums[i]);
                used[i]--;
            }
        }
        return false;
    }
}