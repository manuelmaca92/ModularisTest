using ModularisTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Strategy
{
   internal class ContextLogger
    {
        private IStrategyLogger _Strategy;
        private LogType? _logType;
        private string _log;
        private ConfigurationLogger _config;

        public ContextLogger()
        {
        }

        public void AddLoggerStrategy(IStrategyLogger strategy)
        {
            _Strategy = strategy;

        }

        public void Log()
        {
            if (_Strategy == null)
                throw new JobLoggerNotProvidedException();
            else if (string.IsNullOrEmpty(_log))
                throw new JobLoggerMessageNullException();
            else if (_logType == null)
                throw new JobLoggerLogTypeNullException();
            else if (_config == null)
                throw new JobLoggerConfigNullException();
            this._Strategy.SaveLog(_log, _logType.Value,_config);
        }

        public void SetLogType(LogType logType)
        {
            _logType = logType;
        }

        public void setLog(string log) {

            _log = log;
        }

        public void setConfiguration(ConfigurationLogger config)
        {
            _config = config;
        }
    }
    public enum LogType
    {
        Message,
        Warning,
        Error,
    }

    public enum LogDestiny
    {
        file,
        console
    }
}
