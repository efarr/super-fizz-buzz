using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class WhenValueIsDivisibleByJustThree
    {
        [TestMethod]
        public void ShouldRenderFizz()
        {
            TestHelper.AssertRendered(9, "Fizz");
        }
    }
}