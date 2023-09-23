using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInBinaryTree
{
    internal class MyBinaryTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public MyBinaryTree<T> leftTree { get; set; }
        public MyBinaryTree<T> RightTree { get; set; }
        public MyBinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryTree<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new MyBinaryTree<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }

        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public void getSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }

        public bool IfExist(T element, MyBinaryTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST"+" "+node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0) 
            {
                IfExist(element, node.leftTree); 
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExist(element, node.RightTree);
            }
            return result;
        }
    }
}
