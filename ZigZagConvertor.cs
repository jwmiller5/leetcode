using System;
using System.Text;

namespace leetcode {

    public partial class Solution {
        public string Convert(string s, int numRows) {
            string[] rows = new string[numRows];
            int letters = 0;
            int i = 0;
            while (letters < s.Length)
            {
                int rownum = i % (numRows);
                int columnnum = i / numRows;
                if (shouldWrite(rownum, columnnum, numRows))
                    rows[rownum] += s.Substring(letters++, 1);
                i++;
            }

            var builder = new StringBuilder(s.Length);
            foreach (string row in rows)
            {
                builder.Append(row);
            }
            
            return builder.ToString();
        }

        private bool shouldWrite(int rownum, int columnnum, int totalRows)
        {
            if (totalRows < 3)
                return true;
            
            if (columnnum % (totalRows - 1) == 0)            
                return true;                

            return (rownum == (totalRows - 1 - (columnnum % (totalRows - 1))));
        }
    }
}