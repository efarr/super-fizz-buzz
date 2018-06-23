using Xunit;

namespace SuperFizzBuzz.Specs
{
    public class WhenValueIsNotDivisibleByThreeOrFive
    {
        [Fact]
        public void ShouldRenderNumber()
        {
            TestHelper.AssertRendered(7, "7");
        }
    }
}
