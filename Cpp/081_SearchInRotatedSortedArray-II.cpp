class Solution{
public:
    bool search(vector<int>& nums, int target)
    {
        size_t len = nums.size();
        if(len == 0 || (len == 1 && nums[0] != target)) return false;
        if(nums[0] == target) return true;
        int front = 0, back = len - 1, middle = 0;
        while(front < back)
        {
            middle = (front + back) / 2;
            if(nums[middle] > nums[front]) front = middle;
            else if(nums[middle] == nums[front]) front++;
            else back = middle;
        }
        if(target >= nums[back] && target <= nums[len - 1]) return binarySearch(nums, back, len - 1, target);
        else if(target >= nums[0] && target <= nums[back - 1]) return binarySearch(nums, 0, back - 1, target);
        else return false;
    }

    bool binarySearch(vector<int>& nums, int front, int back, int target)
    {
        int i = front, j = back, middle = 0;
        while(i < j)
        {
            middle = (i + j) / 2;
            if(nums[middle] < target) i = middle + 1;
            else if(nums[middle] == target) return true;
            else j = middle;
        }
        return nums[j] == target;
    }
};