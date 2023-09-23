using System.ComponentModel;

namespace HashTable_UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Paranoids are not paranoid because they are paranoid but because they are paranoid but because" +
                " they keep putting themselves deliberatlely into paranoid avoidable situations";
            int len = phrase.Length;
            // LinkedList<string> list = new LinkedList<string>();
            string[] list = phrase.Split(' ');
            int n = 0;
            
            MyMapNode<int, string> hash = new MyMapNode<int, string>(len);
            foreach (string s in list)
            {
                hash.Add(n, s);
                n = n + 1;
            }
            
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(i+" "+list[i]);
            }
           // foreach(string s in list)
           // {
           //     Console.WriteLine(list[n]+" "+s);
           //     n++;
                
           // }
            Console.WriteLine("======================================================");
            hash.Remove(22); 

            string hashValue = hash.Get(22);
            Console.WriteLine("5th index value: " + hashValue);
        }
    }
}