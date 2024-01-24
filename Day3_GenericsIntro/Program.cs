using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> Names = new MyList<string>();
            Names.Add("A");
            Names.Add("B");

            MyList<int> Numbers = new MyList<int>();
            Numbers.Add(1);
            Numbers.Add(2);



        }

    }


}
