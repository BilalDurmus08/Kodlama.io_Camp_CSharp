using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP3
{
    internal class Program   //If the method name is same but method function is different use interface
    {
        static void Main(string[] args)
        {
            ICreditManager carCreditManager = new CarCreditManager();
            ICreditManager needingCreditManager = new NeedingCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();

            //With this instance we can easly caal calculate method without any error and without repeating ourself.
            //Use interface. Public service announcement !!!!!
            ApplyManager applyManager = new ApplyManager();
            ILoggerService databaseLogger = new DatabaseLoggerService();
                                                      //We can create and use for once inside of this block.  
            applyManager.DoingApply(carCreditManager, new FileLoggerService());
            Console.WriteLine("****************");

            List<ICreditManager> credits = new List<ICreditManager>();
            credits.Add(needingCreditManager);
            credits.Add(houseCreditManager);
            credits.Add(carCreditManager);

            applyManager.bringInformation(credits);

        }

    }

}
