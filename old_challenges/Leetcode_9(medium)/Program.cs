using System;

namespace Leetcode_9_medium_
{
    class Program
    {
        static void Main(string[] args)
        {
        }


    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            var node = root;
            while (true)
            {
                if (node.val < val)
                {
                    if (node.right == null)
                    {
                        node.right = new TreeNode(val);
                        return root;
                    }
                    else node = node.right;
                }
                else if (node.val > val)
                {
                    if (node.left == null)
                    {
                        node.left = new TreeNode(val);
                        return root;
                    }
                    else node = node.left;
                }

            }
        }
    }

}
