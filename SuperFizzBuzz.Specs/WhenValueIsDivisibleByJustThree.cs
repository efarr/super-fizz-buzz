using Xunit;

namespace SuperFizzBuzz.Specs
{
    public class WhenValueIsDivisibleByJustThree
    {
        [Fact]
        public void ShouldRenderFizz()
        {
            TestHelper.AssertRendered(9, "Fizz");
        }
    }
}