using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AstroBit.Test
{
    public static class ZodiacSignsTest
    {
        [TestClass]
        public class GetByIndex
        {
            [DataTestMethod]
            [DataRow(0, "♈")]
            [DataRow(7, "♏")]
            [DataRow(11, "♓")]
            public void ShouldReturnExpectedSign(int index, string expectedSign)
            {
                ZodiacSigns.GetByIndex(index).Should().Be(expectedSign);
            }

            [DataTestMethod]
            [DataRow(-1, "")]
            [DataRow(12, "")]
            public void ShouldThrowWhenOutOfRange(int index, string expectedSign)
            {
                Action shouldThrow = () => ZodiacSigns.GetByIndex(index);
                shouldThrow.Should().Throw<ArgumentException>();
            }
        }
    }
}
