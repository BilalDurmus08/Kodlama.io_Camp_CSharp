using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Delegates
{   //With delegate we can add void methods, and we can run them by order
    public delegate void MyDelegate();
    //or:
    public delegate int MyDelegate2(int number1, int number2);
    public class Program
    {
       static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.GiveAllert;

            myDelegate -= customerManager.SendMessage;
            myDelegate(); 

            Math1 math1 = new Math1();
            MyDelegate2 myDelegate2 = math1.Add;
            var value = myDelegate2(45,88);
            Console.WriteLine(value);
        }


    }

    public class CustomerManager()
    {
        public void SendMessage()
        {
            Console.WriteLine("Hellooo");
        }

        public void GiveAllert()
        {
            Console.WriteLine("Allert!!");
        }

    }

    public class Math1()
    {
        public int Add(int number, int number2)
        {
            return number + number2;
        }


    }



}
