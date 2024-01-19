partial class Program
{
    static int FibImperative(int term)
    {
        if(term == 1)
        {
            return 0;
        }
        else if(term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }

    static void RunFibImperative()
    {
        for(int i = 1; i <= 10; ++i)
        {
            WriteLine($"The {i} term of the Fibonacci sequence is {FibImperative(i):N0}");
        }
    }

    static int FibFunctional(int term) =>
        term switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2)
        };

    static void RunFibFunctional()
    {
        for(int i = 1; i <= 10; ++i)
        {
            WriteLine($"The {i} term of the Fibonacci sequence is {FibFunctional(i):N0}");
        }
    }
}