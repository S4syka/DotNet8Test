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
}
