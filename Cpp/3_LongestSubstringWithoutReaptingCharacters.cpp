class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int chs[128] = {0};
        int i = 0, j = 0, curlen = 0, maxlen = 0;
        while(j < s.length())
        {
            if(chs[s[j]] == 0)
            {
                chs[s[j]]++;
                j++;
                curlen++;
            }
            else{
                maxlen = max(curlen--, maxlen);
                chs[s[i++]]--;
            }
        }
        maxlen = max(maxlen, curlen);
        return maxlen;
    }
};