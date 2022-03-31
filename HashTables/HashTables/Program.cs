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
            bst.Display();
        }
    }
}
