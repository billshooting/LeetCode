// Easier than No.54, you dont need to handle the special situation.
public class Solution {
    public int[,] GenerateMatrix(int n) {
        int[,] res = new int[n, n];
        int value = 1;
        for(int i = 0; i < (n + 1) / 2; i++)
        {
            for(int j = i; j < n - i; j++, value++) res[i, j] = value;
            for(int j = i + 1; j < n - i; j++, value++) res[j, n - 1 - i] = value;
            for(int j = n - i - 2; j >= i; j--, value++) res[n - 1 - i, j] = value;
            for(int j = n - i - 2; j > i; j--, value++) res[j, i] = value;
        }
        return res;
    }
}