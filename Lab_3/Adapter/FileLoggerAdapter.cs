using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileLoggerAdapter : ILogger
    {
        private readonly FileWriter fileWriter;

        public FileLoggerAdapter(string filePath)
        {
            fileWriter = new FileWriter(filePath);
        }

        public void Log(string message)
        {
            fileWriter.WriteLine("[INFO] " + message);
        }

        public void Error(string message)
        {
            fileWriter.WriteLine("[ERROR] " + message);
        }

        public void Warn(string message)
        {
            fileWriter.WriteLine("[WARN] " + message);
        }
    }
}
