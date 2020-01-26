namespace leetcode 
{
    public partial class Solution {
        public int MyAtoi(string str) {
            str = str.TrimStart();
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            if (str.Substring(0,1).Equals("+"))
            {
                if (str.Length == 1)
                    return 0;

                int trash;
                if (int.TryParse(str.Substring(1,1), out trash))
                    str = str.Substring(1);
                else
                    return 0;                
            }

            int charTest = 0;
            bool isValid = true;

            while (charTest < str.Length && isValid)
            {
                var c = str.Substring(charTest++,1);
                int val;
                isValid = (c.Equals("-") && charTest == 1) || int.TryParse(c, out val);
            }

            if (!isValid)
                charTest--;
            
            if (charTest < 1)
                return 0;
            
            int returnVal;
            try
            {
                returnVal = int.Parse(str.Substring(0, charTest));
            }
            catch (System.OverflowException)
            {
                if (str.Substring(0,1).Equals("-"))
                    returnVal = int.MinValue;
                else
                    returnVal = int.MaxValue;
            }
            catch{
                return 0;
            }

            return returnVal;
        }
    }
}