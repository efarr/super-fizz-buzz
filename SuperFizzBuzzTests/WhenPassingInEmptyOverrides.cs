using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class WhenPassingInEmptyOverrides
    {
        [TestMethod]
        public void ShouldReturnAllNumbers()
        {
            int expected = 1;
            foreach (string actual in FizzBuzz.Calculate(10, new List<Tuple<int, string>>()))
            {
                Assert.AreEqual((expected++).ToString(), actual);
            }
        }
    }
}