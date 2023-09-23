namespace Binary_Tree_UC3
{
    internal class MainBinaryTree
    {
        static void Main(string[] args)
        {
            MyBinaryNode<int> myBinaryNode = new MyBinaryNode<int>(56);
            myBinaryNode.Insert(30);
            myBinaryNode.Insert(70);
            myBinaryNode.Insert(22);
            myBinaryNode.Insert(40);
            myBinaryNode.Insert(60);
            myBinaryNode.Insert(95);
            myBinaryNode.Insert(11);
            myBinaryNode.Insert(65);
            myBinaryNode.Insert(3);
            myBinaryNode.Insert(16);
            myBinaryNode.Insert(63);
            myBinaryNode.Insert(67);
            myBinaryNode.Display();
            Console.WriteLine("==============================================");
            myBinaryNode.getSize();
        }
    }
}