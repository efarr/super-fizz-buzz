using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperFizzBuzz;

namespace SuperFizzBuzzSite.Controllers
{
    [Produces("application/json")]
    [Route("api/FizzBuzz")]
    public class FizzBuzzController : Controller
    {
        // GET: api/FizzBuzz
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return FizzBuzz.Calculate(100);
        }

        // GET: api/FizzBuzz/5
        [HttpGet("{upperBound}", Name = "Get")]
        public IEnumerable<string> Get(int upperBound)
        {
            return FizzBuzz.Calculate(upperBound);
        }

        // POST: api/FizzBuzz
        [HttpPost]
        public IEnumerable<string> Post([FromBody] FizzBuzzRequest fizzBuzzRequest)
        {
            List<Tuple<int,string>> overrideList = new List<Tuple<int, string>>();
            string[] tokens = fizzBuzzRequest.Overrides.Split(',');
            for (int i = 0; i < tokens.Length; i+=2)
            {
                overrideList.Add(Tuple.Create(int.Parse(tokens[i]), tokens[i+1]));
            }
            return FizzBuzz.Calculate(fizzBuzzRequest.UpperBound, overrideList);
        }
    }

    public class FizzBuzzRequest
    {
        public int UpperBound { get; set; }
        public string Overrides { get; set; }
    }
}
