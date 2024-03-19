using System.Numerics;
Console.WriteLine("***** Basic Console I/O *****");
BigInteger big1 = BigInteger.Parse("8888888888888888888888888888888888888888888888888888888");
BigInteger big2 = BigInteger.Parse("8888888888888888888888888888888888888888888888888888888");
Console.WriteLine(big1 * big2);

static void ParseFromStringsWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine($"Value of b: {b}");
    }
    else
    {
        Console.WriteLine($"Default value of b: {b}");
    }

    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine($"Value of d: {d}");
    }
    else
    {
        Console.WriteLine($"Failed to convert the input ({value}) to a double and the variable was assigned the default {d} value");
    }
}

    static void FormatNumericalData()
{
    Console.WriteLine("The value 99999 in various formats:");
    Console.WriteLine($"c format: {99999:c}");
    Console.WriteLine($"d9 format: {99999:d9}");
    Console.WriteLine($"f3 format: {99999:f3}");
    Console.WriteLine($"n format: {99999:n}");

    Console.WriteLine($"E format: {99999:E}");
    Console.WriteLine($"e format: {99999:e}");
    Console.WriteLine($"X format: {99999:X}");
    Console.WriteLine($"x format: {99999:x}");
}

static void GetUserData()
{
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    Console.Write("Please enter tour age: ");
    string userAge = Console.ReadLine();

    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine($"Hello {userName}! You are {userAge} years old.");

    Console.ForegroundColor = prevColor;
}
