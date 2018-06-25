using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class WhenRenderingListToOneHundred
    {
        private readonly IList<string> _rendered;

        public WhenRenderingListToOneHundred()
        {
            _rendered = FizzBuzz.Calculate(100).ToList();
        }

        [TestMethod]
        public void ShouldReturnOneHundredValues()
        {
            Assert.AreEqual(100, _rendered.Count);
        }
        [TestMethod]
        public void ShouldStartWithOne()
        {
            Assert.AreEqual("1", _rendered.First());
        }
    }
}