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
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();

        if (root == null) return res;

        return Inorder(res, root);
    }

    public IList<int> Inorder(IList<int> res, TreeNode root)
    {
        if (root.left != null)
        {
            res = Inorder(res, root.left);
        }
        
        res.Add(root.val);
        
        if (root.right != null)
        {
            res = Inorder(res, root.right);
        }

        return res;
    }
}