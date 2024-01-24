using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferranceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 324;
            int number2 = 223;
            number1 = number2;
            number2 = 654;
            Console.WriteLine(number1);

            int[] numbers1 = { 123, 234, 345, 456 };
            int[] numbers2 = { 13, 24, 35, 46 };
            numbers1 = numbers2;
            numbers2[0] = 500;
            Console.WriteLine(numbers1[0]);
        
        }

    }
}
