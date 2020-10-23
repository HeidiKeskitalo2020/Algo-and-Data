using System;

namespace EX3
{
class Program
{
 public static void Main(string[] args)
{
    int[] pre = new int[] {4, 2, 5, 1, 3, 7};
    int[] post = new int[] {4, 5, 2, 7, 3, 1};
 
    int size = pre.Length;
    node root = constructTree(pre, post, size);
 
    Console.WriteLine("Inorder traversal of " + 
                      "the constructed tree:");
    printInorder(root);
}
}
}
 
// This code is contributed by Shrikant13