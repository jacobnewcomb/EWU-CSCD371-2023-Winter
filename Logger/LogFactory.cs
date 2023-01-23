namespace Logger
{
    public class LogFactory
    {
        private string? fileName;
        public string FileName { get => fileName; set => fileName = value; }
        public BaseLogger CreateLogger(string className)
        {
            if(fileName is null)
            {
                return null;
            }
            else
            {
                FileLogger fl = new FileLogger(FileName, className);
                return fl;
            }
        }
        public void ConfigureFileLogger(string fileName)
        {
            FileName = fileName;
        }
    }
}
