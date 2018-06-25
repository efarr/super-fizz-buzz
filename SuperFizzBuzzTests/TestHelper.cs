using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;

namespace SuperFizzBuzzTests
{
    public class TestHelper
    {
        public static void AssertRendered(int index, string expectRendered)
        {
            Assert.AreEqual(expectRendered, FizzBuzz.Calculate(index).Last());
        }
    }
}