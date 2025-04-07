using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proksi
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private SmartTextReader reader = new SmartTextReader();
        private Regex restrictedPattern;

        public SmartTextReaderLocker(string pattern)
        {
            restrictedPattern = new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public char[][] ReadFile(string filePath)
        {
            if (restrictedPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }

            return reader.ReadFile(filePath);
        }
    }
}
