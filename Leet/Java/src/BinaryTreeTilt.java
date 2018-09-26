import java.awt.image.TileObserver;

/**
 * BinaryTreeTilt
 */
public class BinaryTreeTilt {

    int tilt = 0;

    public int findTilt(TreeNode root) {
        
        this.tilt = 0;
        findNodeSum(root);
        return this.tilt;

    }


    public int findNodeSum(TreeNode root)
    {
        if(root == null)
        return 0;

        if(root.left == null && root.right == null)
          return root.val;

        int leftSum = 0, rightSum = 0;

        if(root.left != null)
        {
            leftSum = findNodeSum(root.left);
        }

        if(root.right != null)
        {
            rightSum = findNodeSum(root.right);
        }

        int tilt = Math.abs(leftSum-rightSum);
        
        this.tilt += tilt;

        return leftSum + rightSum + root.val;
    }

   
}