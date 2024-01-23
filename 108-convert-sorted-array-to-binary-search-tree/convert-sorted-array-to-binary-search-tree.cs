/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
       
        TreeNode res = new TreeNode();
        res = sArrToBST(nums, 0, nums.Length - 1);

        return res;
    }

    public TreeNode sArrToBST (int[] arr, int s, int e)
    {
        if (s > e) return null;

        int pola = (s + e) / 2;
        TreeNode res = new TreeNode(arr[pola]);

        res.left = sArrToBST (arr, s, pola - 1);
        res.right = sArrToBST (arr, pola + 1, e);

        return res;
    }
}