namespace leetcode
{

public partial class Solution {
    public int RomanToInt(string s) {
       var chars = s.ToCharArray();
       int acc = 0;
       for (int i = chars.Length - 1; i >= 0; i--)
       {
           switch (chars[i])
           {
                case 'I':
                    if (acc < 3)
                        acc++;
                    else
                        acc--;
                    break;

                case 'V':
                    acc += 5;
                    break;
                
                case 'X':
                    if (acc < 40)
                        acc += 10;
                    else
                        acc -= 10;
                        break;   

                case 'L':
                    acc += 50;
                    break;    

                case 'C':
                    if (acc < 500)
                        acc += 100;
                    else
                        acc -= 100;
                        break; 

                case 'D':
                    acc += 500;
                    break; 

                case 'M':
                    acc += 1000;
                    break;                     

           }
       }
       return acc;
    }
}
}