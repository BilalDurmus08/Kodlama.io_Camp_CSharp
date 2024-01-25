using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP3
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }

    }


}
