namespace HashTable_UC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Paranoids are not paranoid because they are paranod but because they keep putting themselves" +
                " deliberately into paranoid avoidable situations";
            int len=phrase.Length;
           // LinkedList<string> list = new LinkedList<string>();
            string []list= phrase.Split(' ');
            int n = 0; ;
            MyMapNode<int, String> hash = new MyMapNode<int, string>(len);
            foreach (string s in list)
            {
                hash.Add(n, s);
                n = n + 1;
            }
            string hash5 = hash.Get(5);
            Console.WriteLine("5th index value: " + hash5);
        }
    }
}