# Super FizzBuzz

Classic FizzBuzz but with the ability to pass in your own words to override particular multiples.

You can call it with a list of Tuple<int, string> 

```
    var overrides = new List<Tuple<int, string>>
    {
        Tuple.Create(7, "Dog"),
        Tuple.Create(3, "Hot"),
        Tuple.Create(42, "WithMustard")
    };
    FizzBuzz.Calculate(100, overrides).ToList();
```

Or use the new C# 7 syntax...

```
	FizzBuzz.Calculate(100, (3, "Fizz"), (5, "Buzz"));
```

## Try Super FizzBuzz live

http://superfizzbuzz.azurewebsites.net/
