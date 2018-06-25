using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperFizzBuzz
{
    public class FizzBuzz
    {
        public static IEnumerable<string> Calculate(int upperBound, IList<Tuple<int, string>> overridePairs)
        {
            overridePairs = DefautToFizzBuzz(overridePairs);
            var overrides = CacheDictionaryForFastLookups(overridePairs);
            var multiples = CacheSortedListForFastIteration(overrides);

            for (int i = 1; i <= upperBound; i++)
            {
                var result = new StringBuilder();

                foreach (int multiple in multiples)
                {
                    if (i % multiple == 0)
                        result.Append(overrides[multiple]);
                }

                yield return result.Length > 0 ? result.ToString() : i.ToString();
            }
        }

        public static IEnumerable<string> Calculate(int upperBound, params (int, string)[] overridePairs)
        {
            var pairs = ConvertPairsToListOfTuples(overridePairs);
            return Calculate(upperBound, pairs.Count > 0 ? pairs : null);
        }

        private static List<Tuple<int, string>> ConvertPairsToListOfTuples((int, string)[] overridePairs)
        {
            var pairs = new List<Tuple<int, string>>();
            foreach ((int, string) pair in overridePairs)
            {
                pairs.Add(new Tuple<int, string>(pair.Item1, pair.Item2));
            }

            return pairs;
        }

        private static List<int> CacheSortedListForFastIteration(Dictionary<int, string> overrides)
        {
            return overrides.Keys.Where(i => i > 0).ToList().OrderBy(k => k).ToList();
        }

        private static Dictionary<int, string> CacheDictionaryForFastLookups(IEnumerable<Tuple<int, string>> overridePairs)
        {
            return overridePairs.ToDictionary(m => m.Item1, m => m.Item2);
        }

        private static IList<Tuple<int, string>> DefautToFizzBuzz(IList<Tuple<int, string>> overridePairs)
        {
            return overridePairs ?? new List<Tuple<int, string>>
            {
                Tuple.Create(3, "Fizz"),
                Tuple.Create(5, "Buzz")
            };
        }
    }
}
