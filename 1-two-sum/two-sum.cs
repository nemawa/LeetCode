public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if (nums == null || nums.Length < 2) {
            throw new ArgumentException("Invalid input");
        }

        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (dict.TryGetValue(complement, out int complementIndex)) {
                return new int[] { complementIndex, i };
            }

            if (!dict.ContainsKey(nums[i])) {
                dict[nums[i]] = i;
            }
        }

        throw new ArgumentException("No two sum solution");
    }
}
