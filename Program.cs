namespace BackendUke3;

class Program
{
    static void Main(string[] args)
    {

        // Basic write to file example:

        //List<string> testList = new List<string>(); 
        // testList.Add("hei");

        //File.WriteAllLines("myfile.txt", testList);


        Console.WriteLine(bigData);

        Console.ReadLine();



        List<string> tagsList = new List<string>(); // tags list

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


                foreach(string tag in tagsArray)
                {
                    string cleanedTag = tag.Trim();
                    
                    tagsList.Add(cleanedTag);
                }
            }
            else if (choice == 2)
            {
                TagPrinter.Print(tagsList);
            }
            else if (choice == 3)
            {
                Console.WriteLine("saving to file (not implemented yet)");
            }
            else if (choice == 4)
            {
                Console.WriteLine("loading from file (not implemented yet)");
            }
            else if (choice == 5)
            {
                running = false;
                Console.WriteLine("Byebye.");
            }
        }
    }
}


