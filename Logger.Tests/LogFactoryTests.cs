using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void LogFactory_WithNullEmptyFileName_ReturnsNullLogger()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();

            // Act
            logFactory.ConfigureFileLogger(null);
            var fileLogger1 = logFactory.CreateLogger("I shouldn't exist!");
            logFactory.ConfigureFileLogger("");
            var fileLogger2 = logFactory.CreateLogger("Me neither!");

            //Assert
            Assert.IsNull(fileLogger1);
            Assert.IsNull(fileLogger2);
        }
        [TestMethod]
        public void LogFactory_WithFileName_ReturnsCorrectLogger() 
        {
            // Arrange
            LogFactory logFactory = new LogFactory();

            // Act
            logFactory.ConfigureFileLogger("file.txt");
            var fileLogger = logFactory.CreateLogger(nameof(LogFactoryTests));
            fileLogger = (FileLogger)fileLogger;

            //Assert
            Assert.IsNotNull(fileLogger);
            Assert.IsTrue(fileLogger is FileLogger);
        }
    }
}
