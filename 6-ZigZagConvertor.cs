using System;
using System.Text;

namespace leetcode {

    public partial class Solution {
        public string Convert(string s, int numRows) {
            if (numRows == 1)
                return s;
                
            string[] rows = new string[numRows];
            int rowNum = 0;
            int direction = -1;
            for (int i = 0; i < s.Length; i++)
            {
                rows[rowNum] += s.Substring(i, 1);
 
                if (rowNum == (numRows - 1) || rowNum == 0)
                {
                    direction = direction * -1;
                }

                rowNum += direction;
            }

            var builder = new StringBuilder(s.Length);
            foreach (string row in rows)
            {
                builder.Append(row);
            }
            
            return builder.ToString();
        }
    }
}