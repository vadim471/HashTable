using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.HashFunction
{ 
    public class LinearHashMethod : HashMethod
    {
        public int Execute(int key, int j)
        {
            key = Math.Abs(key);
            return (key + j) % 10000;
        }
    }
}
