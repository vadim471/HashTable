using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HashTable
{
    public class HashTable
    {
        public KeyValuePair?[] items;
        public int size = 10000;
        public HashMethod hashMethod;

        public HashTable(HashMethod method) 
        {
            hashMethod = method;
            items = new KeyValuePair[size];
        }

        public void Add(int key, int value)
        {
            int index = hashMethod.Execute(key, 0);
            int j = 0;

            if (items[index]?.Key == key)
            {
                return;
            }

            while (items[index] != null)
            {
                index = hashMethod.Execute(index, j++);
            }

            items[index] = new KeyValuePair(key, value);
        }
        public void Remove(int key)
        {
            int index = hashMethod.Execute(key, 0);
            int j = 0;

            while (items[index] != null)
            {
                if (items[index]?.Key == key)
                {
                    items[index] = null;
                    return;
                }

                index = hashMethod.Execute(index, j++);
            }
        }
        public void Print()
        {
            foreach (var item in items)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }
            }
        }
        public int? Get(int key)
        {
            int index = hashMethod.Execute(key, 0);
            int j = 0;

            while (items[index] != null)
            {
                if (items[index]?.Key == key)
                {
                    return items[index]?.Value;
                }
                index = hashMethod.Execute(index, j++);
            }
            return null;
        }
    }
}
