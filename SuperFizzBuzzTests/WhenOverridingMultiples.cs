using System;
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
            var overrides = new List<Tuple<int, string>>
            {
                Tuple.Create(-3, "Never"),
                Tuple.Create(7, "Dog"),
                Tuple.Create(3, "Hot"),
                Tuple.Create(42, "WithMustard")
            };
            _rendered = FizzBuzz.Calculate(100, overrides).ToList();
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

        [TestMethod]
        public void ShouldIgnoreNegativeMultiples()
        {
            Assert.AreEqual(0, _rendered.Count(s => s.Contains("Never")));
        }
    }
}
