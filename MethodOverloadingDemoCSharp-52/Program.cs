namespace MethodOverloadingDemoCSharp_52;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine(12);
        // Console.WriteLine(true);
        // Console.WriteLine('c');

        var added = Add(2.0, 2.0);
        Console.WriteLine(added);
        
        Greet("Seth", "Bowman", 19);
        Greet();
    }

    public static int Add(int numOne, int numTwo)
    {
        return numOne + numTwo;
    }

    public static double Add(double numOne, double numTwo)
    {
        return numOne + numTwo;
    }

    public static void Greet(string firstName)
    {
        Console.WriteLine($"Hello, {firstName}!");
    }

    public static void Greet(string firstName, string lastName)
    {
        Console.WriteLine($"Hello, {firstName} {lastName}");
    }

    public static void Greet(string firstName, string lastName, int age)
    {
        if (age >= 21)
        {
            Console.WriteLine($"Hello {firstName} {lastName}, you can enter the bar.");
        }
        else
        {
            Console.WriteLine($"Hello {firstName} {lastName}. You can't enter the bar.");
        }
    }

    public static void Greet()
    {
        Console.WriteLine("Hello!");
    }
}
