using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class WhenOverridingMultiples
    {
        private readonly IList<string> _rendered;

        public WhenOverridingMultiples()
        {
            _rendered = FizzBuzz.Calculate(100, (7, "Dog"), (3, "Hot"), (42, "WithMustard")).ToList();
        }

        [TestMethod]
        public void ShouldRenderOverridenMultiples()
        {
            Assert.AreEqual("Hot", _rendered[9 - 1]);
            Assert.AreEqual("Dog", _rendered[7 - 1]);
        }

        [TestMethod]
        public void ShouldCombineWordsFromLowestMultipleToHighest()
        {
            Assert.AreEqual("HotDog", _rendered[21 - 1]);
            Assert.AreEqual("HotDogWithMustard", _rendered[42 - 1]);
        }
    }
}
