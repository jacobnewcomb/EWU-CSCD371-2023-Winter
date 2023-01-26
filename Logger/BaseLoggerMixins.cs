using System.Security.Cryptography;
using System.Text;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger baseLogger, string message, params object[] args)
        {
            if(baseLogger == null)
            {
                throw new System.ArgumentNullException(nameof(baseLogger));
            }
            if(args != null)
            {
                baseLogger.Log(LogLevel.Error, string.Format(new System.Globalization.CultureInfo("en-US"), message, args));
            }
            else
            {
                baseLogger.Log(LogLevel.Error, message);
            }
        }
        public static void Warning(this BaseLogger baseLogger, string message, params object[] args)
        {
            if (baseLogger == null)
            {
                throw new System.ArgumentNullException(nameof(baseLogger));
            }
            if (args != null)
            {
                baseLogger.Log(LogLevel.Warning, string.Format(new System.Globalization.CultureInfo("en-US"), message, args));
            }
            else
            {
                baseLogger.Log(LogLevel.Warning, message);
            }
        }
        public static void Information(this BaseLogger baseLogger, string message, params object[] args)
        {
            if (baseLogger == null)
            {
                throw new System.ArgumentNullException(nameof(baseLogger));
            }
            if (args != null)
            {
                baseLogger.Log(LogLevel.Information, string.Format(new System.Globalization.CultureInfo("en-US"), message, args));
            }
            else
            {
                baseLogger.Log(LogLevel.Information, message);
            }
        }
        public static void Debug(this BaseLogger baseLogger, string message, params object[] args) 
        {
            if (baseLogger == null)
            {
                throw new System.ArgumentNullException(nameof(baseLogger));
            }
            if (args != null)
            {
                baseLogger.Log(LogLevel.Debug, string.Format(new System.Globalization.CultureInfo("en-US"), message, args));
            }
            else
            {
                baseLogger.Log(LogLevel.Debug, message);
            }
        }
    }
}
