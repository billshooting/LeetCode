public class Solution {
    public bool Search(int[] nums, int target) {
        if(nums.Length == 0 || (nums.Length == 1 && nums[0] != target)) return false;
        if(nums[0] == target) return true;
        int front = 0, back = nums.Length - 1, middle = 0;
        while(front < back)
        {
            middle = (front + back) / 2;
            if(nums[middle] > nums[front]) front = middle;
            else if(nums[middle] == nums[front]) front++;
            else back = middle;
        }
        if(target >= nums[back] && target <= nums[nums.Length - 1])
        {
            if(Array.BinarySearch(nums, back, nums.Length - back, target) > 0) return true;
            else return false;
        }
        else if(target >= nums[0] && target <= nums[back - 1]) 
        {
            if(Array.BinarySearch(nums, 0, back, target) > 0) return true;
            else return false;
        }
        else return false;
    }
}