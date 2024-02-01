public class Solution {
    public int AddDigits(int num) {
        //HashSet<int> hs = new HashSet<int>();

        int res = 0;

        while (num > 9)
        {
            int tmp = 0;
            while (num > 0)
            {
                tmp = tmp + num % 10;
                num = num / 10;

            }
            
            num = tmp;
            
        }
        return num;

    }
}