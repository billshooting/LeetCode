public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[128] chs;
        int i = 0, j = 0, curlen = 0, maxlen = 0;
        while(j < s.Length)
        {
            if(chs[s[j]] == 0)
            {
                chs[s[j]]++;
                curlen++;
                j++;
            }
            else
            {
                maxlen = Math.Max(maxlen, curlen--);
                chs[s[i++]]--;
            }
        }
        maxlen = Math.Max(maxlen, curlen);
        return maxlen;
    }
}