using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.hashtable
{
    public class Hashtable
    {
        public List<Dictionary<int, int>> hashTable;
        public bool checkPrime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public int getPrime(int n)
        {
            if (n % 2 == 0) n = n + 1;

            while (!checkPrime(n)) n += 2;
            return n;

        }
        public int hashFunction(int key)
        {
            int capacity = getPrime(10);
            return key % capacity;
        }
        public void set(int key , int value)
        {
            int index = hashFunction(key);
            hashTable[index].Add(key,value);
        }
        public int get(int key)
        {
            int index = hashFunction(key);
            int value;
            hashTable[index].TryGetValue(key,out value);
            return value;
        }
        public bool contains(int key)
        {
            int index = hashFunction(key);
            return hashTable[index].ContainsKey(key);
        }
        public List<int> keys()
        {
            List<int> list = new List<int>();
            foreach( Dictionary<int,int> dic in hashTable)
            {
                foreach(int key in dic.Keys) list.Add(key);
            }
            return list;
        }

    }
}
