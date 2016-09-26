public class Solution {
    public void SortColors(int[] nums) {
        int front = 0, back = nums.Length - 1;
        while(front < nums.Length && nums[front] == 0) front++;
        while(back >= 0 && nums[back] == 2) back--;
        for(int i = 0; i <= nums.Length; i++)
        {
            if(i < front || i > back) continue;
            if(nums[i] == 0)
            {
                Swap(nums, i, front);
                front++;
                i--;
                if(i == back && nums[back] == 2) back--;
                continue;
            }
            if(nums[i] == 2)
            {
                Swap(nums, i, back);
                back--;
                i--;
                if(i == front && nums[front] == 0) front++;
            }
        }
    }
    
    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}