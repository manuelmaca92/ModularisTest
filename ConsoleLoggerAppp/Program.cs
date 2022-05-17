using Microsoft.Extensions.Configuration;
using System.IO;
using ModularisTest.Strategy;

namespace ConsoleLoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            var ConfigurationLogger = config.GetSection("ConfigurationLogger").Get<ModularisTest.ConfigurationLogger>();

            ModularisTest.JobLogger.LogMessage("message test", LogType.Error, LogDestiny.file, ConfigurationLogger);
            ModularisTest.JobLogger.LogMessage("message test", LogType.Error, LogDestiny.console, ConfigurationLogger);


            System.Console.ReadKey();
            
        }

    }
}

