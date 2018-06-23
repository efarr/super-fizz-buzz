using System.Linq;
using Xunit;

namespace SuperFizzBuzz.Specs
{
    public class TestHelper
    {
        public static void AssertRendered(int index, string expectRendered)
        {
            Assert.Equal(expectRendered, FizzBuzz.Calculate(index).Last());
        }
    }
}