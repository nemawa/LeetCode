public class Solution {
    public string ThousandSeparator(int n) {
       string res = "";
       if (n == 0) return "0";
       while (n > 0) 
       {
           if (n > 1000)
           {
         
               res = "." + (n % 1000).ToString().PadLeft (3, '0') + res;
               
               n = n / 1000;
           }
           else
           {
               res = n.ToString() + res;
               return res;
           }
       }
       return res;
    }
}