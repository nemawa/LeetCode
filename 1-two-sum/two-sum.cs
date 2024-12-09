public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> n = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int expected = target - nums[i];
            if (n.ContainsKey(expected))
            {
                return new int[] {n[expected], i};
            }
            n[nums[i]] = i;
        }

        return null;

    }
}