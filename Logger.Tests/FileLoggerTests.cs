using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void FileLogger_WritesToFile()
        {
            //Arrange
            string className = nameof(FileLoggerTests);
            string fileName = Path.GetTempFileName();
            FileLogger fileLogger = new FileLogger(fileName) { ClassName = className};

            // Act
            fileLogger.Log(LogLevel.Debug, "I am debugingggggg mom");
            fileLogger.Log(LogLevel.Warning, "It's not a phase mom!");

            //Assert
            string[] content = File.ReadAllLines(fileName);
            Assert.IsTrue(content.Length == 2);
            Assert.IsTrue(content[0].Contains("I am debugingggggg mom"));
            Assert.IsTrue(content[0].Contains(className));
            Assert.IsTrue(content[0].Contains("Debug: "));
            Assert.IsTrue(content[1].Contains("It's not a phase mom!"));
            Assert.IsTrue(content[1].Contains(className));
            Assert.IsTrue(content[1].Contains("Warning: "));
        }
    }
}
