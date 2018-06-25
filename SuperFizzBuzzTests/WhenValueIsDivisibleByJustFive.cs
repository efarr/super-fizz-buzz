using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class WhenValueIsDivisibleByJustFive
    {
        [TestMethod]
        public void ShouldRenderBuzz()
        {
            TestHelper.AssertRendered(10, "Buzz");
        }
    }
}