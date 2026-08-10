class Person
{
    // "variables that belong to a class" are refered to as "properties"

    public string Name = "Patryk"; // PascalCase for public properties
    private int age = 46;

    // constructor method is a special method that runs when we create an instance of the class. It is used to configure (or give data to) the instance we create with the new keyword.
    public Person(string name, int _age) // a constructor method does not have return value nor type
    {
        // here we run our "instantiation code"
        Console.WriteLine("creating a new person...");
        
        Name = name;
        age = _age; // we cannot use age both here an as an instance property name, so we add a _ infront of age to make it separate.

        //Console.WriteLine(age);
    }

    public void InstanceGreeter() // non-static method (also known as an instance method)
    {
        Console.WriteLine("Hi my name is " + Name + ", and i am " + age + " years old.");
    }
}