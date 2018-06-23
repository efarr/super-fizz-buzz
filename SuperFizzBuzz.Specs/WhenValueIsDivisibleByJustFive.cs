using Xunit;

namespace SuperFizzBuzz.Specs
{
    public class WhenValueIsDivisibleByJustFive
    {
        [Fact]
        public void ShouldRenderBuzz()
        {
            TestHelper.AssertRendered(10, "Buzz");
        }
    }
}