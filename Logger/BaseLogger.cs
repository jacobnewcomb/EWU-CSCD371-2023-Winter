using System;

namespace Logger
{
    public abstract class BaseLogger
    {
        private string? _className;
        public string ClassName { get => _className; set => _className = value; }
        public abstract void Log(LogLevel logLevel, string message);
    }
}
