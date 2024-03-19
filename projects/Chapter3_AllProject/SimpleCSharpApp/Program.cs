foreach (string drive in Environment.GetLogicalDrives())
{
    Console.WriteLine($"Drive: {drive}");
}

Console.WriteLine($"OS: {Environment.OSVersion}");
Console.WriteLine($"Number of processors: {Environment.ProcessorCount}");
