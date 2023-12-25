using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable.HashFunction
{
    public class SquareHashMethod : HashMethod
    {
        public int Execute(int key, int j) 
        {
            var hv = Math.Abs(key) % 10000;
            return (hv + j * j) % 10000;
        }
    }
}
