using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW_Dictionary
{
    internal class Program
    {
        static void Main(string[] args) { 
            
        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(12, "A");
            myDictionary.Add(13, "B");
            myDictionary.Add(14, "C");
            myDictionary.Add(15, "D");
            myDictionary.Write();

        
        }
    
    }


}
