public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n <= 0 ) return false;
        if (n == 1) return true;

        int res = 1;
        while (res < n)
        {
            try{
                checked
                {
                    res *= 3;
                }
            }
            catch (OverflowException e)
            {
                return false;
            }
            if (res == n) return true;
        }
        return false;
    }
}