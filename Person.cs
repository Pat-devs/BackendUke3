class Person
{
    public string Name { get; set; }
    private int age { get; set; }
    public Person(string name, int _age) 
    {
        Console.WriteLine("creating a new person...");
        
        // check if age is valid range
        if (_age >= 1 && _age <= 150)
        {
            Name = name;
            age = _age;
        }
    }

    public void InstanceGreeter() 
    {
        Console.WriteLine("Hi my name is " + Name + ", and i am " + age + " years old.");
    }
}