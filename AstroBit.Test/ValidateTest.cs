using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AstroBit.Test
{
    public static class ValidateTest
    {
        [TestClass]
        public class NotNullWithString
        {
            [TestMethod]
            public void ShouldReturnGivenValueWhenNotNull()
            {
                string result = Validate.NotNull("test");
                result.Should().Be("test");
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ShouldThrowWhenGivenNull()
            {
                string value = null;
                Validate.NotNull(value);
            }
        }

        [TestClass]
        public class NotNullWithExceptionFactory
        {
            [TestMethod]
            public void ShouldReturnGivenValueWhenNotNull()
            {
                string result = Validate.NotNull("test", () => new InvalidOperationException());
                result.Should().Be("test");
            }

            [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]
            public void ShouldThrowWhenGivenNull()
            {
                string value = null;
                Validate.NotNull(value, () => new InvalidOperationException());
            }
        }

        [TestClass]
        public class NotNullWithTwoValues
        {
            [TestMethod]
            public void ShouldReturnGivenValuesWhenNoneAreNull()
            {
                var value1 = "test1";
                var value2 = "test2";
                (string v1, string v2) = Validate.NotNull(value1, nameof(value1), value2, nameof(value2));
                v1.Should().Be(value1);
                v2.Should().Be(value2);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ShouldThrowWhenFirstValueIsNull()
            {
                string value1 = null;
                var value2 = "test2";
                Validate.NotNull(value1, nameof(value1), value2, nameof(value2));
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ShouldThrowWhenSecondValueIsNull()
            {
                var value1 = "test1";
                string value2 = null;
                Validate.NotNull(value1, nameof(value1), value2, nameof(value2));
            }
        }

        [TestClass]
        public class Check
        {
            [TestMethod]
            public void ShouldReturnGivenValueWhenValid()
            {
                var value = 10;
                Validate.Check(value, x => true).Should().Be(value);
            }

            [TestMethod]
            public void ShouldPassCorrectValueToValidator()
            {
                var value = 10;
                var validatedArgument = 0;
                Validate.Check(value, x => { validatedArgument = x; return true; });

                validatedArgument.Should().Be(value);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowWhenIsInvalid()
            {
                var value = 10;
                Validate.Check(value, x => false);
            }
        }
    }
}
