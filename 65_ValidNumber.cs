using System.Text.RegularExpressions;
public class Solution {
    private const string a = @"^[+-]?((\d+\.?\d*)|(\d*\.\d+))$";               //10
    private const string b = @"^[+-]?((\d+\.?\d*)|(d*\.\d+))[eE][+-]?\d+$";    //e
    
    public bool IsNumber(string s) {
        s = s.Trim();
        return Regex.IsMatch(s, a) ||
               Regex.IsMatch(s, b); 
    }
}