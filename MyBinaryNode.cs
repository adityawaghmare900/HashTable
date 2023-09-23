using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_UC3
{
    internal class MyBinaryNode<T> where T: IComparable<T>
    {
        public T NodeData { get; set; } 
        public MyBinaryNode<T> leftTree {  get; set; }
        public MyBinaryNode<T> RightTree { get; set; }    
        public MyBinaryNode(T nodeData)
        {
            this.NodeData= nodeData;
            this.leftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0, rightCount = 0;
        bool result=false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryNode<T>(item);
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
                    this.RightTree = new MyBinaryNode<T>(item);
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
            if(this.RightTree!= null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public void getSize()
        {
            Console.WriteLine("Size"+" "+(1+this.leftCount+this.rightCount));
        }
    }
}
