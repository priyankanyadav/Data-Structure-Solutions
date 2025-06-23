//BINARY TREE LEVEL ORDER TRAVERSAAL
//Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
       //If the tree is empty (root is null), return an empty list
        var result =  new List<IList<int>>();

        if(root == null) return result;
        //use a queue to process nodes level by level.(BFS)
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            int levelSize = queue.Count;

            //Create a list to store the values of nodes at the current level.
            List<int> currentLevel = new List<int>();
            for (int i = 0; i < levelSize; i++) {
                TreeNode currentNode = queue.Dequeue();
                currentLevel.Add(currentNode.val);

                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }

            result.Add(currentLevel);
        }

        return result;
    }
        
    }
