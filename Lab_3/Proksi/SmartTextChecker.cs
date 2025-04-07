using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proksi
{
    public class SmartTextChecker : ISmartTextReader
    {
        private SmartTextReader reader = new SmartTextReader();

        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine($"[LOG] Opening file: {filePath}");
            char[][] result = reader.ReadFile(filePath);
            Console.WriteLine($"[LOG] Successfully read file: {filePath}");
            Console.WriteLine($"[LOG] Lines: {result.Length}");

            int totalChars = 0;
            foreach (var line in result)
                totalChars += line.Length;

            Console.WriteLine($"[LOG] Characters: {totalChars}");
            Console.WriteLine($"[LOG] Closing file: {filePath}");

            return result;
        }
    }
}
