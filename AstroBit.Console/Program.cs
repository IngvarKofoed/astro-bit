using AstroBit;
using AstroBit.AstroMath;
using AstroBit.HumanDesign;
using AstroBit.Mandala;
using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using AstroBit.Svg;

namespace atro_bit_console
{
    // TODO: Make types for decimal hours, degrees, sidereal, MC, AC so that they do not get mixed




    public enum LatitudeDirection
    {
        North,
        South
    }


    public class Latitude : Arc
    {
        public Latitude(int degrees, int minutes, double seconds, LatitudeDirection direction) :
            base(degrees, minutes, seconds)
        {
            Direction = direction;
        }

        public Latitude(Arc arc, LatitudeDirection direction) :
            this(arc.Degrees, arc.Minutes, arc.Seconds, direction)
        {
        }

        public LatitudeDirection Direction { get; }

        public override string ToString() =>
            $"{base.ToString()}{Direction.ToString()[0]}";
    }

    public static class ArcExtensions
    {
        public static string ToZodiacSignTimeString(this Arc arc) =>
            $"{arc.Degrees % 30}{ZodiacExtensions.GetSignByIndex(arc.Degrees / 30)}°{arc.Minutes}'{arc.Seconds:F0}\"";
    }

    

    public static class LatitudeExtensions
    {
        public static double ToDegrees(this Latitude latitude) =>
            latitude.GetDirectionFactor() * (latitude.Degrees + latitude.Minutes / 60.0 + latitude.Seconds / 3600.0);

        public static Latitude ToLatitude(this double degrees, LatitudeDirection direction) =>
            new Latitude(degrees.ToArc(), direction);

        ///// <summary>
        ///// Returns the local time converted to local mean time and adjusted for time zones.
        ///// </summary>
        ///// <param name="localDateTime"></param>
        ///// <param name="latitude"></param>
        ///// <returns></returns>
        //public static DateTime ToLocalGmt(this DateTime localDateTime, Latitude latitude)
        //{
        //    var localMeanTime = localDateTime - TimeSpan.FromHours(latitude.GetDirectionFactor() * latitude.Degrees / 15);
        //    var greenwichMeanTime = localMeanTime - new Latitude(0, latitude.Minutes, latitude.Seconds, latitude.Direction).ToTime();
        //    return new DateTime(greenwichMeanTime.Year, greenwichMeanTime.Month, greenwichMeanTime.Day, greenwichMeanTime.Hour, greenwichMeanTime.Minute, greenwichMeanTime.Second, DateTimeKind.Utc);
        //}

        private static int GetDirectionFactor(this Latitude latitude) =>
            latitude.Direction == LatitudeDirection.North ? 1 : -1;
    }


    public static class NumericExtensions
    {
        public static double ToRadians(this double degrees) =>
            Math.PI / 180.0 * degrees;

        public static double ToDegrees(this double radians) =>
             180.0 / Math.PI * radians;

        public static double Truncate(this double value, int maxValue) =>
            value - ((int)value / maxValue) * (maxValue) + (value < 0.0 ? maxValue : 0);
    }

