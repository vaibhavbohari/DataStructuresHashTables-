using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAndBinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public T Nodedata { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T Nodedata)
        {
            this.Nodedata = Nodedata;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int LeftCount = 0;
        int RightCount = 0;
        public void Insert(T Value)
        {
            T Root = this.Nodedata;
            if (Root.CompareTo(Value) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(Value);
                }
                else
                {
                    this.LeftTree.Insert(Value);
                }
                LeftCount += 1;
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree<T>(Value);
                }
                else
                {
                    this.RightTree.Insert(Value);
                }
                RightCount += 1;
            }
        }
        public void Getsize()
        {
            Console.WriteLine("Binary Tree Size:" + (RightCount + LeftCount + 1));
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.Display();
            }
            Console.WriteLine(this.Nodedata.ToString());
            if (this.RightTree != null)
            {
                this.RightTree.Display();
            }
        }
        public bool Search(T element, BinarySearchTree<T> node)
        {
            bool result = false;
            if (node == null)
            {
                return false;
            }
            if (node.Nodedata.Equals(element))
            {
                Console.WriteLine("Founded Node is :" + node.Nodedata);
                result = true;
            }
            else
            {
                Console.WriteLine("Current Node is :" + node.Nodedata);
            }
            if (element.CompareTo(node.Nodedata) < 0)
            {
                Search(element, node.LeftTree);
            }
            if (element.CompareTo(node.Nodedata) > 0)
            {
                Search(element, node.RightTree);
            }
            return result;
        }
    }
}


