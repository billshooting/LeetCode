public class Solution {
    public string LongestPalindrome(string s) {
        if(s == "") return "";
        if(s.Length == 1) return s;
        int longest = 0, index = 0;
        for(int i = 0; i < s.Length - longest / 2; i++)
        {
            int length = GetLength(s, i);
            if(length > longest)
            {
                longest = length;
                index = i;
            }
        }
        if(longest % 2 == 0) return s.Substring(index - (longest/2) + 1, longest);
        else return s.Substring(index - (longest/2), longest);
    }
    
    private int GetLength(string s, int i)
    {
        int front = i -1;
        int back = i + 1;
        int length = 1;
        int templength1 = 1;
        while(front >=0 && back < s.Length && s[front] == s[back])
        {
            templength1 +=2;
            front--;
            back++;
        }
        length = templength1 > length ? templength1 : length;
        
        front = i;
        back = i + 1;
        int templength2 = 0;
        while(front >= 0 && back < s.Length && s[front] == s[back])
        {
            templength2 +=2;
            front--;
            back++;
        }
        length = templength2 > length ? templength2 : length;
        
        return length;
    }
}