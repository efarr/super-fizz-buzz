using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;

namespace SuperFizzBuzzTests
{
    public class WhenOverridingWithNegativeMultiples
    {
        [TestMethod]
        public void ShouldIgnoreNegativeMultiples()
        {
            Assert.AreEqual(0, FizzBuzz.Calculate(100, (-3, "Never")).Count(s => s.Contains("Never")));
        }
    }
}