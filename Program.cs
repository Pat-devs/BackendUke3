namespace BackendUke3;

class Program
{
    static void Main(string[] args)
    {
        Greeter();

        //
        //Console.WriteLine(Person);

        Person.Greeter();
    }
    // static greeter method that uses a built in method to do something
    static void Greeter()
    {
        Console.WriteLine("Hello i belong to the main program class.");
    }
}


