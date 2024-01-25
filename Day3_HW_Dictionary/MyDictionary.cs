using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW_Dictionary
{
    internal class MyDictionary <T, K>
    {
        T[] items;
        K[] keys;
        public MyDictionary()
        {
            items = new T[0];
            keys = new K[0];
        }

      public void Add(T item, K key2)
        {
            T[] temp = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }
            items[temp.Length] = item;

            K[] temp2 = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < temp2.Length; i++)
            {
                keys[i] = temp2[i];
            }
            keys[temp.Length] = key2;




        }
        public void Write() {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("keys: " + keys[i] + " items: " + items[i]);
            }
        
        }


    
    }


}
