#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using System;
using AstroBit.Math;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AstroBit.Test.Math
{    
    public static class ArcTest
    {
        [TestClass]
        public class Constuctor
        {
            [DataTestMethod]
            [DataRow(1, 30, 65, 1, 31, 5, DisplayName = "wrap seconds")]
            [DataRow(1, 65, 30, 2, 5, 30, DisplayName = "wrap minutes")]
            [DataRow(365, 30, 30, 5, 30, 30, DisplayName = "wrap degrees")]
            [DataRow(1, 65, 65, 2, 6, 5, DisplayName = "wrap seconds and minutes")]
            [DataRow(365, 65, 65, 6, 6, 5, DisplayName = "wrap seconds and minutes and degrees")]
            public void ShouldWrapCorrectly(int degrees, int minutes, int seconds, int expectedDegrees, int expectedMinuts, int expectedSeconds)
            {
                var arc = new Arc(degrees, minutes, seconds);
                arc.Degrees.Should().Be(expectedDegrees);
                arc.Minutes.Should().Be(expectedMinuts);
                arc.Seconds.Should().Be(expectedSeconds);
            }

            [DataTestMethod]
            [DataRow(-1, 30, 30, DisplayName = "negative degrees")]
            [DataRow(30, -1, 30, DisplayName = "negative minutes")]
            [DataRow(30, 30, -1, DisplayName = "negative seconds")]
            public void ShouldThrowOnNegativeArgument(int degrees, int minutes, int seconds)
            {
                Action shouldThrow = () => new Arc(degrees, minutes, seconds);
                shouldThrow.Should().Throw<ArgumentException>();
            }
        }

        [TestClass]
        public class ToString
        {
            [DataTestMethod]
            [DataRow(1, 10, 1.12, "1°10'1\"")]
            [DataRow(1, 10, 1.9, "1°10'2\"")]
            public void ShouldReturnCorrectFormattedString(int degrees, int minutes, double seconds, string expectedValue)
            {
                var arc = new Arc(degrees, minutes, seconds);
                arc.ToString().Should().Be(expectedValue);
            }
        }        
    }
}