using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AstroBit.Test
{
    public static class FunctionalApplicationTest
    {
        [TestClass]
        public class Apply
        {
            [TestMethod]
            public void ShouldApplyTheGivenFunc()
            {
                var result = 10.Apply(x => x + 10);

                result
                    .Should().Be(20);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ShouldThrowWhenGivenNull()
            {
                Func<int, int> f = null;
                10.Apply(f);
            }
        }
    }
}
