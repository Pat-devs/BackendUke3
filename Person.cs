class Person
{
    // "variables that belong to a class" are refered to as "properties"

    static public string Name = "Patryk"; // PascalCase for public properties
    static private int age = 46;

    // by default methods are inaccessible outside of the class (use for example public to make them accessible from outside)
    public static void Greeter()
    {
        Console.WriteLine("Hi, my name is " + Name + ", and i am " + age + " years old.");
    }
}