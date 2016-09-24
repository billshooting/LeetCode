//change the string to a specific order, for example: dictionary order, then we can compare.
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> res = new List<IList<string>>();
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        StringBuilder sb = new StringBuilder();
        foreach(string s in strs)
        {
            string id = GetID(s, sb);
            if(dic.ContainsKey(id)) dic[id].Add(s);
            else
            {
                dic.Add(id, new List<string>());
                dic[id].Add(s);
            }
        }
        foreach(var list in dic.Values) res.Add(list);
        return res;
    }
    
    private string GetID (string s, StringBuilder sb)
    {
        if(string.IsNullOrEmpty(s)) return s;
        char[] chs = s.ToCharArray();
        Array.Sort(chs);
        sb.Clear();
        foreach(char ch in chs)  sb.Append(ch);
        return sb.ToString();
    }
}