    public static class DateTimeExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Formula based on: http://radixpro.com/a4a-start/julian-day-and-julian-day-number/
        /// </remarks>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static double ToJulianDayNumber(this DateTime dateTime)
        {
            // TODO: Fix this
            // dateTime = dateTime.ToUniversalTime();

            int year = dateTime.Year;
            int month = dateTime.Month;
            int day = dateTime.Day;
            if (dateTime.Month < 2)
            {
                year -= 1;
                month += 12;
            }

            int a = year / 100;
            int b = 2 - a + (a / 4);

            double julianDayNumber = (int)(365.25 * (year + 4716)) + (int)(30.6001 * (month + 1)) + day + b - 1524.5;

            return julianDayNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Formula based on: http://radixpro.com/a4a-start/julian-day-and-julian-day-number/
        /// </remarks>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static double ToJulianDay(this DateTime dateTime) =>
            dateTime.ToJulianDayNumber() + (dateTime.Hour + dateTime.Minute / 60.0 + dateTime.Second / 3600.0) / 24.0;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Formula based on: http://radixpro.com/a4a-start/factor-t-and-delta-t/
        /// </remarks>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static double ToFactorT(this DateTime dateTime) =>
            (dateTime.ToJulianDayNumber() - 2451545.0) / 36525;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Formula based on: http://radixpro.com/a4a-start/sidereal-time/
        /// </remarks>
        /// <param name="dateTime"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public static double ToSiderealTime(this DateTime dateTime, Longitude longitude)
        {
            // TODO: Fix this
            // dateTime = dateTime.ToUniversalTime();

            var factorT = dateTime.ToFactorT();
            
            var siderealTimeGreenwich = 100.46061837 + 36000.770053608 * factorT + 0.000387933 * factorT * factorT - ((factorT * factorT * factorT) / 38710000.0);
            siderealTimeGreenwich = siderealTimeGreenwich.Truncate(360);

            // TODO: Make extension for this
            siderealTimeGreenwich /= 15.0; // st0 is in decimal hours

            var siderealTime = (dateTime.ToDecimalHours() * 1.00273790935 + siderealTimeGreenwich).Truncate(24);

            var correctedSiderealTime = (siderealTime + longitude.ToDegrees() / 15.0).Truncate(24); // TODO: Make extension for this 

            return correctedSiderealTime;
        }

        public static double ToDecimalHours(this DateTime dateTime) =>
            dateTime.Hour + dateTime.Minute / 60.0 + dateTime.Second / 3600.0;


        public static Arc ToArc(this double decimalHours)
        {
            var degrees = (int)decimalHours;
            var minutes = (decimalHours - degrees) * 60.0;
            var seconds = (decimalHours - degrees - ((int)minutes / 60.0)) * 3600.0;
            return new Arc(degrees, (int)minutes, (int)seconds);
        }

        public static TimeSpan ToTimeSpan(this double hourDegrees) =>
            TimeSpan.FromHours(hourDegrees);
    }

    public static class AstroConstants
    {
        public const double Epsilon = 23.437101628;
    }


    public static class AstroMath
    {
        public static double ToRihtAscensionMC(this DateTime dateTime, Longitude longitude)
            => dateTime.ToSiderealTime(longitude).ToRihtAscensionMC();

        public static double ToRihtAscensionMC(this double siderealTime)
            => siderealTime * 15.0;

        public static double ToMediumCoeli(this DateTime dateTime, Longitude longitude) =>
            dateTime.ToSiderealTime(longitude).ToMediumCoeli();

        public static double ToMediumCoeli(this double siderealTime)
        {
            var rightAscensionMC = siderealTime.ToRihtAscensionMC();

            var tanL = Math.Sin(rightAscensionMC.ToRadians()) / (Math.Cos(rightAscensionMC.ToRadians()) * Math.Cos(AstroConstants.Epsilon.ToRadians()));

            var result = Math.Atan(tanL).ToDegrees();

            if (siderealTime >= 0 && siderealTime < 12.0)
            {
                // MC Should be between 0 and 180
                return result.Truncate(180);
            }
            else
            {
                // MC Should be between 180 and 360
                return 180 + result.Truncate(180);
            }
        }

        public static double ToAscendant(this DateTime dateTime, Longitude longitude, Latitude latitude) =>
            dateTime.ToSiderealTime(longitude).ToAscendant(latitude);

        public static double ToAscendant(this double siderealTime, Latitude latitude)
        {
            var rightAscensionMC = siderealTime.ToRihtAscensionMC();
            var mc = siderealTime.ToMediumCoeli();

            var tanL = -Math.Cos(rightAscensionMC.ToRadians()) / 
                       (Math.Sin(AstroConstants.Epsilon.ToRadians()) * Math.Tan(latitude.ToDegrees().ToRadians()) + 
                        Math.Cos(AstroConstants.Epsilon.ToRadians()) * Math.Sin(rightAscensionMC.ToRadians()));

            var result = Math.Atan(tanL).ToDegrees().Truncate(360);

            // Adjust for MC position and should be between MC and MC+180
            if (result < mc)
            {
                result += 180.0;
            }
            else if (result > mc + 180.0)
            {
                result -= 180.0;
            }

            return result.Truncate(360);
        }
    }


