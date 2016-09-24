//Easy dynamic programming
public class Solution {
    public bool CanJump(int[] nums) {
        bool[] reachable = new bool[nums.Length];
        reachable[0] = true;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + nums[i]; j > i; j--)
            {
                if (j >= nums.Length) continue;
                if(reachable[j] == true) break;
                reachable[j] = reachable[i] || reachable[j];
            }
        }
        return reachable[nums.Length - 1];
    }
}