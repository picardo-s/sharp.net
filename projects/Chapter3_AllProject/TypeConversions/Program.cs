using System.ComponentModel;

ProcessBytes();
static void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;

    try
    {
        byte sum = checked((byte)((int)b1 + (int)b2));
        Console.WriteLine(sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}