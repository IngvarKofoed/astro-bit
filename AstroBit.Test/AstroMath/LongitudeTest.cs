using AstroBit.AstroMath;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AstroBit.Test.Math
{
    public static class LongitudeTest
    {
        [TestClass]
        public class Constructor
        {
            [TestMethod]
            public void ConstructsWithCorrectDirection()
            {
                var longitude = new Longitude(1, 1, 1, LongitudeDirection.West);
                longitude.Direction.Should().Be(LongitudeDirection.West);
            }
        }
    }
}
