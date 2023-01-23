using System.Security.Cryptography;
using System.Text;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger baseLogger, string message, params object[] objects)
        {
            if(baseLogger == null)
            {
                throw new System.ArgumentNullException(nameof(baseLogger));
            }
            if(objects != null)
            {
                StringBuilder sb = new StringBuilder(message);
                for (int i = 0; i < objects.Length; i++)
                {
                    sb.Replace("{" + i + "}", objects[i].ToString());
                }
                baseLogger.Log(LogLevel.Error, sb.ToString());
            }
            else
            {
                baseLogger.Log(LogLevel.Error, message);
            }
        }
        public static void Warning(this BaseLogger baseLogger, string message, params object[] objects)
        {
            if (baseLogger == null)
            {
                throw new System.ArgumentNullException(nameof(baseLogger));
            }
            if (objects != null)
            {
                StringBuilder sb = new StringBuilder(message);
                for (int i = 0; i < objects.Length; i++)
                {
                    sb.Replace("{" + i + "}", objects[i].ToString());
                }
                baseLogger.Log(LogLevel.Error, sb.ToString());
            }
            baseLogger.Log(LogLevel.Warning, message);
        }
        public static void Information(this BaseLogger baseLogger, string message, params object[] objects)
        {
            if (baseLogger == null)
            {
                throw new System.ArgumentNullException(nameof(baseLogger));
            }
            if (objects != null)
            {
                StringBuilder sb = new StringBuilder(message);
                for (int i = 0; i < objects.Length; i++)
                {
                    sb.Replace("{" + i + "}", objects[i].ToString());
                }
                baseLogger.Log(LogLevel.Error, sb.ToString());
            }
            baseLogger.Log(LogLevel.Information, message);
        }
        public static void Debug(this BaseLogger baseLogger, string message, params object[] objects) 
        {
            if (baseLogger == null)
            {
                throw new System.ArgumentNullException(nameof(baseLogger));
            }
            if (objects != null)
            {
                StringBuilder sb = new StringBuilder(message);
                for (int i = 0; i < objects.Length; i++)
                {
                    sb.Replace("{" + i + "}", objects[i].ToString());
                }
                baseLogger.Log(LogLevel.Error, sb.ToString());
            }
            baseLogger.Log(LogLevel.Debug, message);
        }
    }
}
