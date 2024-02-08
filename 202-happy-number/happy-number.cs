public class Solution {
    public bool IsHappy(int n) {
            HashSet<int> visited = new HashSet<int>();
            int res = 0;
            while (n > 1)
            {
                while (n > 0)
                {
                    res = res + ((n % 10) * (n % 10));
                    n = n / 10;

                }
                if (visited.Contains(res)) return false;
                visited.Add(res);
                n = res;
                res = 0;
            }
            return true;
    }
}