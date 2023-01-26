using System;

namespace Logger
{
    public class LogFactory
    {
        private string? _fileName;
        public BaseLogger? CreateLogger(string className)
        {
            if(string.IsNullOrEmpty(_fileName))
            {
                return null;
            }
            else
            {
                FileLogger fl = new FileLogger(_fileName) { ClassName = className};
                return fl;
            }
        }
        public void ConfigureFileLogger(string fileName)
        {
            _fileName = fileName;
        }
    }
}
