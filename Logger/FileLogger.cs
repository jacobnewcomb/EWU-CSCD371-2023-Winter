using System;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private string className;
        public string ClassName { get => className; set => className = value;}
        public string fileName { get; set; }
        public FileLogger(string className, string fileName) {
            this.className = className;
            this.fileName = fileName;
        }
        public override void Log(LogLevel logLevel, string message)
        {
            using (StreamWriter sw = System.IO.File.AppendText(@fileName))
            {
                sw.WriteLine(DateTime.Now + " " + ClassName + " " + logLevel +" " + message);
            }
            throw new System.NotImplementedException();
        }
    }
}
