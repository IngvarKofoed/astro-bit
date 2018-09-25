using AstroBit.AstroMath;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AstroBit.Test.Math
{
    public static class LongitudeExtensionsTest
    {
        [TestClass]
        public class ToDegrees
        {
            [DataTestMethod]
            [DataRow(50, 0, 0, LongitudeDirection.East, 50.0)]
            [DataRow(50, 0, 0, LongitudeDirection.West, -50.0)]
            [DataRow(50, 30, 12, LongitudeDirection.East, 50.50333333333333)]
            [DataRow(50, 30, 12, LongitudeDirection.West, -50.50333333333333)]
            public void ShouldMakeCorrectConvertions(int degrees, int minutes, double seconds, LongitudeDirection direction, double expectedDegrees)
            {
                var longitudeDegrees = new Longitude(50, minutes, seconds, direction).ToDegrees();
                longitudeDegrees.Should().Be(expectedDegrees);
            }
        }
    }
}
