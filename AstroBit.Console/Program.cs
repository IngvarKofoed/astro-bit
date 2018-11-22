using AstroBit;
using AstroBit.AstroMath;
using AstroBit.HumanDesign;
using AstroBit.Mandala;
using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Linq;

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
            MandalaGeneratorTest();
            //SqliteEphemerisFetcher fetcher = new SqliteEphemerisFetcher();
            //fetcher.FetchRange(2018, 2020);

            //Console.WriteLine("ALL DONE!!!");
            //Console.ReadKey();

            return;

            
            File.WriteAllText("output.txt", "");

            //// Martin
            //var birthDate = new DateTime(1977, 8, 30, 5, 10, 0, DateTimeKind.Utc); // Must be UTC with out DST
            //var birthLongitude = new Longitude(9, 34, 0, LongitudeDirection.East);
            //var birthLatitude = new Latitude(56, 10, 0, LatitudeDirection.North);

            //// Bastian
            //var birthDate = new DateTime(2007, 9, 3, 23, 0, 0, DateTimeKind.Utc); // Must be UTC with out DST
            //var birthLongitude = new Longitude(12, 35, 0, LongitudeDirection.East);
            //var birthLatitude = new Latitude(55, 40, 0, LatitudeDirection.North);

            // Louise
            var birthDate = new DateTime(1968, 4, 26, 8, 45, 0, DateTimeKind.Utc); // Must be UTC with out DST
            var birthLongitude = new Longitude(9, 56, 0, LongitudeDirection.East);
            var birthLatitude = new Latitude(57, 3, 0, LatitudeDirection.North);

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
