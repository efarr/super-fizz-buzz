using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class WhenValueIsNotDivisibleByThreeOrFive
    {
        [TestMethod]
        public void ShouldRenderNumber()
        {
            TestHelper.AssertRendered(7, "7");
        }
    }
}
