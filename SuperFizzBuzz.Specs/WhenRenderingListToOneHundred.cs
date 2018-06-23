using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SuperFizzBuzz.Specs
{
    public class WhenRenderingListToOneHundred
    {
        private readonly IList<string> _rendered;

        public WhenRenderingListToOneHundred()
        {
            _rendered = FizzBuzz.Calculate(100).ToList();
        }

        [Fact]
        public void ShouldReturnOneHundredValues()
        {
            Assert.Equal(100, _rendered.Count);
        }
        [Fact]
        public void ShouldStartWithOne()
        {
            Assert.Equal("1", _rendered.First());
        }
    }
}