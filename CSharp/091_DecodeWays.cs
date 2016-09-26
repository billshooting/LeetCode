public class Solution {
    public int NumDecodings(string s) {
        if(String.IsNullOrEmpty(s) || s[0] == '0') return 0;
        int[] dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;
        char pre = s[0];
        for(int i = 1; i < s.Length; i++)
        {
            char c = s[i];
            if(pre == '1' || pre == '2') 
            {
                if(c == '0') dp[i + 1] = dp[i - 1];
                else if(pre == '1' || (c > '0' && c <= '6')) dp[i + 1] = dp[i - 1] + dp[i];
                else dp[i + 1] = dp[i];
            }
            else
            {
                if(c == '0') return 0;
                dp[i + 1] = dp[i];
            }
            pre = c;
        }
        return dp[s.Length];
    }
}