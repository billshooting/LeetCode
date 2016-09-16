public class Solution {
    public int LengthOfLastWord(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        s = s.Trim();
        int i = s.Length - 1;
        while(i >= 0 && s[i] != ' ') i--;
        return s.Length - 1 - i;
    }
}