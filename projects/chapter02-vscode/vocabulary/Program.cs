string horizontalLine = new string('-', 113);

Console.WriteLine(horizontalLine);
Console.WriteLine("{0,-10} {1, -20} {2, 30} {3, 50}", "Type", "Byte(s) of memory", "Min", "Max");
Console.WriteLine(horizontalLine);

Console.WriteLine($"{"sbyte",-10} {sizeof(sbyte), -2} {sbyte.MinValue, 48} {sbyte.MaxValue, 50}");
Console.WriteLine($"{"byte",-10} {sizeof(byte), -2} {byte.MinValue, 48} {byte.MaxValue, 50}");
Console.WriteLine($"{"short",-10} {sizeof(short), -2} {short.MinValue, 48} {short.MaxValue, 50}");
Console.WriteLine($"{"decimal",-10} {sizeof(decimal), -2} {decimal.MinValue, 48} {decimal.MaxValue, 50}");
Console.WriteLine(horizontalLine);