public class Solution {
    public string SimplifyPath(string path) {
        StringBuilder sb = new StringBuilder(path);
        for(int i = 1; i < sb.Length; i++)
        {
            if(sb[i] == '/' && sb[i - 1] == '/')
            {
                sb.Remove(i, 1);
                i--;
            }
        }
        string[] dirs = sb.ToString().Trim('/').Split('/');
        sb.Clear();
        int back = 0;
        for(int i = dirs.Length - 1; i >= 0; i--)
        {
            if(dirs[i] == ".") continue;
            else if(dirs[i] == "..")
            {
                back++;
                continue;
            }
            else
            {
                if(back != 0)
                {
                    back--;
                    continue;
                }
                else sb.Insert(0, "/" + dirs[i]);
            }
        }
        if(sb.Length == 0) return "/";
        else return sb.ToString();
    }
}