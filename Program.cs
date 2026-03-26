int[] inputs = new int[] {3, 5, 15, 45, 44};

foreach (int input in inputs)
{
    Console.WriteLine(FizzBuzz(input));
}

static string FizzBuzz (int num)
{

    string result = "";

    if(num % 3 == 0)
    {
        result = "fizz";
    }
    if (num % 5 == 0)
    {
        result += "buzz";
    }

    if(result == "")
    {
        result = "NotAFizzBuzz";
    }

    return result;
}
