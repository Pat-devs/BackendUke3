class Person
{
    public string Name { get; set; }
    
    private int age;
    public int Age
    { 
        get { return age; } 
        set
        {
            if (value < 1 || value > 150)
            {
                // we usually throw an error, this is an simplification:
                throw new ArgumentException("Age must be between 1 and 150");
            }
  
                age = value;
        }   
    }
    public Person(string name, int _age) 
    {
        Console.WriteLine("creating a new person...");
        
        // check if age is valid range
        if (_age >= 1 && _age <= 150)
        {
            Name = name;
            Age = _age;
        }
    }

    public void InstanceGreeter() 
    {
        Console.WriteLine("Hi my name is " + Name + ", and i am " + age + " years old.");
    }
}