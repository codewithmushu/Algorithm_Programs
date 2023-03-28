using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
     class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            //binaryTree.Add(50);
            //binaryTree.Add(20);
            //binaryTree.Add(30);
            //binaryTree.Add(15);
            //binaryTree.Add(60);
            //binaryTree.Add(80);


            binaryTree.TravarsePreorder(binaryTree.Root);

            //InsertionSort sort = new InsertionSort();

            //sort.DisplayInsertion();
        }
    }
}
