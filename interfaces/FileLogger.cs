using System;

namespace interfaces
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}