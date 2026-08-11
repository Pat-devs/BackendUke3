class TagPrinter
{
    public static void Print(string tag) // prints a single tag
    {
        Console.WriteLine("Tag: #" + tag);
    }

    public static void Print(List<string> tags) // prints a list of tags
    {
        Console.WriteLine("Tags: ");

        foreach(string tag in tags)
        {
            Console.WriteLine("Tag: #" + tag);
        }
    }
}