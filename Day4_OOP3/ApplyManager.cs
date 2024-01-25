using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP3
{
    internal class ApplyManager
    {
        public void DoingApply(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.calculate();
            loggerService.Log();
        }

        public void bringInformation(List<ICreditManager> credits)
        {
            foreach (ICreditManager creditManager in credits)
            {
                creditManager.calculate();   
            }
        }


    }
   
}



