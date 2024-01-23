using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type Safety
            string message = "kategory";
            Console.WriteLine(message);
            //Do not repeat Yourself

            int studentNumber = 123;
            double faizRate = 1.45;
            bool isLogin = false;

            if (isLogin)
            {
                Console.WriteLine("Logged");
            }
            else
            {
                Console.WriteLine("Couldn't Logged");
            }
            double dolarYesterday = 10.5;
            double dolarToday = 11;
            if (dolarYesterday < dolarToday)
            {
                Console.WriteLine("Dolar increased");
            }
            else
            {
                Console.WriteLine("Dolar decreased");
            }



        }


    }

}
