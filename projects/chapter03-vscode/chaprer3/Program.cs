try
{
    Console.WriteLine("Enter a number [0, 255]: ");
    string? firstNum = ReadLine();

    Console.WriteLine("Enter another number [0, 255]: ");
    string? secondNum = ReadLine();

    byte result = (byte)(byte.Parse(firstNum!)/byte.Parse(secondNum!));
    WriteLine($"{firstNum} divided by {secondNum} is {result}");
}
catch(System.Exception ex)
{
    WriteLine($"{ex.GetType()}: {ex.Message}.");
}