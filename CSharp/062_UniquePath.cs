public class Solution {
    public int UniquePaths(int m, int n) {
        int[,] map = new int[m, n];
        for(int i = 0; i < m; i++) map[i, n - 1] = 1;
        for(int i = 0; i < n; i++) map[m - 1, i] = 1;
        for(int i = 1; i < Math.Min(m, n); i++)
        {
            for(int j = m - 1 - i; j >=0; j--) map[j, n - 1 - i] = map[j + 1, n - 1 - i] + map[j, n - i];
            for(int j = n - 1 - i; j >=0; j--) map[m - 1 - i, j] = map[m - i, j] + map[m - 1 - i, j + 1];
        }
        return map[0, 0];
    }
}