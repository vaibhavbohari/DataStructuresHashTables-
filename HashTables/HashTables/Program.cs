using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAndBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(45);
            bst.Insert(85);
            bst.Insert(77);
            bst.Insert(63);
            bst.Insert(25);
            bst.Insert(64);
            bst.Display();
            bst.Getsize();
            Console.WriteLine("------------------------");
            bst.Search(63, bst);
        }
    }
}
