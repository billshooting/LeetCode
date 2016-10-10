public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        List<string> res = new List<string>();
        if(s.Length < 4 || s.Length > 12) return res;
        string[] temp = new string[4];
        DFS(res, temp, s, 0);
        return res;
    }

    public void DFS(IList<string> res, string[] temp, string remain, int step){
        if(step == 4 && remain.Length == 0)
        {
            res.Add(String.Join(".", temp));
            return;
        }
        for(int i = 1; i < 4; i++)
        {
            if(step == 4 || remain.Length < i) return;
            string s = remain.Substring(0, i);
            if(!IsValid(s)) return;
            temp[step] = s;
            DFS(res, temp, remain.Substring(i, remain.Length - i), step + 1);
            temp[step] = null;
        }
    }
    
    public bool IsValid(string s){
        if(s.StartsWith("0") && s.Length > 1) return false;c
        else{
            int num = int.Parse(s);
            if(num > 255) return false;
            return true;
        }
    }

}