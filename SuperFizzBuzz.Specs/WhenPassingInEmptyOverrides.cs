using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SuperFizzBuzz.Specs
{
    public class WhenPassingInEmptyOverrides
    {
        [Fact]
        public void ShouldReturnAllNumbers()
        {
            int expected = 1;
            foreach (string actual in FizzBuzz.Calculate(10, new List<Tuple<int, string>>()))
            {
                Assert.Equal((expected++).ToString(), actual);
            }
        }
    }
    public class WhenOverridingMultiples
    {
        private readonly IList<string> _rendered;

        public WhenOverridingMultiples()
        {
            _rendered = FizzBuzz.Calculate(100, (7,"Dog"), (3, "Hot"), (42, "WithMustard")).ToList();
        }

        [Fact]
        public void ShouldRenderOverridenMultiples()
        {
            Assert.Equal("Hot", _rendered[9-1]);
            Assert.Equal("Dog", _rendered[7-1]);
        }

        [Fact]
        public void ShouldCombineWordsFromLowestMultipleToHighest()
        {
            Assert.Equal("HotDog", _rendered[21 - 1]);
            Assert.Equal("HotDogWithMustard", _rendered[42 - 1]);
        }
    }
}