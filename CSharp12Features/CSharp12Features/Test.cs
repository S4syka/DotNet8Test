namespace CSharp12Features;

public static class Test
{
    public static void PatternMatching(int number = 5)
    {
        switch (number)
        {
            case 1:
                WriteLine("One");
                break; // Jumps to end of switch statement.
            case 2:
                WriteLine("Two");
                goto case 1;
            case 3: // Multiple case section.
            case 4:
                WriteLine("Three or four");
                goto case 1;
            case 5:
                goto A_label;
            default:
                WriteLine("Default");
                break;
        } // End of switch statement.
        WriteLine("After end of switch");
        A_label:
            WriteLine($"After A_label");
    }

    public static void FilteredException(string amount)
    {
        try
        {
            decimal amountValue = decimal.Parse(amount);
            WriteLine($"Amount formatted as currency: {amountValue:C}");
        }
        catch (FormatException) when (amount.Contains("$"))
        {
            WriteLine("Amounts cannot use the dollar sign!");
        }
        catch (FormatException)
        {
            WriteLine("Amounts must only contain digits!");
        }
    }

    public static int FunctionalFibonacci(int n) => n switch
    {
        (<= 0) => throw new ArgumentOutOfRangeException(),
        1 => 0,
        2 => 1,
        _ => FunctionalFibonacci(n - 1) + FunctionalFibonacci(n - 2)
    };
}
