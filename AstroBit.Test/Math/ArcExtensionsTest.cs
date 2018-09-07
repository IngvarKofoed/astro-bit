using System;
using AstroBit.Math;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AstroBit.Test.Math
{
    public static class ArcExtensionsTest
    {
        [TestClass]
        public class ToTime
        {
            [DataTestMethod]
            [DataRow("6:00:00", 90, 0, 0)]
            [DataRow("12:02:00", 180, 30, 0)]
            [DataRow("13:21:21", 200, 20, 20)]
            [DataRow("1.06:00:00", 450, 0, 0)]
            public void ShouldReturnCorrectTime(string expectedTime, int degrees, int minutes, int seconds)
            {
                var time = new Arc(degrees, minutes, seconds).ToTime();
                time.Should().Be(TimeSpan.Parse(expectedTime));
            }
        }
    }
}
