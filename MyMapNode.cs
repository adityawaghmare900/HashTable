using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_UC3
{
    public class MyMapNode<K, V>
    {
        //declaring variables
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        //declaring constructor
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }


        //structure of key value using get set properties
        public struct KeyValue<K, V>
        {
            public K key { get; set; }
            public V value { get; set; }
        }

        protected int GetArrayPosition(K key)
        {
            //for findingg position use by hashcode()% size of array
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {

            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }


        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        //to get frequency
        public void GetFrequency(V value)
        {
            //initialyy we are defining our frequency as zero
            int frequency = 0;

            // using foreach loop to get the value in linkedList
            foreach (LinkedList<KeyValue<K, V>> list in items)
            {
                if (list == null)
                    continue;
                foreach (KeyValue<K, V> check in list)
                {
                    if (check.Equals(null))
                    {
                        continue;
                    }
                    if (check.value.Equals(value))
                    {
                        frequency++;
                    }
                }
            }
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedlist.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedlist.Remove(foundItem);
            }
        }
    }
}
