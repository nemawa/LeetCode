public class Solution {
    public int MaxProfit(int[] prices) {
    int profit = 0;
            int res = 0;
            int min = 32000000;
            int max = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
               
                }
                else
                {
                    if (prices[i] - min > res)
                        res = prices[i] - min;
                }


            }
           // if (min == res) return 0;
            return res;
    }
}