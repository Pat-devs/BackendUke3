namespace BackendUke3;

class Program
{
    static void Main(string[] args)
    {
        // example overloads
        // Console.WriteLine(1);
        // Console.WriteLine(0.5);
        // Console.WriteLine("text");

        // invoke greeter method without any arguments
        Greeter(); 
        // invoke greeter method with a number argument
        Greeter(1);
        // invoke greeter method with a string argument
        Greeter("God morgen!");
        // invoke greeter method with a string argument
        Greeter(0.25);

        Greeter("Patryk", "How are you?");
        Greeter(1234, "How are you?");
    }
    // greeter method
    static void Greeter()
    {
        Console.WriteLine("Hello world!");
    }
    // an overload of greeter that takes one (string) argument
    static void Greeter(string customGreeting)
    {
        Console.WriteLine(customGreeting);
    }
    // an overload of greeter that takes one (int) argument
    static void Greeter(int number)
    {
        Console.WriteLine(number);
    }
    // an overload of greeter that takes one (double) argument
    static void Greeter(double number)
    {
        Console.WriteLine(number);
    }

    // an overload that takes two arguments
    static void Greeter(string userName, string greetingText)
    {
        Console.WriteLine(userName);
        Console.Write(greetingText);
    }
    static void Greeter(int userId, string greetingText)
    {
        Console.WriteLine(userId);
        Console.Write(greetingText);
    }
}
