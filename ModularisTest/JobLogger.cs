using ModularisTest.Exceptions;
using System;
using System.Configuration;
using System.IO;
using ModularisTest.Strategy;

namespace ModularisTest
{
    public static class JobLogger
    {
        public static void LogMessage(string message, LogType logType, LogDestiny destiny, ConfigurationLogger configurationLogger)
        {
            var logger = new ContextLogger();

            logger.setConfiguration(configurationLogger);
            logger.SetLogType(logType);
            logger.setLog(message);

            switch (destiny)
            {
                case LogDestiny.console:
                    logger.AddLoggerStrategy(new ConsoleLogStrategy());
                    break;
                case LogDestiny.file:
                    logger.AddLoggerStrategy(new FileLogStrategy());
                    break;

                    //add new strategy
            }

            logger.Log();
        }
    }
}