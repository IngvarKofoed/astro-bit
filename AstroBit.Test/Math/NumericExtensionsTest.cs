using AstroBit.Math;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AstroBit.Test.Math
{
    public static class NumericExtensionsTest
    {
        [TestClass]
        public class Truncate
        {
            [DataTestMethod]
            [DataRow(127.0, 127.0, 180, DisplayName = "Not change value when within max")]
            [DataRow(10.0, 190.0, 180, DisplayName = "Truncate value to be less than max")]
            [DataRow(10.0, 370.0, 180, DisplayName = "Truncate value larger than 2x max and give non-negative value and less than max")]
            [DataRow(53.0, -127.0, 180, DisplayName = "Give non-negative value within -max")]
            [DataRow(175.0, -185.0, 180, DisplayName = "Truncate and give non-negative value")]
            [DataRow(175.0, -365.0, 180, DisplayName = "Truncate value less than 2x -max and give non-negative value and less than max")]
            [DataRow(127.456, 127.456, 180, DisplayName = "Preserve decimals")]
            public void ShouldTruncateCorrectly(double expectedValue, double givenValue, int maxValue)
            {
                givenValue.Truncate(maxValue).Should().Be(expectedValue);
            }
        }
    }
}