    /// <summary>
    /// </summary>
    public static class Placidian
    {
        // TODO: This can be optimized by pre calculating the Asc.
        public static double GetHouseCusp(int houseNumber, DateTime dateTime, Longitude longitude, Latitude latitude, int iterations = 10)
        {
            var ascendant = dateTime.ToAscendant(longitude, latitude);
            var descendant = (ascendant + 180.0).Truncate(360);

            if (houseNumber == 1)
            {
                return dateTime.ToAscendant(longitude, latitude);
            }
            else if (houseNumber == 2)
            {
                var ramc = dateTime.ToRihtAscensionMC(longitude);
                return IntegrateDegrees(ramc + 120.0, 2.0 / 3.0, latitude, iterations).AdjustToAfter(ascendant).Truncate(360);
            }
            else if (houseNumber == 3)
            {
                double ramc = dateTime.ToRihtAscensionMC(longitude);
                return IntegrateDegrees(ramc + 150.0, 1.0 / 3.0, latitude, iterations).AdjustToAfter(ascendant).Truncate(360);
            }
            else if (houseNumber == 4)
            {
                return (dateTime.ToMediumCoeli(longitude) + 180.0).Truncate(360);
            }
            else if (houseNumber == 5)
            {
                double ramc = dateTime.ToRihtAscensionMC(longitude);
                return (IntegrateDegrees(ramc + 30.0, 1.0 / 3.0, latitude, iterations) + 180.0).AdjustToAfter(ascendant).Truncate(360);
            }
            else if (houseNumber == 6)
            {
                double ramc = dateTime.ToRihtAscensionMC(longitude);
                return (IntegrateDegrees(ramc + 60.0, 2.0 / 3.0, latitude, iterations) + 180.0).AdjustToAfter(ascendant).Truncate(360);
            }
            else if (houseNumber == 7)
            {
                return (dateTime.ToAscendant(longitude, latitude) + 180.0).Truncate(360);
            }
            else if (houseNumber == 8)
            {
                double ramc = dateTime.ToRihtAscensionMC(longitude);
                return (IntegrateDegrees(ramc + 120.0, 2.0 / 3.0, latitude, iterations) + 180.0).AdjustToAfter(descendant).Truncate(360);
            }
            else if (houseNumber == 9)
            {
                double ramc = dateTime.ToRihtAscensionMC(longitude);
                return (IntegrateDegrees(ramc + 150.0, 1.0 / 3.0, latitude, iterations) + 180.0).AdjustToAfter(descendant).Truncate(360);
            }
            else if (houseNumber == 10)
            {
                return dateTime.ToMediumCoeli(longitude);
            }
            else if (houseNumber == 11)
            {
                double ramc = dateTime.ToRihtAscensionMC(longitude);
                return IntegrateDegrees(ramc + 30.0, 1.0 / 3.0, latitude, iterations).AdjustToAfter(descendant).Truncate(360);
            }
            else if (houseNumber == 12)
            {
                double ramc = dateTime.ToRihtAscensionMC(longitude);
                return IntegrateDegrees(ramc + 60.0, 2.0 / 3.0, latitude, iterations).AdjustToAfter(descendant).Truncate(360);
            }
            else
            {
                throw new InvalidOperationException($"Invalid house number {houseNumber}");
            }            
        }

        /// <summary>
        /// Calculates by integration the hours cusp in degrees.
        /// </summary>
        /// <remarks>
        /// https://www.scribd.com/document/70479439/The-Placidus-House-Division-Formulas-for-Astrology
        /// https://dokumen.tips/documents/the-placidian-house-system-formulation-correction.html
        /// </remarks>
        /// <param name="h"></param>
        /// <param name="f"></param>
        /// <param name="latitude"></param>
        /// <param name="iterations"></param>
        /// <returns></returns>
        private static double IntegrateDegrees(double h, double f, Latitude latitude, int iterations)
        {
            double result = double.NaN;
            double d = Math.Asin(Math.Sin(AstroConstants.Epsilon.ToRadians()) * Math.Sin(h.ToRadians())).ToDegrees();
            for (int i = 0; i < iterations; i++)
            {
                double a = f * Math.Asin(Math.Tan(latitude.ToDegrees().ToRadians()) * Math.Tan(d.ToRadians())).ToDegrees();
                double m = Math.Atan(Math.Sin(a.ToRadians()) / (Math.Cos(h.ToRadians()) * Math.Tan(d.ToRadians()))).ToDegrees();
                double r = Math.Atan((Math.Tan(h.ToRadians()) * Math.Cos(m.ToRadians())) / Math.Cos(m.ToRadians() + AstroConstants.Epsilon.ToRadians())).ToDegrees();
                double g = Math.Asin(Math.Sin(AstroConstants.Epsilon.ToRadians()) * Math.Sin(r.ToRadians())).ToDegrees();

                result = r;
                d = g;
            }

            return result + 180.0;
        }

