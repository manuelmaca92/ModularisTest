using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Strategy
{
   internal interface IStrategyLogger
    {
        void SaveLog(string log, LogType logType, ConfigurationLogger config);
    }
}
