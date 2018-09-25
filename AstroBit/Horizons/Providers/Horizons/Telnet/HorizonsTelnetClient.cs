using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;

namespace AstroBit.Horizons.Providers.Horizons.Telnet
{
    public class HorizonsTelnetClient
    {
        private readonly string host;
        private readonly int port;

        public HorizonsTelnetClient(string host = "horizons.jpl.nasa.gov", int port = 6775)
        {
            this.host = host;
            this.port = port;
        }

        public IList<TableEntry> GetEntires(BodyId bodyId, double longitude, double latitude, double altitude, DateTime startTime, DateTime endTime, int intervalSize, IntervalUnit intervalUnit)
        {
            using (var client = new TcpClient("horizons.jpl.nasa.gov", 6775))
            {
                var stream = client.GetStream();
                var inputStream = new StreamReader(stream);
                var outputStream = new StreamWriter(stream);

                inputStream.ReadStartText();
                outputStream.SelectBody(inputStream, bodyId);
                outputStream.SelectEphemeris(inputStream);
                outputStream.SelectObserver(inputStream);
                outputStream.SelectCoordinateCenter(inputStream);
                outputStream.SelectGeodeticCoordinateSystem(inputStream);
                outputStream.SelectGeodeticPosition(inputStream, longitude, latitude, altitude);
                outputStream.SelectStartTime(inputStream, startTime);
                outputStream.SelectEndTime(inputStream, endTime);
                outputStream.SelectInterval(inputStream, intervalSize, intervalUnit);
                outputStream.SelectDefault(inputStream);
                var result = outputStream.SelectObserverTable(inputStream, TableQuantities.LocalApparentSiderealTime, TableQuantities.ObserverEclipticLongitudeLatitude);

                return TableResultParser.Parse(result);
            }
        }
    }
}
