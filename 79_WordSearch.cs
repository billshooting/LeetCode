public class Solution {
    public bool Exist(char[,] board, string word) {
        int m = board.GetLength(0);
        int n = board.GetLength(1);
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(DFS(board, word, 0, m, n, word.Length, i, j)) return true;
            }
        }
        return false;
    }
    
    private bool DFS(char[,] map, string word, int pos, int m, int n, int len, int x, int y)
    {
        if(len == 0) return true;
        if(x >= m || x < 0 || y >= n || y < 0 || map[x, y] == '\0') return false;
        if(map[x, y] == word[pos])
        {
            char temp = map[x, y];
            map[x, y] = '\0';
            if(DFS(map, word, pos + 1, m, n, len - 1, x, y + 1)) return true;
            if(DFS(map, word, pos + 1, m, n, len - 1, x + 1, y)) return true;
            if(DFS(map, word, pos + 1, m, n, len - 1, x - 1, y)) return true;
            if(DFS(map, word, pos + 1, m, n, len - 1, x, y - 1)) return true;
            map[x, y] = temp;
        }
        return false;

    }
}