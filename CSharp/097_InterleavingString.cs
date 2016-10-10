public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int len1 = s1.Length, len2 = s2.Length, len3 = s3.Length;
        if(len1 + len2 != len3) return false;
        bool[,] dp = new bool[len1 + 1, len2 + 1];
        dp[0, 0] = true;
        for(int i = 0; i < len1; i++) dp[i + 1, 0] = (s3[i] == s1[i]) && dp[i, 0];
        for(int j = 0; j < len2; j++) dp[0, j + 1] = (s3[j] == s2[j]) && dp[0, j];
        for(int i = 0; i < len1; i++){
            for(int j = 0; j < len2; j++){
                dp[i + 1, j + 1] = (dp[i + 1, j] && (s2[j] == s3[i + j + 1])) ||
                                   (dp[i, j + 1] && (s1[i] == s3[i + j + 1]));
            }
        }
        return dp[len1, len2];
    }
}