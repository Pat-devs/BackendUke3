namespace BackendUke3;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "tags.txt";
        List<TagModel> tagsList = new List<TagModel>(); // tags list

        Console.Clear();

        // Tag printer UI:

        bool running = true;

        while (running)
        {
            Console.WriteLine("Tag manager menu");
            Console.WriteLine("1. Enter new tag(s)");
            Console.WriteLine("2. Show current tags");
            Console.WriteLine("3. Save tags to file");
            Console.WriteLine("4. Load tags from file");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");

            int choice = 0;
            bool isInputValid = int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                Console.WriteLine("Enter a tag, or tags separated by comma");
                string userInputTags = Console.ReadLine(); // f.eks "Coffee" eller "tea, coffe, milk"

                // 1. parse the tags
                string[] tagsArray = userInputTags.Split(",");


                foreach(string tagInput in tagsArray)
                {
                    string cleanedTag = tagInput.Trim();
                    
                    // after cleaning we use the userdata to construct a new instance modelled after the TagModel class
                    TagModel tag = new TagModel(cleanedTag);
                    tagsList.Add(tag);
                }
            }
            else if (choice == 2)
            {
                TagPrinter.Print(tagsList);
            }
            else if (choice == 3)
            {
                Console.WriteLine("saving to file...");
                // before writning to the file we need convert the list of objects to a list of strings

                List<string> lines = new List<string>();

                foreach (TagModel tag in tagsList)
                {
                    lines.Add(tag.Name);
                }

                File.WriteAllLines(fileName, lines);

            }
            else if (choice == 4)
            {
                Console.WriteLine("loading from file...");
                if (File.Exists(fileName))
                {
                    string[] savedTags = File.ReadAllLines(fileName);

                    List<string> lines = new List<string>();
                    lines = new List<string>(savedTags);

                    foreach (string line in lines)
                    {
                        TagModel tag = new TagModel(line);
                        tagsList.Add(tag);
                    }
                }
            }
            else if (choice == 5)
            {
                running = false;
                Console.WriteLine("Byebye.");
            }
        }
    }
}


