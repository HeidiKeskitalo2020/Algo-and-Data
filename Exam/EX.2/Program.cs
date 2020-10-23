 using System;

 namespace EX2
 {
     class Program
     {
         public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(6);
            tree.root.left = new Node(1);
            tree.root.right = new Node(5);
            tree.root.left.right = new Node(2);
            tree.root.right.right = new Node(4);
            tree.root.right.left = new Node(3);
    
            // Function call
            Console.WriteLine("Maximum element is "
                            + BinaryTree.findMax(tree.root));
        }
    }
 
} 
    
 
