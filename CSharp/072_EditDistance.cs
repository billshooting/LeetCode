public class Solution {
    public int MinDistance(string word1, string word2) {
        int len1 = word1.Length, len2 = word2.Length;
        int[,] steps = new int[len1 + 1, len2 + 1];
        for(int i = 0; i <= len1; i++) steps[i, 0] = i;
        for(int i = 0; i <= len2; i++) steps[0, i] = i;
        for(int i = 1; i <= len1; i++)
        {
            for(int j = 1; j <= len2; j++)
            {
                if(word1[i - 1] == word2[j - 1]) steps[i, j] = steps[i - 1, j - 1];
                else
                {
                    int replace = steps[i - 1, j - 1] + 1;
                    int delete = steps[i, j - 1] + 1;
                    int insert = steps[i - 1, j] + 1;
                    steps[i, j] = Math.Min(replace, Math.Min(delete, insert));
                }
            }
        }
        return steps[len1, len2];
        
    }
}