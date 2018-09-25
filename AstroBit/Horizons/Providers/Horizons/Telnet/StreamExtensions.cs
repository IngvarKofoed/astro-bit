using System;
using System.IO;

namespace AstroBit.Horizons.Providers.Horizons.Telnet
{
    internal static class StreamExtensions
    {
        public static string TerminatedRead(this StreamReader stream, string terminationString)
        {
            string currentString = String.Empty;

            char[] buffer = new char[32768];
            while (!currentString.EndsWith(terminationString))
            {
                var count = stream.Read(buffer, 0, buffer.Length);
                currentString += new string(buffer, 0, count);
            }

            return currentString;
        }

        public static void WriteWithNewLine(this StreamWriter stream, string command)
        {
            stream.Write($"{command}{TelnetConstants.NewLine}");
            stream.Flush();
        }
    }
}
