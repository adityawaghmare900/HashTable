namespace Create_BST_UC1
{
    internal class MainBinarySearch
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree=new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
        }
    }
}