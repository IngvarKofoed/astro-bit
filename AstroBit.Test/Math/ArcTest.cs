using AstroBit.Math;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AstroBit.Test.Math
{
    [TestClass]
    public class ArcTest
    {
        [TestMethod]
        public void ToStringShouldReturnCorrectFormattedString()
        {
            var arc1 = new Arc(1, 10, 1.12);
            arc1.ToString().Should().Be("1°10'1\"");

            var arc2 = new Arc(1, 10, 1.9);
            arc2.ToString().Should().Be("1°10'2\"");
        }
    }
}
