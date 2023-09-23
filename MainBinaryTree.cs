namespace SearchInBinaryTree
{
    internal class MainBinaryTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyBinaryTree<int> myBinaryNode = new MyBinaryTree<int>(56);
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
           // myBinaryNode.getSize();

            bool result = myBinaryNode.IfExist(67, myBinaryNode);
            Console.WriteLine(result);
        }
    }
}