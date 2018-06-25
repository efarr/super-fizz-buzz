using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class WhenValueIsDivisibleByBothThreeAndFive
    {
        [TestMethod]
        public void ShouldRenderFizzBuzz()
        {
            TestHelper.AssertRendered(15, "FizzBuzz");
        }
    }
}