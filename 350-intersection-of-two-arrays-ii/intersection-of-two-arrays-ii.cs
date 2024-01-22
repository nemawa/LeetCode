public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
    
        List<int> res = new List<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            for(int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    res.Add(nums1[i]);
                    nums1[i] = -1;
                    nums2[j] = -1;
                    break;
                }
            }
        }
        return res.ToArray();
    
    return res.ToArray();
    }
}