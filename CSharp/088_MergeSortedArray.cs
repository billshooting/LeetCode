public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] res = new int[m + n];
        int i = 0, j = 0, k = 0;
        while(i < m || j < n)
        {
            if(i >= m) 
            {
                Array.Copy(nums2, j, res, k, n - j);
                break;
            }
            if(j >= n)
            {
                Array.Copy(nums1, i, res, k, m - i);
                break;
            }
            if(nums1[i] <= nums2[j]) res[k] = nums1[i++];
            else res[k] = nums2[j++];
            k++;
        }
        Array.Copy(res, nums1, m + n);
    }
}