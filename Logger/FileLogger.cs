using System;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private string _fileName;
        public string FileName { get => _fileName; set => _fileName = value ?? throw new ArgumentNullException(value); }

        public FileLogger(string fileName) {
            FileName = fileName;
        }
        public override void Log(LogLevel logLevel, string message)
        {
            using (StreamWriter sw = System.IO.File.AppendText(@FileName))
            {
                sw.WriteLine($"{DateTime.Now} {ClassName} {logLevel}: {message}");
            }
        }
    }
}
