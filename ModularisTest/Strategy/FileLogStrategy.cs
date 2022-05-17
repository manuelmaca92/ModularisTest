using ModularisTest.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Strategy
{
   internal class FileLogStrategy : IStrategyLogger
    {
        public void SaveLog(string log, LogType logType, ConfigurationLogger configuration)
        {
            try
            {
                string LogLine = string.Empty;
                var logFolder = configuration.FileRoute;
                if (string.IsNullOrEmpty(logFolder)) logFolder = Environment.CurrentDirectory;
                var logFileName = "LogFile" + DateTime.Now.ToShortDateString().Replace("/", ".") + ".txt";
                var logFullFilePath = Path.Combine(logFolder, logFileName);

                if (File.Exists(logFullFilePath)) LogLine = File.ReadAllText(logFullFilePath);

                LogLine = LogLine + DateTime.Now.ToShortDateString() + " " + Enum.GetName(typeof(LogType), logType) + " " + log + Environment.NewLine;

                if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder);

                System.IO.File.WriteAllText(logFullFilePath, LogLine);
            }
            catch (Exception)
            {

                throw new JobLoggerConfigBadFolderException();
            }
            
        }
    }
}
