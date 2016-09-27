class Solution {
public:
    string longestPalindrome(string s) {
        if(s.length() == 0) return "";
        size_t len = s.length();
        if(len == 1) return s;
        int longest = 0, index = 0, mayLen = 0;
        for(int i = 0; i < len - longest / 2; i++)
        {
            mayLen = getLength(s, i);
            if(mayLen > longest)
            {
                longest = mayLen;
                index = i;
            }
        }
        if(longest % 2 == 0) return s.substr(index - longest / 2 + 1, longest);
        else return s.substr(index - longest / 2, longest);
    }

    int getLength(string s, int i)
    {
        int front = i - 1, back = i + 1, maxLen = 1;
        int tempLen = 1;
        size_t len = s.length();
        while(front >= 0 && back < len && s[front] == s[back])
        {
            tempLen += 2;
            front--;
            back++;
        }
        maxLen = max(maxLen, tempLen);

        front = i;
        back = i+ 1;
        tempLen = 0;
        while(front >= 0 && back < len && s[front] == s[back])
        {
            tempLen += 2;
            front--;
            back++;
        }
        maxLen = max(maxLen, tempLen);
        return maxLen;
    }
};