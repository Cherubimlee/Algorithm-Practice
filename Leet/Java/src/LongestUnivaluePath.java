/**
 * LongestUnivaluePath
 */
public class LongestUnivaluePath {

    public int longestChain = 0;

    public int longestUnivaluePath(TreeNode root) {
        longestUnivaluePath2(root);
        return longestChain;
    }

    public int longestUnivaluePath2(TreeNode root) {
        
        if(root == null)
            return 0;

        int leftPath =  longestUnivaluePath2(root.left);
        int rightPath = longestUnivaluePath2(root.right);

        if(root.left != null)
            if(root.val == root.left.val)
                leftPath += 1;
            else
                leftPath = 0;
        
        if(root.right != null)
            if(root.val == root.right.val)
                rightPath += 1;
            else
                rightPath = 0;

        if(root.left != null && root.right != null && root.val == root.left.val && root.val == root.right.val)
        {
            int crossNodePath =  rightPath + leftPath;

            longestChain = Math.max(crossNodePath, longestChain);
        }

        int r = Math.max(leftPath, rightPath);

        longestChain = Math.max(longestChain,r);

        return r;
    }
   
}