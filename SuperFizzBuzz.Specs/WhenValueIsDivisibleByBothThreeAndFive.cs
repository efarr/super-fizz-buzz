using Xunit;

namespace SuperFizzBuzz.Specs
{
    public class WhenValueIsDivisibleByBothThreeAndFive
    {
        [Fact]
        public void ShouldRenderFizzBuzz()
        {
            TestHelper.AssertRendered(15, "FizzBuzz");
        }
    }
}