        /// <summary>
        /// Adjust the given <paramref name="cusp"/> to be in between the two points given by
        /// <paramref name="afterPoint"/> and <paramref name="afterPoint"/> + 180, on the circle.
        /// </summary>
        /// <param name="cusp"></param>
        /// <param name="afterPoint">Ascendant or Descendant</param>
        /// <returns></returns>
        private static double AdjustToAfter(this double cusp, double afterPoint)
        {
            // Rule: Ascendant < cusp < Ascendant + 180 ... Or descendant

            // Moving all points to after 360.0 to avoid handling 360->0 wrapping cases.
            var a1 = afterPoint + 360.0;
            var c = cusp + 360.0;
            var a2 = a1 + 180.0;

            if (c < a1)
            {
                return cusp + 180.0;
            }
            else if (c > a2)
            {
                return cusp - 180.0;
            }
            else
            {
                return cusp;
            }
        }
    }

    


    


    


    


    

    

    /// <summary>
    /// Local Sidereal time 
    ///     Lookup at Horizons:
    ///         Use Sun (or any other body), longitude/latitude, convert local time of birth to GMT and use this. Use Table quantity 7.
    ///     Formula: http://radixpro.com/a4a-start/sidereal-time/
    ///     Calculator: http://neoprogrammics.com/sidereal_time_calculator/index.php
    ///     
    /// Ascendant
    ///     This formula works! https://en.wikipedia.org/wiki/Ascendant#Calculation
    ///     
    /// 
    /// Other sites:
    ///     https://trans4mind.com/personal_development/astrology/toc.htm
    ///     http://neoprogrammics.com/sidereal_time_calculator/index.php
    ///     http://www.math.nus.edu.sg/aslaksen/projects/kh-urops.pdf
    ///     http://astrology.clairvision.org/static/astrologymanual/Astrology_fundamentals_Earth_coordinates.html
    ///     
    ///     https://horoscopes.astro-seek.com/calculate-house-systems/?send_calculation=1&narozeni_den=4&narozeni_mesic=9&narozeni_rok=2007&narozeni_hodina=01&narozeni_minuta=00&narozeni_city=&narozeni_mesto_hidden=Manually+place%3A+55%C2%B040%27N%2C+12%C2%B035%27E&narozeni_stat_hidden=&narozeni_podstat_kratky_hidden=&narozeni_podstat_hidden=&narozeni_podstat2_kratky_hidden=Manually+place%3A+%C2%B0%27N%2C+%C2%B0%27E&narozeni_podstat3_kratky_hidden=Manually+place%3A+%C2%B0%27N%2C+%C2%B0%27E&narozeni_input_hidden=&narozeni_sirka_stupne=55&narozeni_sirka_minuty=40&narozeni_sirka_smer=0&narozeni_delka_stupne=12&narozeni_delka_minuty=35&narozeni_delka_smer=0&narozeni_timezone_form=auto&narozeni_timezone_dst_form=auto&house_system=placidus&house_system2=koch&house_system3=equal&house_system4=whole&hid_chiron=1&hid_chiron_check=on&hid_lilith=1&hid_lilith_check=on&hid_uzel=1&hid_uzel_check=on&zmena_nastaveni=1&aktivni_tab=
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //var path = PathBuilderParser
            //    .Parse("M 64.28125,95.179581 L 64.28125,91.398331 C 64.281226,88.419171 63.635393,83.106676 62.34375,75.460831 C 61.760395,71.856687 60.802062,68.106691 59.46875,64.210831 C 58.114565,60.252532 56.6979,57.148369 55.21875,54.898331 C 54.072902,53.190039 52.70832,52.335874 51.125,52.335831 C 49.333324,52.335874 48.083325,53.023373 47.375,54.398331 C 46.72916,55.669204 46.406243,57.054619 46.40625,58.554581 C 46.406243,61.721281 47.541659,64.585861 49.8125,67.148331 L 44.5,67.148331 C 42.666664,64.335862 41.749998,61.367115 41.75,58.242081 C 41.749998,54.971288 42.624997,52.40879 44.375,50.554581 C 46.187494,48.637961 48.385408,47.679628 50.96875,47.679581 C 54.302069,47.679628 56.906233,49.054627 58.78125,51.804581 C 60.906229,54.908788 62.67706,58.679617 64.09375,63.117081 C 65.093725,66.346276 65.937474,69.919189 66.625,73.835831 C 67.312472,69.919189 68.156222,66.346276 69.15625,63.117081 C 70.489553,58.783784 72.260384,55.012954 74.46875,51.804581 C 76.343713,49.054627 78.947878,47.679628 82.28125,47.679581 C 84.864538,47.679628 87.062453,48.637961 88.875,50.554581 C 90.624949,52.40879 91.499948,54.971288 91.5,58.242081 C 91.499948,61.367115 90.583283,64.335862 88.75,67.148331 L 83.4375,67.148331 C 85.708287,64.585861 86.843703,61.721281 86.84375,58.554581 C 86.843703,57.054619 86.520787,55.669204 85.875,54.398331 C 85.166621,53.023373 83.916623,52.335874 82.125,52.335831 C 80.541626,52.335874 79.177044,53.190039 78.03125,54.898331 C 76.552047,57.148369 75.135381,60.252532 73.78125,64.210831 C 72.447884,68.106691 71.489552,71.856687 70.90625,75.460831 C 69.614554,83.106676 68.968721,88.419171 68.96875,91.398331 L 68.96875,95.179581 L 64.28125,95.179581")
            //    .Center()
            //    .ToArray();

