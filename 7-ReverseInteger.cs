namespace leetcode
{

public partial class Solution {
    public int Reverse(int x) {
       var s = x.ToString();
       var chars = s.ToCharArray();
       var rChars = new char[chars.Length];
       for (int i = chars.Length - 1; i >= 0; i--)
       {
           rChars[chars.Length - (i + 1)] = chars[i];
       }
       string sReturn = new string(rChars);
       if (sReturn.EndsWith('-'))
        sReturn = "-" + sReturn.Substring(0,sReturn.Length-1);
       int finalValue;
       int.TryParse(sReturn, out finalValue);
       return finalValue;

    }
}
}