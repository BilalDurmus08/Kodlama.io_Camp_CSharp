using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_GenericsIntro
{
    internal class MyList<T>
    {
        List<T> items ;

        //ctor shortcut for Constructure !!
        public MyList()
        {
            items = new List<T>();
        }

        public void Add(T item) 
        { 
            items.Add(item);
        }
        public void Write()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        
    
    }


}