            //MandalaGeneratorTest();
            //MandalaGeneratorTest();
            //SqliteEphemerisFetcher fetcher = new SqliteEphemerisFetcher();
            //fetcher.FetchRange(2018, 2020);

            //Console.WriteLine("ALL DONE!!!");
            //Console.ReadKey();

            //return;


            //File.WriteAllText("output.txt", "");

            //// Martin
            var birthDate = new DateTime(1977, 8, 30, 5, 10, 0, DateTimeKind.Utc); // Must be UTC with out DST
            var birthLongitude = new Longitude(9, 34, 0, LongitudeDirection.East);
            var birthLatitude = new Latitude(56, 10, 0, LatitudeDirection.North);

            //// Bastian
            //var birthDate = new DateTime(2007, 9, 3, 23, 0, 0, DateTimeKind.Utc); // Must be UTC with out DST
            //var birthLongitude = new Longitude(12, 35, 0, LongitudeDirection.East);
            //var birthLatitude = new Latitude(55, 40, 0, LatitudeDirection.North);

            // Louise
            //var birthDate = new DateTime(1968, 4, 26, 8, 45, 0, DateTimeKind.Utc); // Must be UTC with out DST
            //var birthLongitude = new Longitude(9, 56, 0, LongitudeDirection.East);
            //var birthLatitude = new Latitude(57, 3, 0, LatitudeDirection.North);

            //var birthDate = new DateTime(2016, 11, 2, 21, 17, 30);
            //var birthLongitude = new Longitude(6, 54, 0, LongitudeDirection.East);

            //var birthDate = new DateTime(1990, 10, 9, 0, 0, 0);
            //var birthLongitude = new Longitude(13, 22, 39, LongitudeDirection.East);
            //var birthLatitude = new Latitude(52, 30, 58, LatitudeDirection.North);

            WriteLine($"Longitude: {birthLongitude}");
            WriteLine($"Latitude: {birthLatitude}");
            WriteLine($"Julian date: {birthDate.ToJulianDay()}");
            WriteLine($"Julian day number: {birthDate.ToJulianDayNumber()}");
            WriteLine($"Sidereal time: {birthDate.ToSiderealTime(birthLongitude)} ({birthDate.ToSiderealTime(birthLongitude).ToTimeSpan()}) (RAMC: {birthDate.ToSiderealTime(birthLongitude).ToRihtAscensionMC()})");
            WriteLine($"MC: {birthDate.ToMediumCoeli(birthLongitude).ToArc().ToZodiacSignTimeString()} ({birthDate.ToMediumCoeli(birthLongitude).ToArc()})");
            WriteLine($"Ascendant: {birthDate.ToAscendant(birthLongitude, birthLatitude).ToArc().ToZodiacSignTimeString()} ({birthDate.ToAscendant(birthLongitude, birthLatitude).ToArc()})");

            for (int house = 1; house <= 12; house++)
            {
                var cusp = Placidian.GetHouseCusp(house, birthDate, birthLongitude, birthLatitude).ToArc();
                WriteLine($"House {house} cusp: {cusp.ToZodiacSignTimeString()} ({cusp})");
            }

            var ephemeris = new Ephemeris().Get(birthDate);

            foreach (var planet in ephemeris.AllPlanets)
            {
                int localDegree = (int)planet.GetZodiacLocalDegrees();
                int zodiacSignIndex = (localDegree % 12) - 1;
                zodiacSignIndex = (zodiacSignIndex + 12) % 12;

                Zodiac zodiacSign = (Zodiac)zodiacSignIndex;
                Console.WriteLine($"{planet.Type}: {zodiacSign} - {planet.GetZodiacLocalDegrees()}");
            }

