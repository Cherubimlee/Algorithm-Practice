import sun.security.provider.DSAKeyFactory;

/**
 * AddOneRow
 */
public class AddOneRow {


    public TreeNode addOneRow(TreeNode root, int v, int d) {
        
        if(d <= 1)
        {
            TreeNode node = new TreeNode(v);

            node.left = root;
            return node;
        }

        dfs(root,2,d,v);

        return root;
        
    }
    
    public void dfs(TreeNode node, int currentDeep, int expectedDeep, int v){

        if(currentDeep > expectedDeep)
            return;

        if(currentDeep < expectedDeep)
        {
            if(node.left != null)
                dfs(node.left, currentDeep+1, expectedDeep, v);

            if(node.right != null)
                dfs(node.right, currentDeep+1,expectedDeep,v);
            
            return;
        }

      
        
        if(node.left != null)
        {
            TreeNode newLeft = new TreeNode(v);
            newLeft.left = node.left;
            node.left = newLeft;         
        }
        else
        {
            node.left =  new TreeNode(v);
        }

        if(node.right != null)
        {
            TreeNode newRight = new TreeNode(v);
            newRight.right = node.right;
            node.right = newRight;
        }else
        {
            node.right = new TreeNode(v);
        }
        

    }

}