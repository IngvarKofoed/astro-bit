using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AstroBit.Horizons.Providers.Horizons.Telnet
{
    internal static class TelnetCommands
    {
        public static void ReadStartText(this StreamReader streamReader)
        {
            streamReader.TerminatedRead(TelnetConstants.StartTerminationString);
        }

        public static void SelectBody(this StreamWriter streamWriter, StreamReader streamReader, BodyId bodyId)
        {
            streamWriter.WriteWithNewLine(((int)bodyId).ToString());
            streamReader.TerminatedRead(TelnetConstants.BodySelectionTerminationString);
        }

        public static void SelectEphemeris(this StreamWriter streamWriter, StreamReader streamReader)
        {
            streamWriter.WriteWithNewLine("e");
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectObserver(this StreamWriter streamWriter, StreamReader streamReader)
        {
            streamWriter.WriteWithNewLine("o");
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectNo(this StreamWriter streamWriter, StreamReader streamReader)
        {
            streamWriter.WriteWithNewLine("n");
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectYes(this StreamWriter streamWriter, StreamReader streamReader)
        {
            streamWriter.WriteWithNewLine("y");
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectDefault(this StreamWriter streamWriter, StreamReader streamReader)
        {
            streamWriter.WriteWithNewLine("");
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectCoordinateCenter(this StreamWriter streamWriter, StreamReader streamReader)
        {
            streamWriter.WriteWithNewLine("coord");
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectGeodeticCoordinateSystem(this StreamWriter streamWriter, StreamReader streamReader)
        {
            streamWriter.WriteWithNewLine("g");
            streamReader.TerminatedRead(TelnetConstants.GeodeticCoordinatesSelectionTerminationString);
        }

        public static void SelectGeodeticPosition(this StreamWriter streamWriter, StreamReader streamReader, double longitude, double latitude, double altitude)
        {
            streamWriter.WriteWithNewLine($"{longitude.ToString(CultureInfo.InvariantCulture)},{latitude.ToString(CultureInfo.InvariantCulture)},{altitude.ToString(CultureInfo.InvariantCulture)}");
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectStartTime(this StreamWriter streamWriter, StreamReader streamReader, DateTime startTime)
        {
            streamWriter.WriteWithNewLine(startTime.ToString("yyyy-MM-dd HH:mm"));
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectEndTime(this StreamWriter streamWriter, StreamReader streamReader, DateTime endTime)
        {
            streamWriter.WriteWithNewLine(endTime.ToString("yyyy-MM-dd HH:mm"));
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static void SelectInterval(this StreamWriter streamWriter, StreamReader streamReader, int size, IntervalUnit unit)
        {
            streamWriter.WriteWithNewLine($"{size} {unit.ToTelnetString()}");
            streamReader.TerminatedRead(TelnetConstants.SelectionTerminationString);
        }

        public static string SelectObserverTable(this StreamWriter streamWriter, StreamReader streamReader, params TableQuantities[] tableQuantities)
        {
            var quantities = tableQuantities
                .Select(x => ((int)x).ToString())
                .Aggregate((x, a) => x == null ? a : $"{a},{x}");

            streamWriter.WriteWithNewLine(quantities);
            return streamReader.TerminatedRead(TelnetConstants.TableTerminationString);
        }
    }
}
