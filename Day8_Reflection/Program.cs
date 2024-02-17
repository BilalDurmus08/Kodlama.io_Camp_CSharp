using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Reflection
{       //Reflection create object in running time.
    public class Program
    { 
        static void Main(string[] args)
        {
           // Four_Operators four_Operators = new Four_Operators(5, 8);
           // Console.WriteLine(four_Operators.Add());

            var type = typeof(Four_Operators);
            Four_Operators four_Operators1 = Activator.CreateInstance(type, 5, 9) as Four_Operators;
            Console.WriteLine(four_Operators1.Add());
            Console.WriteLine(four_Operators1.Add(99,22));

        }

    }

    public class Four_Operators
    {
        int _number1;
        int _number2;
        public Four_Operators(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Add()
        {
            return _number1 + _number2;
        }

        public int Subtract(int number1, int number2)
        { 
            return number1 - number2; 
        }
        
        public int Multiply(int number1, int number2)
        {
            return (number1 * number2);
        }

        public int Divide(int number1, int number2)
        {
            return (number1 / number2);
        }


    }

}
