//priciple: if the sum of a sumarray is negative, you dont need to include it.
//dynamic programming.
public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int[] maxSub = new int[nums.Length];
        maxSub[0] = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            maxSub[i] = maxSub[i - 1] > 0 ? maxSub[i - 1] + nums[i] : nums[i];
            max = Math.Max(max, maxSub[i]);
        }
        return max;
    }
}