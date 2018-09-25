using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AstroBit.Test
{
    public static class ZodiacExtensionsTest
    {
        [TestClass]
        public class GetSignByIndex
        {
            [DataTestMethod]
            [DataRow(0, "♈")]
            [DataRow(7, "♏")]
            [DataRow(11, "♓")]
            public void ShouldReturnExpectedSign(int index, string expectedSign)
            {
                ZodiacExtensions.GetSignByIndex(index).Should().Be(expectedSign);
            }

            [DataTestMethod]
            [DataRow(-1, "")]
            [DataRow(12, "")]
            public void ShouldThrowWhenOutOfRange(int index, string expectedSign)
            {
                Action shouldThrow = () => ZodiacExtensions.GetSignByIndex(index);
                shouldThrow.Should().Throw<ArgumentException>();
            }
        }
    }
}
