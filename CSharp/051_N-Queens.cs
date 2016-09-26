// Deep first search
// for each row or column only have one Queen, use row or column as recursive step
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        List<IList<string>> res = new List<IList<string>>();
        List<char[]> map = new List<char[]>();
        for(int i = 0; i < n; i++)
        {
            char[] chs = new char[n];
            for(int j = 0; j < n; j++) chs[j] = '.';
            map.Add(chs);
        }
        DFS(res, map, n, 0);
        return res;
    }
    
    private void DFS(IList<IList<string>> res, IList<char[]> map, int n, int row)
    {
        if(row == n)
        {
            res.Add(GetListString(map));
            return;
        }
        for(int i = 0; i < n; i++)
        {
            if(Test(map, row, i, n))
            {
                map[row][i] = 'Q';
                DFS(res, map, n, row + 1);
                map[row][i] = '.';
            }
        }
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
    
    private IList<string> GetListString(IList<char[]> map)
    {
        var res = new List<string>();
        foreach(var chs in map)
        {
            res.Add(new string(chs));
        }
        return res;
    }
}