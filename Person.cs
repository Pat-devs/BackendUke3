class Person
{
    // by default methods are inaccessible outside of the class (use for example public to make them accessible from outside)
    public static void Greeter()
    {
        Console.WriteLine("Hi, i am a person");

        TestMethod();
    }

    // this method is inaccessible from outside, but accessible from within Person-class or its other methods.
    static void TestMethod()
    {
        Console.WriteLine("Internal test method running :)");
    }
}