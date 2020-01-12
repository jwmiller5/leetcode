namespace leetcode
{

public partial class Solution {
    public bool IsPalindrome(int x) {
       var s = x.ToString();
       var chars = s.ToCharArray();
       for (int i = chars.Length - 1; i >= chars.Length / 2; i--)
       {
           if (chars[i] != chars[chars.Length - (i + 1)])
            return false;
       }
       return true;
    }
}
}