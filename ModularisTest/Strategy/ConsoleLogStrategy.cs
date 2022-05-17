using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Strategy
{
    internal class ConsoleLogStrategy : IStrategyLogger
    {
        public void SaveLog(string log, LogType logType, ConfigurationLogger configuration)
        {
            switch (logType)
            {
                case LogType.Message: 
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            Console.WriteLine(DateTime.Now.ToShortDateString() + " " + Enum.GetName(typeof(LogType), logType) + " " + log);
        }
    }
}
