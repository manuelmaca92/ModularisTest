using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Strategy
{
    internal class DBLogStrategy : IStrategyLogger
    {
        public void SaveLog(string log, LogType logType, ConfigurationLogger configuration)
        {
            throw new NotImplementedException();
        }
    }
}
