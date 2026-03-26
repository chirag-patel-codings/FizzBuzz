int[] inputs = new int[] {3, 5, 15, 16};

foreach (int input in inputs)
{
    Console.WriteLine(FizzBuzz(input));
}

static string FizzBuzz (int num)
{
    return (num % 3 == 0) ? "fizz" : (num % 5 == 0 ? "buzz" : (num % 3 == 0 || num % 5 == 0) ? "fizzbuzz" : "NotAFizzBuzz");
}
