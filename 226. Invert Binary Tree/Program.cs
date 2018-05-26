using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226.Invert_Binary_Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (null== root)
            {
                return null;
            }
            return DFS(root);
        }
        private TreeNode DFS(TreeNode node)
        {
            if (null != node.right)
            {
                DFS(node.right);
            }
            if (null != node.left)
            {
                DFS(node.left);
            }
            TreeNode tmp = node.left;
            node.left = node.right;
            node.right = tmp;
            return node;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
