using System.Collections.Generic;

public class Solution {

    private Dictionary<int, int> res = new Dictionary<int,int>();

    public int ClimbStairs(int n) {
            int result = 0;
        
            if (res.ContainsKey(n)) return res[n];
            if (n == 3) return 3;
            
            if (n == 2) return 2;
            if (n == 1) return 1;

            result =  ClimbStairs(n-1) + ClimbStairs(n-2);
            res[n] = result;
            return result;

            
    }
}