            for (int house = 1; house <= 12; house++)
            {
                var cusp = Placidian.GetHouseCusp(house, birthDate, birthLongitude, birthLatitude).ToArc();
                int localDegree = (int)(cusp.Degrees % 30);
                int zodiacSignIndex = (localDegree % 12) - 1;
                zodiacSignIndex = (zodiacSignIndex + 12) % 12;

                Zodiac zodiacSign = (Zodiac)zodiacSignIndex;
                Console.WriteLine($"House: {house}: {zodiacSign} - {cusp.Degrees % 30}");
            }

            //birthDate.ToMediumCoeli(birthLongitude).to
            //Console.WriteLine($"{planet.Type}: {zodiacSign} - {planet.GetZodiacLocalDegrees()}");

            //HorizonsTelnetClient client = new HorizonsTelnetClient();

            //var entires = client.GetEntires(BodyId.Sun, 0, 0, 0, new DateTime(2018, 7, 30, 0, 0, 0), new DateTime(2018, 7, 31, 0, 0, 0), 10, IntervalUnit.Minutes);
            //var entires = client.GetEntires(BodyId.Sun, 56.1666667, 9.566667, 0, new DateTime(1977, 8, 30, 0, 0, 0), new DateTime(1977, 8, 31, 0, 0, 0), 10, IntervalUnit.Minutes);
            }

        private static void MandalaGeneratorTest()
        {
            var generator = new SvgMandalaGenerator();
            var svgElement = generator.Generate();

            var document = new XDocument();
            document.Add(svgElement);
            document.Save("Result.svg");
        }

        private static void HumanDesignTest()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //var date = new DateTime(1977, 8, 30, 5, 10, 0, DateTimeKind.Utc); // Martin
            var date = DateTime.Now.ToUniversalTime();

            var ephemeris = new Ephemeris();
            var entry = ephemeris.Get(date);

            Console.WriteLine(entry);


            var humanDesignGates = new HumanDesignGates();

            // var sunGate = humanDesignGates.GetDefinedGate((entry.Sun.AbsolutePosition - 88.0).Truncate(360));
            var sunGate = humanDesignGates.GetDefinedGate(entry.Sun.AbsolutePosition);
            var earthGate = sunGate.GetOppositeGate();

            Console.WriteLine("Sun: " + sunGate);
            Console.WriteLine("Earth: " + earthGate);
            Console.WriteLine("Moon: " + humanDesignGates.GetDefinedGate(entry.Moon.AbsolutePosition));
            Console.WriteLine("North Node: " + humanDesignGates.GetDefinedGate(entry.TrueNode.AbsolutePosition));
            Console.WriteLine("South Node: " + humanDesignGates.GetDefinedGate((entry.TrueNode.AbsolutePosition + 180.0).Truncate(360)));
            Console.WriteLine("Mercury: " + humanDesignGates.GetDefinedGate(entry.Mercury.AbsolutePosition));
            Console.WriteLine("Venus: " + humanDesignGates.GetDefinedGate(entry.Venus.AbsolutePosition));
            Console.WriteLine("Mars: " + humanDesignGates.GetDefinedGate(entry.Mars.AbsolutePosition));
            Console.WriteLine("Jupiter: " + humanDesignGates.GetDefinedGate(entry.Jupiter.AbsolutePosition));
            Console.WriteLine("Saturn: " + humanDesignGates.GetDefinedGate(entry.Saturn.AbsolutePosition));
            Console.WriteLine("Uranus: " + humanDesignGates.GetDefinedGate(entry.Uranus.AbsolutePosition));
            Console.WriteLine("Neptune: " + humanDesignGates.GetDefinedGate(entry.Neptune.AbsolutePosition));
            Console.WriteLine("Pluto: " + humanDesignGates.GetDefinedGate(entry.Pluto.AbsolutePosition));

            Console.WriteLine();
            Console.WriteLine("Martin AC: " + humanDesignGates.GetDefinedGate(Zodiac.Virgo.GetStartDegree() + 13));
            Console.WriteLine("Louise AC: " + humanDesignGates.GetDefinedGate(Zodiac.Cancer.GetStartDegree() + 28));
            Console.WriteLine("David AC: " + humanDesignGates.GetDefinedGate(Zodiac.Gemini.GetStartDegree() + 17));
        }
        

        private static void WriteLine(string line)
        {
            Console.WriteLine(line);
            File.AppendAllLines("output.txt", new string[] { line });
        }
    }
}
