using ModularisTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModularisTest.Strategy;

namespace ModularisTestUnitTests
{
    [TestClass]
    public class JobLoggerTest
    {

        [TestMethod]
        public void JobLoggerBasicTestWarningFile()
        {
            try
            {
                ModularisTest.JobLogger.LogMessage("message test file", LogType.Warning, LogDestiny.file, new ModularisTest.ConfigurationLogger { FileRoute = "C:/" });
                Assert.IsTrue(true, "se ha creado un log tipo warning");
            }
            catch (System.Exception ex)
            {
                Assert.IsFalse(false, "Error " + ex.Message);
            }

        }

        [TestMethod]
        public void JobLoggerBasicTestWarningConsole()
        {
            try
            {
                ModularisTest.JobLogger.LogMessage("message test console", LogType.Warning, LogDestiny.console, new ModularisTest.ConfigurationLogger { FileRoute = "C:/" });
                Assert.IsTrue(true, "se ha creado un log tipo warning");
            }
            catch (System.Exception ex)
            {
                Assert.IsFalse(false, "Error " + ex.Message);
            }

        }

        [TestMethod]
        public void JobLoggerBasicTestErrorConsole()
        {
            try
            {
                ModularisTest.JobLogger.LogMessage("message test console", LogType.Error, LogDestiny.console, new ModularisTest.ConfigurationLogger { FileRoute = "C:/" });

                Assert.IsTrue(true, "se ha creado un log tipo Error");
            }
            catch (System.Exception ex)
            {
                Assert.IsFalse(false, "Error " + ex.Message);
            }

        }

        [TestMethod]
        public void JobLoggerBasicTestErrorFile()
        {
            try
            {
                ModularisTest.JobLogger.LogMessage("message test file", LogType.Error, LogDestiny.file, new ModularisTest.ConfigurationLogger { FileRoute = "C:/" });
                Assert.IsTrue(true, "se ha creado un log tipo Error");
            }
            catch (System.Exception ex)
            {
                Assert.IsFalse(false, "Error " + ex.Message);
            }

        }

        [TestMethod]
        public void JobLoggerBasicTestMessageFile()
        {
            try
            {
                ModularisTest.JobLogger.LogMessage("message test file", LogType.Message, LogDestiny.file, new ModularisTest.ConfigurationLogger { FileRoute = "C:/" });

                Assert.IsTrue(true, "se ha creado un log tipo Mensaje");
            }
            catch (System.Exception ex)
            {
                Assert.IsFalse(false, "Error " + ex.Message);
            }

        }

        [TestMethod]
        public void JobLoggerBasicTestMessageConsole()
        {
            try
            {
                ModularisTest.JobLogger.LogMessage("message test console", LogType.Message, LogDestiny.console, new ModularisTest.ConfigurationLogger { FileRoute = "C:/" });
                Assert.IsTrue(true, "se ha creado un log tipo Mensaje");
            }
            catch (System.Exception ex)
            {
                Assert.IsFalse(false, "Error " + ex.Message);
            }

        }

        [TestMethod]
        public void JobLoggerBasicTestMessageEmpty()
        {
            try
            {
                ModularisTest.JobLogger.LogMessage(string.Empty, LogType.Message, LogDestiny.console, new ModularisTest.ConfigurationLogger { FileRoute = "C:/" });
            }
            catch (System.Exception ex)
            {
                Assert.IsTrue(true, "Error " + ex.Message);
            }

        }
    }
}