Console.WriteLine("Press any key combination: ");

ConsoleKeyInfo key;
do
{
    key = ReadKey();
    Console.WriteLine();
    Console.WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", key.Key, key.KeyChar, key.Modifiers);
}while(key.KeyChar != 'X');