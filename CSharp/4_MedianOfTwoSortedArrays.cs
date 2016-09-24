public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int len = nums1.Length + nums2.Length;
        int[] num = new int[len];
        int p1 = 0, p2 = 0, p3 = 0;
        while(p1 < nums1.Length || p2 < nums2.Length)
        {
            if(p2 >= nums2.Length || (p1 < nums1.Length && nums1[p1] < nums2[p2]))
            {
                num[p3] = nums1[p1];
                p1++;
            }
            else if(p1 >= nums1.Length || nums2[p2] <= nums1[p1])
            {
                num[p3] = nums2[p2];
                p2++;
            }
            p3++;
        }
        if(len % 2 == 0) return ((double)num[len / 2 - 1] + (double)num[len / 2]) / 2;
        else return (double)num[len / 2];
    }
}