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
            [TestMethod]
            public void ShouldReturnCorrectTime()
            {
                var time1 = new Arc(90, 0, 0).ToTime();
                time1.Should().Be(TimeSpan.FromHours(6));

                var time2 = new Arc(180, 30, 0).ToTime();
                time2.Should().Be(new TimeSpan(12, 2, 0));

                var time3 = new Arc(200, 20, 20).ToTime();
                time3.Should().Be(new TimeSpan(13, 21, 21));
            }
        }
    }
}
