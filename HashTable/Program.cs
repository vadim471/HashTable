using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashTable.HashFunction;
namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //HashTable hashTable = new HashTable(new LinearHashMethod());
            HashTable hashTable = new HashTable(new SquareHashMethod());
            hashTable.Add(2, 25);
            hashTable.Add(4, 35);
            hashTable.Print();
            Console.WriteLine("\n");
            hashTable.Remove(2);
            hashTable.Print();
            Console.WriteLine(hashTable.Get(4));
            
            
        }
    }
}
