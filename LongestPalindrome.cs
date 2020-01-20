using System.Linq;
namespace leetcode
{
    public partial class Solution {

    private int startIndex;
    private int length;
    /*Ok, I got some help from the submitted solutions to get this solution running in the required time.*/
    public string LongestPalindrome(string s) {
        if (s.Length < 2)
            return s;

        for (int i = 0; i < s.Length; i++)
        {
                //For odd length.
                this.ExtendPalindrome(s, i, i);

                //For even length.
                this.ExtendPalindrome(s, i, i + 1);
        }

        return s.Substring(this.startIndex, this.length);;        
    }

        private void ExtendPalindrome(string s, int start, int end)
        {
            while (start >= 0 && end < s.Length && s[start] == s[end])
            {
                start--;
                end++;
            }

            //When calculating newLength;
            //we will have to compensate for one reduction in start and one increment in end;
            //because of the while loop above.           
            // ~ end - start -1
            int newLength = ((end - 1) - (start + 1)) + 1;

            if (this.length < newLength)
            {
                //When calculating startIndex; we will have to compensate for the reduction in start.
                this.startIndex = start + 1;
                this.length = newLength;
            }            
        }
}
}