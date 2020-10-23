using System; 
namespace EX2
{
/* A binary tree node has data, pointer  
to left child and a pointer to right child */
    public class Node {
    public int data;
    public Node left, right;
 
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
 
public class BinaryTree {
    public Node root;
 
    // Returns the max value in a binary tree
    public static int findMax(Node node)
    {
        if (node == null) {
            return int.MinValue;
        }
 
        int res = node.data;
        int lres = findMax(node.left);
        int rres = findMax(node.right);
 
        if (lres > res) {
            res = lres;
        }
        if (rres > res) {
            res = rres;
        }
        return res;
    }
    }
    
}
