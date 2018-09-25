using System;

namespace AstroBit.EphemerisDBBuilder.AstroCom
{
    public static class RowParser
    {
        public static EphemerisEntry Parse(int year, int month, string line, EphemerisEntry previousEntry)
        {
            var parser = new TokenParser(line);

            parser.ReadDayLetter();
            int dayOfMonth = parser.ReadNumber();
            double siderealTime = ReadSiderealTime(parser);

            var sun = ReadSunPosition(parser, previousEntry.Sun);
            var moon = ReadPlanetPosition(parser, previousEntry.Moon);
            var mercury = ReadPlanetPosition(parser, previousEntry.Mercury);
            var venus = ReadPlanetPosition(parser, previousEntry.Venus);
            var mars = ReadPlanetPosition(parser, previousEntry.Mars);
            var jupiter = ReadPlanetPosition(parser, previousEntry.Jupiter);
            var saturn = ReadPlanetPosition(parser, previousEntry.Saturn);
            var uranus = ReadPlanetPosition(parser, previousEntry.Uranus);
            var neptune = ReadPlanetPosition(parser, previousEntry.Neptune);
            var pluto = ReadPlanetPosition(parser, previousEntry.Pluto);
            var trueNode = ReadPlanetPosition(parser, previousEntry.TrueNode);
            var meanNode = ReadPlanetPosition(parser, previousEntry.MeanNone);
            var blackMoonLilith = ReadPlanetPosition(parser, previousEntry.BlackMoonLilith);
            var chiron = ReadPlanetPosition(parser, previousEntry.Chiron);

            return new EphemerisEntry(
                new DateTime(year, month, dayOfMonth, 0, 0, 0, DateTimeKind.Utc),
                siderealTime,
                sun,
                moon,
                mercury,
                venus,
                mars,
                jupiter,
                saturn,
                uranus,
                neptune,
                pluto,
                trueNode,
                meanNode,
                blackMoonLilith,
                chiron);
            }

        private static double ReadSiderealTime(TokenParser parser)
        {
            var hours = parser.ReadNumber();
            var minutes = parser.ReadNumber();
            var seconds = parser.ReadNumber();

            return hours + (minutes / 60.0) + (seconds / 3600.0);
        }

        private static Planet ReadSunPosition(TokenParser parser, Planet previousSun)
        {
            var localDegrees = parser.ReadNumber(false);
            var seperator = parser.ReadDegreeSeperator();
            var parsedDirection = parser.OptionalReadDirection();
            parser.OptionalSkipSpace();
            var localMinutes = parser.ReadNumber(readSpaceAfter: false);
            parser.ReadSecondSeperator();
            var localSeconds = parser.ReadNumber();

            var zodicDegree = seperator.HasValue
                ? seperator.Value.GetStartDegree()
                : previousSun.GetZodiacStartDegree();

            var direction = parsedDirection.HasValue 
                ? parsedDirection.Value 
                : previousSun.Direction;

            var absoluteDegrees = zodicDegree + localDegrees + (localMinutes / 60.0) + (localSeconds / 3600.0);

            return new Planet(PlanetType.Sun, absoluteDegrees, direction);
        }

        private static Planet ReadPlanetPosition(TokenParser parser, Planet previousPlanet)
        {
            var localDegrees = parser.ReadNumber(false);
            var seperator = parser.ReadDegreeSeperator();
            var parsedDirection = parser.OptionalReadDirection();
            parser.OptionalSkipSpace();
            var localMinutes = parser.ReadNumber();

            var zodicDegree = seperator.HasValue
                ? seperator.Value.GetStartDegree()
                : previousPlanet.GetZodiacStartDegree();

            var direction = parsedDirection.HasValue
                ? parsedDirection.Value
                : previousPlanet.Direction;

            var absoluteDegrees = zodicDegree + localDegrees + (localMinutes / 60.0);

            return new Planet(previousPlanet.Type, absoluteDegrees, direction);
        }
    }
}
