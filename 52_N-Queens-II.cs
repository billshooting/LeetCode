//Same as previous one, but no need for store map
public class Solution {
    public int TotalNQueens(int n) {
        List<char[]> map = new List<char[]>();
        for(int i = 0; i < n; i++)
        {
            char[] chs = new char[n];
            for(int j = 0; j < n; j++) chs[j] = '.';
            map.Add(chs);
        }
        int c = 0;
        DFS(map, n, 0, ref c);
        return c;
    }
    
    private bool DFS(IList<char[]> map, int n, int row, ref int c)
    {
        if(row == n) return true;
        for(int i = 0; i < n; i++)
        {
            if(Test(map, row, i, n))
            {
                map[row][i] = 'Q';
                if(DFS(map, n, row + 1,ref c)) c++;
                map[row][i] = '.';
            }
        }
        return false;
    }
    
    private bool Test(IList<char[]> map, int posx, int posy, int n)
    {
        for(int i = 0; i < n; i++)
        {
            if(map[i][posy] == 'Q') return false;
            if(map[posx][i] == 'Q') return false;
        }
        for(int i = 1; i < n; i++)
        {
            if(posx - i >= 0 && posy - i >= 0)
                if(map[posx - i][posy - i] == 'Q') return false;
            if(posx + i < n && posy - i >= 0 )
                if(map[posx + i][posy - i] == 'Q') return false;
            if(posx + i < n && posy + i < n)
                if(map[posx + i][posy + i] == 'Q') return false;
            if(posx - i >= 0 && posy + i < n)
                if(map[posx - i][posy + i] == 'Q') return false;
        }
        return true;
    }
}