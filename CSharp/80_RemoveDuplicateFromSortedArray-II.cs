public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0) return 0;
        int[] res = new int[nums.Length];
        int front = 0;
        int j = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != nums[front])
            {
                front = i;
                res[j++] = nums[i];
            }
            else if(i - front < 2) res[j++] = nums[i];
        }
        res.CopyTo(nums, 0);
        return j;
    }
}