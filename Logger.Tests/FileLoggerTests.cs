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
            string className = "I should work!";
            string fileName = "test.txt";
            File.Delete(fileName);
            FileLogger fileLogger = new FileLogger(className, fileName);

            // Act
            fileLogger.Log(LogLevel.Debug, "I am debugingggggg mom");
            fileLogger.Log(LogLevel.Warning, "It's not a phase mom!");

            //Assert
            string[] content = File.ReadAllLines(fileName);
            Assert.IsTrue(content.Length == 2);
            Assert.IsTrue(content[0].Contains("I am debugingggggg mom"));
            Assert.IsTrue(content[0].Contains("I should work!"));
            Assert.IsTrue(content[0].Contains("Debug: "));
            Assert.IsTrue(content[1].Contains("It's not a phase mom!"));
            Assert.IsTrue(content[1].Contains("I should work!"));
            Assert.IsTrue(content[1].Contains("Warning: "));
        }
    }
}
