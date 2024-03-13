//Display a simple message to the user
Console.WriteLine("***** My First (no) C# App *****");
Console.WriteLine();

Console.ReadLine();

string[] theArgs = Environment.GetCommandLineArgs();

foreach(string arg in theArgs)
{
    Console.WriteLine($"Arg: {arg}");
}

return -1;