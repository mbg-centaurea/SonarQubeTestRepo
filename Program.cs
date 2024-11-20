namespace MyConsoleApp;
class Program
{
    static void FigureA(int n)
    {
        Console.WriteLine("+" + new String('-', n * 2 - 1) + "+");
        for (int i = 1; i < n; i++)
        {
            string side = new('_', n - i);
            Console.WriteLine("|" + side + new String('a', i * 2 - 1) + side + "|");
        }
        for (int i = n; i > 0; i--)
        {
            string side = new('_', n - i);
            Console.WriteLine("|" + side + new String('a', i * 2 - 1) + side + "|");
        }
        Console.WriteLine("+" + new String('-', n * 2 - 1) + "+");
    }
    static void FigureB(int n)
    {
        Console.WriteLine("+" + new String('-', n * 2 - 1) + "+");
        for (int i = 1; i < n; i++)
        {
            string side = new('_', n - i);
            Console.WriteLine("|" + side + new String('b', i * 2 - 1) + side + "|");
        }
        for (int i = n; i > 0; i--)
        {
            string side = new('_', n - i);
            Console.WriteLine("|" + side + new String('b', i * 2 - 1) + side + "|");
        }
        Console.WriteLine("+" + new String('-', n * 2 - 1) + "+");
    }

    static void FigureC(int n)
    {
        Console.WriteLine("+" + new String('-', n * 2 - 1) + "+");
        for (int i = 1; i < n; i++)
        {
            string side = new('_', n - i);
            Console.WriteLine("|" + side + new String('c', i * 2 - 1) + side + "|");
        }
        for (int i = n; i > 0; i--)
        {
            string side = new('_', n - i);
            Console.WriteLine("|" + side + new String('c', i * 2 - 1) + side + "|");
        }
        Console.WriteLine("+" + new String('-', n * 2 - 1) + "+");
    }
    static int Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Need only one argument!");
            for (int i=0; i < args.Length; i++)
            {
                string arg = args[i];
                Console.WriteLine($"arg {i} is {arg}");
            }
            return 1;
        }
        int n;
        try
        {
            n = int.Parse(args[0]);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error while parsing the argument: {e.Message}");
            return 1;
        }
        if (n < 1 || n > 20)
        {
            Console.WriteLine($"n must be between 1 and 20, provided: {n}");
        }
        FigureA(n);
        FigureB(n);
        FigureC(n);
        return 0;
    }
}
