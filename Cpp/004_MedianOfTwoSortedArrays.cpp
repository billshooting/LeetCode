class Solution {
public:
    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2) {
        int len1 = nums1.size(), len2 = nums2.size();
        int len = len1 + len2;
        int num[len] = {0};
        int p1 = 0, p2 = 0, p3 = 0;
        while(p1 < len1 || p2 < len2)
        {
            if(p2 >= len2 || (p1 < len1 && nums1[p1] < nums2[p2]))
            {
                num[p3] = nums1[p1];
                p1++;
            }
            else if(p1 >= len1 || nums2[p2] <= nums1[p1])
            {
                num[p3] = nums2[p2];
                p2++;
            }
            p3++;
        }
        if(len % 2 == 0) return ((double)num[len / 2 - 1] + (double)num[len / 2]) / 2;
        else return (double)num[len / 2];
    }
};